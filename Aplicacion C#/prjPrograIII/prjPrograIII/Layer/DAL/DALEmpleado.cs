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
    class DALEmpleado : IDALEmpleado
    {


        public void Insert(Empleado param)
        {
            string sql = @"INSERT INTO [PrjPrograIII].[dbo].[Sys_Empleado]
           ([IdEmpleado]
           ,[NombreEmpleado]
           ,[ApellidosEmpleado]
           ,[TelefonoEmpleado]
           ,[CorreoEmpleado]
           ,[DireccionEmpleado]
           ,[FotografiaEmpleado],
[TipoEmpleado])
     VALUES
           (@IdEmpleado,@NombreEmpleado,@ApellidosEmpleado,@TelefonoEmpleado,@CorreoEmpleado,@DireccionEmpleado,@FotografiaEmpleado,@TipoEmpleado)";


            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;


            // Pasar parámetros
            command.Parameters.AddWithValue("@IdEmpleado", param.IdEmpleado);
            command.Parameters.AddWithValue("@NombreEmpleado", param.NombreEmpleado);
            command.Parameters.AddWithValue("@ApellidosEmpleado", param.ApellidosEmpleado);
            command.Parameters.AddWithValue("@TelefonoEmpleado", param.TelefonoEmpleado);
            command.Parameters.AddWithValue("@CorreoEmpleado", param.CorreoEmpleado);
            command.Parameters.AddWithValue("@DireccionEmpleado", param.DireccionEmpleado);
            command.Parameters.AddWithValue("@FotografiaEmpleado", param.FotografiaEmpleado);
            command.Parameters.AddWithValue("@TipoEmpleado", param.Tipo);


            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }

        public List<Empleado> GetAll()
        {
            DataSet ds = null;
            string sql = @" select * from  [PrjPrograIII].[dbo].[Sys_Empleado]";
            SqlCommand Mycommand = new SqlCommand();
            DALNacionalidad _DALNacionalidad = new DALNacionalidad();
            DateTime date1;


            Mycommand.CommandText = sql;
            Mycommand.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(Mycommand, "query");
            }

            List<Empleado> lista = new List<Empleado>();

            if (ds.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Empleado oEmpleado = new Empleado()
                    {
                        IdEmpleado = int.Parse(dr["IdEmpleado"].ToString()),
                        NombreEmpleado = dr["NombreEmpleado"].ToString().Trim(),
                        ApellidosEmpleado = dr["ApellidosEmpleado"].ToString().Trim(),
                        TelefonoEmpleado = dr["TelefonoEmpleado"].ToString().Trim(),
                        CorreoEmpleado = dr["CorreoEmpleado"].ToString().Trim(),
                        DireccionEmpleado = dr["DireccionEmpleado"].ToString().Trim(),
                        FotografiaEmpleado = (Byte[])dr["FotografiaEmpleado"],
                    };
                    //Return the type of employee
                    TipoEmpleado TipoTemporal;
                    Enum.TryParse(dr["TipoEmpleado"].ToString().Trim(), out TipoTemporal);

                    oEmpleado.Tipo = TipoTemporal;


                    lista.Add(oEmpleado);
                }

            }

            return lista;
        }

        public void Delete(int pId)
        {
            string sql = @" delete   from  [PrjPrograIII].[dbo].[Sys_Empleado] where IDEmpleado = @IdEmpleado ";


            SqlCommand command = new SqlCommand();

            // Pasar parámetros
            command.Parameters.AddWithValue("@IdEmpleado", pId);
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }

        public Empleado Get(int pId)
        {
            DataSet ds = null;
            string sql = @" select * from  [PrjPrograIII].[dbo].[Sys_Empleado] where IdEmpleado = @IdEmpleado ";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@IdEmpleado", pId);



            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(command, "query");
            }

            // Extraer la tabla 
            DataTable dt = ds.Tables[0];


            Empleado objToReturn = null;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    objToReturn = new Empleado()
                    {
                        IdEmpleado = int.Parse(dr["IdEmpleado"].ToString()),
                        NombreEmpleado = dr["NombreEmpleado"].ToString().Trim(),
                        ApellidosEmpleado = dr["ApellidosEmpleado"].ToString().Trim(),
                        TelefonoEmpleado = dr["TelefonoEmpleado"].ToString().Trim(),
                        CorreoEmpleado = dr["CorreoEmpleado"].ToString().Trim(),
                        DireccionEmpleado = dr["DireccionEmpleado"].ToString().Trim(),
                        FotografiaEmpleado = (Byte[])dr["FotografiaEmpleado"],
                    };

                    //Return the type of employee
                    TipoEmpleado TipoTemporal;
                    Enum.TryParse(dr["TipoEmpleado"].ToString().Trim(), out TipoTemporal);

                    objToReturn.Tipo = TipoTemporal;

                }

            }
            return objToReturn;
        }

        public void Update(Empleado param)
        {
           string sql = @"UPDATE     [PrjPrograIII].[dbo].[Sys_Empleado]
                                Set    [IdEmpleado] = @IdEmpleado,  
                                       [NombreEmpleado] = @NombreEmpleado, 
                                       [ApellidosEmpleado] = @ApellidosEmpleado,
                                       [TelefonoEmpleado]   =@TelefonoEmpleado,
                                       [CorreoEmpleado] =@CorreoEmpleado,
                                       [DireccionEmpleado] = @DireccionEmpleado,
                                       [FotografiaEmpleado] = @FotografiaEmpleado,
                                        [TipoEmpleado] = @TipoEmpleado
                                 WHERE [IdEmpleado] = @IdEmpleado";



            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;


            // Pasar parámetros
            command.Parameters.AddWithValue("@IdEmpleado", param.IdEmpleado);
            command.Parameters.AddWithValue("@NombreEmpleado", param.NombreEmpleado);
            command.Parameters.AddWithValue("@ApellidosEmpleado", param.ApellidosEmpleado);
            command.Parameters.AddWithValue("@TelefonoEmpleado", param.TelefonoEmpleado);
            command.Parameters.AddWithValue("@CorreoEmpleado", param.CorreoEmpleado);
            command.Parameters.AddWithValue("@DireccionEmpleado", param.DireccionEmpleado);
            command.Parameters.AddWithValue("@FotografiaEmpleado", param.FotografiaEmpleado);
            command.Parameters.AddWithValue("@TipoEmpleado", param.Tipo);




            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }

    }
}
