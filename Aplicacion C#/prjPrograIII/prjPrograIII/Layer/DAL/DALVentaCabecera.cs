using Interfaces;
using prjPrograIII.Layer.DAL;
using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace prjPrograIII.Layer.DAL
{
    class DALVentaCabecera : IDALVentaCabecera
    {


        public int Insert(VentaCabecera param)
        {
            using (SqlConnection cn = new SqlConnection(FactoryConexion.CrearConexion()))
            {
                SqlCommand command = new SqlCommand("usp_INSERT_Trn_HeaderVenta", cn);
                command.CommandType = CommandType.StoredProcedure;

                //@idventa ,@idcliente ,@fechaventa ,@totalventa ,@tarjetapago ,@firmacliente

                command.Parameters.AddWithValue("@idcliente", SqlDbType.Int).Value = param.ClienteComprador.IdCliente;
                command.Parameters.AddWithValue("@fechaventa", SqlDbType.DateTime).Value = param.FechaActual.Date;
                command.Parameters.AddWithValue("@totalventa", SqlDbType.Int).Value = param.TotalVenta;
                command.Parameters.AddWithValue("@tarjetapago", SqlDbType.VarChar).Value = param.ModoPago.ToString();
                command.Parameters.AddWithValue("@firmacliente", SqlDbType.VarBinary).Value = param.FirmaCompra;

                command.Parameters.AddWithValue("@new_identity", SqlDbType.Int).Direction = ParameterDirection.Output;
                cn.Open();
                command.ExecuteNonQuery();
                cn.Close();
                return  int.Parse(command.Parameters["@new_identity"].Value.ToString());
            }
        }

        public List<VentaCabecera> GetAll()
        {
            DataSet ds = null;
            DateTime date1;
            List<VentaCabecera> lista = new List<VentaCabecera>();



            DataTable dt = new DataTable();

            using (SqlConnection cn = new SqlConnection(FactoryConexion.CrearConexion()))
            {
                SqlCommand command = new SqlCommand("usp_SELECT_Trn_HeaderVenta_All", cn);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adp = new SqlDataAdapter(command);
                adp.Fill(ds);
            }


            if (ds.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    VentaCabecera oVentaCabecera = new VentaCabecera()
                    {
                        IdVenta = int.Parse(dr["idventa"].ToString()),
                        FirmaCompra = (Byte[])dr["firmacliente"],


                    };

                    //Set the date for the event
                    DateTime.TryParse(dr["fechaventa"].ToString().Trim(), out date1);
                    oVentaCabecera.FechaActual = date1;


                    //Set the client 
                    IDALCliente _DALCliente = new DALCliente();
                    oVentaCabecera.ClienteComprador = _DALCliente.Get(int.Parse(dr["idcliente"].ToString()));

                    //Set the Detail of events
                    oVentaCabecera.DetalleEventosComprados = null;

                    lista.Add(oVentaCabecera);

                }

            }

            return lista;
        }
    }
}
