using Interfaces;
using prjPrograIII.Layer.DAL;
using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace prjPrograIII.Layer.DAL
{
    class DALVentaDetalle : IDALVentaDetalle
    {


        public void Insert(VentaDetalle param, int Cabecera)
        {
            using (SqlConnection cn = new SqlConnection(FactoryConexion.CrearConexion()))
            {
                SqlCommand command = new SqlCommand("usp_INSERT_Trn_DetailVenta", cn);
                command.CommandType = CommandType.StoredProcedure;

                //@idventa ,@qtyentradaspalco ,@qtyentradasvip ,@qtyentradasplata ,@idevento

                command.Parameters.AddWithValue("@idventa", SqlDbType.Int).Value = Cabecera;
                command.Parameters.AddWithValue("@qtyentradaspalco", SqlDbType.Int).Value = param.EntradasPalco;
                command.Parameters.AddWithValue("@qtyentradasvip", SqlDbType.Int).Value = param.EntradasVIP;
                command.Parameters.AddWithValue("@qtyentradasplata", SqlDbType.Int).Value = param.EntradasPlata;
                command.Parameters.AddWithValue("@idevento", SqlDbType.Int).Value = param.EventoComprado.IdEvento;

                cn.Open();
                command.ExecuteNonQuery();
                cn.Close();
            }
        }

        public List<VentaDetalle> GetAll()
        {
            DataSet ds = null;
            DateTime date1;
            List<VentaDetalle> lista = new List<VentaDetalle>();


            /*
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
                    VentaDetalle oVentaDetalle = new VentaDetalle()
                    {
                        EntradasPalco =
                        EntradasPlata = 
                        EntradasVIP = 
                    };

                    //Set the date for the event
                    DateTime.TryParse(dr["fechaventa"].ToString().Trim(), out date1);
                    oVentaDetalle.FechaActual = date1;


                    //Set the client 
                    IDALCliente _DALCliente = new DALCliente();
                    oVentaDetalle.ClienteComprador = _DALCliente.Get(int.Parse(dr["idcliente"].ToString()));

                    //Set the Detail of events
                    oVentaDetalle.DetalleEventosComprados = null;

                    lista.Add(oVentaDetalle);

                }

            }*/

            return lista;
        }
    }
}
