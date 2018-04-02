using Interfaces;
using prjPrograIII.Layer.DAL;
using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace prjPrograIII.Layer.DAL
{
    class DALCliente : IDALCliente
    {


        public void Insert(Cliente param)
        {
            string sql = @"INSERT INTO [PrjPrograIII].[dbo].[Sys_Cliente]
                                       ([IdCliente]
                                       ,[NombreCliente]
                                       ,[FNacimCliente]
                                       ,[SexoCliente]
                                       ,[CorreoCliente]
                                       ,[NacionalidadCliente])
                                 VALUES
                                       (@IdCliente,@NombreCliente,@FNacimCliente,@SexoCliente,@CorreoCliente,@NacionalidadCliente)";


            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            if (param.SexoCliente == Sexo.Femenino)
                command.Parameters.AddWithValue("@SexoCliente", 1);
            else
                command.Parameters.AddWithValue("@SexoCliente", 2);


            // Pasar parámetros
            command.Parameters.AddWithValue("@IdCliente", param.IdCliente);
            command.Parameters.AddWithValue("@NombreCliente", param.NombreCliente);
            command.Parameters.AddWithValue("@FNacimCliente", param.FNacimCliente.Date);
            command.Parameters.AddWithValue("@CorreoCliente", param.CorreoCliente);
            command.Parameters.AddWithValue("@NacionalidadCliente", param.NacionalidadCliente.IdNacionalidad);




            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }

        public List<Cliente> GetAll()
        {
            DataSet ds = null;
            string sql = @" select * from  [PrjPrograIII].[dbo].[Sys_Cliente]";
            SqlCommand Mycommand = new SqlCommand();
            DALNacionalidad _DALNacionalidad = new DALNacionalidad();
            DateTime date1;


            Mycommand.CommandText = sql;
            Mycommand.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(Mycommand, "query");
            }

            List<Cliente> lista = new List<Cliente>();

            if (ds.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Cliente oCliente = new Cliente()
                    {
                        IdCliente = int.Parse(dr["IdCliente"].ToString()),
                        NombreCliente = dr["NombreCliente"].ToString().Trim(),
                        CorreoCliente = dr["CorreoCliente"].ToString().Trim(),

                    };

                    //Set the nationality of the client
                    oCliente.NacionalidadCliente = _DALNacionalidad.Get((int.Parse((dr["NacionalidadCliente"].ToString().Trim()))));

                    //Set the born date for the client
                    DateTime.TryParse(dr["FNacimCliente"].ToString().Trim(),out date1);
                    oCliente.FNacimCliente = date1;

                    if (dr["SexoCliente"].ToString().Trim().Equals('1')) 
                    {
                        oCliente.SexoCliente = Sexo.Femenino;
                    }else
                    {
                        oCliente.SexoCliente = Sexo.Masculino;

                    }

                    lista.Add(oCliente);

                }

            }

            return lista;
        }

        public void Delete(int pId)
        {
            string sql = @" delete   from  [PrjPrograIII].[dbo].[Sys_Cliente] where IDCliente = @IdCliente ";


            SqlCommand command = new SqlCommand();

            // Pasar parámetros
            command.Parameters.AddWithValue("@IdCliente", pId);
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }

        public Cliente Get(int pId)
        {
            DataSet ds = null;
            string sql = @" select * from  [PrjPrograIII].[dbo].[Sys_Cliente] where IdCliente = @IdCliente ";
            DALNacionalidad _DALNacionalidad = new DALNacionalidad();
            DateTime date1;

            SqlCommand command = new SqlCommand();
            // Pasar parámetros
            command.Parameters.AddWithValue("@IdCliente", pId);


            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(command, "query");
            }

            // Extraer la tabla 
            DataTable dt = ds.Tables[0];


            Cliente objToReturn = null;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    objToReturn = new Cliente()
                    {
                        IdCliente = int.Parse(dr["IdCliente"].ToString()),
                        NombreCliente = dr["NombreCliente"].ToString().Trim(),
                        CorreoCliente = dr["CorreoCliente"].ToString().Trim(),

                    };

                    //Set the nationality of the client
                    objToReturn.NacionalidadCliente = _DALNacionalidad.Get((int.Parse((dr["NacionalidadCliente"].ToString().Trim()))));

                    //Set the born date for the client
                    DateTime.TryParse(dr["FNacimCliente"].ToString().Trim(), out date1);
                    objToReturn.FNacimCliente = date1;

                    if (dr["SexoCliente"].ToString().Trim().Equals('1'))
                    {
                        objToReturn.SexoCliente = Sexo.Femenino;
                    }
                    else
                    {
                        objToReturn.SexoCliente = Sexo.Masculino;

                    }
                }
            }
            return objToReturn;
        }

        public void Update(Cliente param)
        {
            string sql = @"UPDATE     [PrjPrograIII].[dbo].[Sys_Cliente]
                                Set    [IdCliente] = @IdCliente,  
                                       [NombreCliente] = @NombreCliente, 
                                       [FNacimCliente] = @FNacimCliente,
                                       [SexoCliente]   =@SexoCliente,
                                       [CorreoCliente] =@CorreoCliente,
                                       [NacionalidadCliente] = @NacionalidadCliente
                                 WHERE [IdCliente] = @IdCliente";


            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            // Pasar parámetros
            command.Parameters.AddWithValue("@IdCliente", param.IdCliente);
            command.Parameters.AddWithValue("@NombreCliente", param.NombreCliente);
            command.Parameters.AddWithValue("@FNacimCliente", param.FNacimCliente.Date);
            command.Parameters.AddWithValue("@SexoCliente", param.SexoCliente);
            command.Parameters.AddWithValue("@CorreoCliente", param.CorreoCliente);
            command.Parameters.AddWithValue("@NacionalidadCliente", param.NacionalidadCliente.IdNacionalidad);



            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }

        public List<Cliente> GetByName(string piD)
        {
            DataSet ds = null;
            string sql = @" select * from  [PrjPrograIII].[dbo].[Sys_Cliente] Where NombreCliente LIKE @pId";
            SqlCommand Mycommand = new SqlCommand();
            DALNacionalidad _DALNacionalidad = new DALNacionalidad();
            DateTime date1;
            Mycommand.CommandText = sql;
            Mycommand.CommandType = CommandType.Text;

            Mycommand.Parameters.AddWithValue("@pId", piD += "%");


            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(Mycommand, "query");
            }

            List<Cliente> lista = new List<Cliente>();

            if (ds.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Cliente oCliente = new Cliente()
                    {
                        IdCliente = int.Parse(dr["IdCliente"].ToString()),
                        NombreCliente = dr["NombreCliente"].ToString().Trim(),
                        CorreoCliente = dr["CorreoCliente"].ToString().Trim(),

                    };

                    //Set the nationality of the client
                    oCliente.NacionalidadCliente = _DALNacionalidad.Get((int.Parse((dr["NacionalidadCliente"].ToString().Trim()))));

                    //Set the born date for the client
                    DateTime.TryParse(dr["FNacimCliente"].ToString().Trim(), out date1);
                    oCliente.FNacimCliente = date1;

                    if (dr["SexoCliente"].ToString().Trim().Equals('1'))
                    {
                        oCliente.SexoCliente = Sexo.Femenino;
                    }
                    else
                    {
                        oCliente.SexoCliente = Sexo.Masculino;

                    }

                    lista.Add(oCliente);

                }

            }

            return lista;
        }


    }
}
