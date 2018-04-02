using Interfaces;
using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace prjPrograIII.Layer.DAL
{
    class DALLocalidad : IDALLocalidad
    {


        public void Insert(Localidad param)
        {
            string sql = @"INSERT INTO [PrjPrograIII].[dbo].[Sys_Localidad]
           ([IdLugar]
           ,[NombreLugar]
           ,[CapacidadLugar]
           ,[MapaLugar]
           ,[EspaciosPalco]
           ,[EspaciosVIP]
           ,[EspaciosPlata])
     VALUES
           (@IdLugar,@NombreLugar,@CapacidadLugar,@MapaLugar,@EspaciosPalco,@EspaciosVIP,@EspaciosPlata)";


            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;


            // Pasar parámetros
            command.Parameters.AddWithValue("@IdLugar", param.IdLugar);
            command.Parameters.AddWithValue("@NombreLugar", param.NombreLugar);
            command.Parameters.AddWithValue("@CapacidadLugar", param.CapacidadLugar);
            command.Parameters.AddWithValue("@MapaLugar", param.MapaLugar);
            command.Parameters.AddWithValue("@EspaciosPalco", param.EspaciosPalco);
            command.Parameters.AddWithValue("@EspaciosVIP", param.EspaciosVIP);
            command.Parameters.AddWithValue("@EspaciosPlata", param.EspaciosPlata);


            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }

        public List<Localidad> GetAll()
        {
            DataSet ds = null;
            string sql = @" select * from  [PrjPrograIII].[dbo].[Sys_Localidad]";
            SqlCommand Mycommand = new SqlCommand();
            DALNacionalidad _DALNacionalidad = new DALNacionalidad();
            DateTime date1;


            Mycommand.CommandText = sql;
            Mycommand.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(Mycommand, "query");
            }

            List<Localidad> lista = new List<Localidad>();

            if (ds.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Localidad oLocalidad = new Localidad()
                    {
                        IdLugar = int.Parse(dr["IdLugar"].ToString()),
                        NombreLugar = dr["NombreLugar"].ToString().Trim(),
                        CapacidadLugar = int.Parse(dr["CapacidadLugar"].ToString().Trim()),
                        MapaLugar = (Byte[])dr["MapaLugar"],
                        EspaciosPalco = int.Parse(dr["EspaciosPalco"].ToString().Trim()),
                        EspaciosVIP = int.Parse(dr["EspaciosVIP"].ToString().Trim()),
                        EspaciosPlata = int.Parse(dr["EspaciosPlata"].ToString().Trim()),
                    };
                    lista.Add(oLocalidad);
                }

            }

            return lista;
        }

        public void Delete(int pId)
        {
            string sql = @" delete   from  [PrjPrograIII].[dbo].[Sys_Localidad] where IdLugar = @IdLugar ";


            SqlCommand command = new SqlCommand();

            // Pasar parámetros
            command.Parameters.AddWithValue("@IdLugar", pId);
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }

        public Localidad Get(int pId)
        {
            DataSet ds = null;
            string sql = @" select * from  [PrjPrograIII].[dbo].[Sys_Localidad] where IdLugar = @IdLugar ";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@IdLugar", pId);



            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(command, "query");
            }

            // Extraer la tabla 
            DataTable dt = ds.Tables[0];


            Localidad objToReturn = null;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    objToReturn = new Localidad()
                    {
                        IdLugar = int.Parse(dr["IdLugar"].ToString()),
                        NombreLugar = dr["NombreLugar"].ToString().Trim(),
                        CapacidadLugar = int.Parse(dr["CapacidadLugar"].ToString().Trim()),
                        MapaLugar = (Byte[])dr["MapaLugar"],
                        EspaciosPalco = int.Parse(dr["EspaciosPalco"].ToString().Trim()),
                        EspaciosVIP = int.Parse(dr["EspaciosVIP"].ToString().Trim()),
                        EspaciosPlata = int.Parse(dr["EspaciosPlata"].ToString().Trim()),
                    };
                }
            }
            return objToReturn;
        }

        public void Update(Localidad param)
        {
           string sql = @"UPDATE     [PrjPrograIII].[dbo].[Sys_Localidad]
                                Set    [IdLugar] = @IdLugar,  
                                       [NombreLugar] = @NombreLugar, 
                                       [CapacidadLugar] = @CapacidadLugar,
                                       [MapaLugar]   =@MapaLugar,
                                       [EspaciosPalco] =@EspaciosPalco,
                                       [EspaciosVIP] = @EspaciosVIP,
                                       [EspaciosPlata] = @EspaciosPlata
                                 WHERE [IdLugar] = @IdLugar";



            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;


            // Pasar parámetros
            command.Parameters.AddWithValue("@IdLugar", param.IdLugar);
            command.Parameters.AddWithValue("@NombreLugar", param.NombreLugar);
            command.Parameters.AddWithValue("@CapacidadLugar", param.CapacidadLugar);
            command.Parameters.AddWithValue("@MapaLugar", param.MapaLugar);
            command.Parameters.AddWithValue("@EspaciosPalco", param.EspaciosPalco);
            command.Parameters.AddWithValue("@EspaciosVIP", param.EspaciosVIP);
            command.Parameters.AddWithValue("@EspaciosPlata", param.EspaciosPlata);



            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }

    }
}
