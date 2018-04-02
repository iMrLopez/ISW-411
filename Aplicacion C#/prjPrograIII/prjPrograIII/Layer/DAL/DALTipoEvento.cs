using Interfaces;
using prjPrograIII.Layer.DAL;
using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace prjPrograIII.Layer.DAL
{
    class DALTipoEvento : IDALTipoEvento
    {


        public void Insert(TipoEvento param)
        {
            string sql = @"INSERT INTO [PrjPrograIII].[dbo].[Sys_TipoEvento]
           ([IdTipoEvento]
           ,[DescripcionTipoEvento])
     VALUES
           (@IdTipoEvento,@DescripcionTipoEvento)";


            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;


            // Pasar parámetros
            command.Parameters.AddWithValue("@IdTipoEvento", param.IdTipoEvento);
            command.Parameters.AddWithValue("@DescripcionTipoEvento", param.DescripcionTipoEvento);

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }

        public List<TipoEvento> GetAll()
        {
            DataSet ds = null;
            string sql = @" select * from  [PrjPrograIII].[dbo].[Sys_TipoEvento]";
            SqlCommand Mycommand = new SqlCommand();

            Mycommand.CommandText = sql;
            Mycommand.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(Mycommand, "query");
            }

            List<TipoEvento> lista = new List<TipoEvento>();

            if (ds.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    TipoEvento obj2return = new TipoEvento()
                    {
                        IdTipoEvento = int.Parse(dr["IdTipoEvento"].ToString()),
                        DescripcionTipoEvento = dr["DescripcionTipoEvento"].ToString().Trim(),

                    };
                    lista.Add(obj2return);
                }

            }

            return lista;
        }

        public void Delete(int pId)
        {
            string sql = @" delete   from  [PrjPrograIII].[dbo].[Sys_TipoEvento] where IdTipoEvento = @IdTipoEvento ";


            SqlCommand command = new SqlCommand();

            // Pasar parámetros
            command.Parameters.AddWithValue("@IdTipoEvento", pId);
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }

        public TipoEvento Get(int pId)
        {
            DataSet ds = null;
            string sql = @" select * from  [PrjPrograIII].[dbo].[Sys_TipoEvento] where IdTipoEvento = @IdTipoEvento ";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@IdTipoEvento", pId);



            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(command, "query");
            }

            // Extraer la tabla 
            DataTable dt = ds.Tables[0];


            TipoEvento objToReturn = null;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    objToReturn = new TipoEvento()
                    {
                        IdTipoEvento = int.Parse(dr["IdTipoEvento"].ToString()),
                        DescripcionTipoEvento = dr["DescripcionTipoEvento"].ToString().Trim(),
                    };
                }
            }
            return objToReturn;
        }

        public void Update(TipoEvento param)
        {
           string sql = @"UPDATE     [PrjPrograIII].[dbo].[Sys_TipoEvento]
                                Set    [IdTipoEvento] = @IdTipoEvento,  
                                       [DescripcionTipoEvento] = @DescripcionTipoEvento
                                WHERE [IdTipoEvento] = @IdTipoEvento";



            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;


            // Pasar parámetros
            command.Parameters.AddWithValue("@IdTipoEvento", param.IdTipoEvento);
            command.Parameters.AddWithValue("@DescripcionTipoEvento", param.DescripcionTipoEvento);



            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }

    }
}
