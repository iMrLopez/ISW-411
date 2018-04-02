using Interfaces;
using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace prjPrograIII.Layer.DAL
{
    class DALEvento : IDALEvento
    {


        public void Insert(Evento param)
        {
            string sql = @"INSERT INTO [PrjPrograIII].[dbo].[Sys_Evento]
           ([IdEvento],[IdTipoEvento],[DescripcionEvento],[LogoEvento],[FechaEvento],[EstadoEvento],[CantEntradasEvento],[IdLugarEvento],[CostoPlata],[CostoPalco],[CostoVIP],[EntradasPlata]
           ,[EntradasPalco]
           ,[EntradasVIP])
            VALUES
           (@IdEvento,@IdTipoEvento,@DescripcionEvento,@LogoEvento,@FechaEvento,@EstadoEvento,@CantEntradasEvento,@IdLugarEvento,@CostoPlata,@CostoPalco,@CostoVIP,@EntradasPlata,@EntradasPalco,@EntradasVIP)";


            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;


            // Pasar parámetros
            command.Parameters.AddWithValue("@IdEvento", param.IdEvento);
            command.Parameters.AddWithValue("@IdTipoEvento", param.TipoEvento.IdTipoEvento);
            command.Parameters.AddWithValue("@DescripcionEvento", param.DescripcionEvento);
            command.Parameters.AddWithValue("@LogoEvento", param.LogoEvento);
            command.Parameters.AddWithValue("@FechaEvento", param.FechaEvento.Date);
            command.Parameters.AddWithValue("@EstadoEvento", param.EstadoEvento);
            command.Parameters.AddWithValue("@CantEntradasEvento", param.CantEntradasEvento);
            command.Parameters.AddWithValue("@IdLugarEvento", param.LugarEvento.IdLugar);
            command.Parameters.AddWithValue("@CostoPlata", param.CostoPlata);
            command.Parameters.AddWithValue("@CostoPalco", param.CostoPalco);
            command.Parameters.AddWithValue("@CostoVIP", param.CostoVIP);
            command.Parameters.AddWithValue("@EntradasPlata", param.EntradasPlata);
            command.Parameters.AddWithValue("@EntradasPalco", param.EntradasPalco);
            command.Parameters.AddWithValue("@EntradasVIP", param.EntradasVIP);


            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }

        public List<Evento> GetAll()
        {
            DataSet ds = null;
            string sql = @" select * from  [PrjPrograIII].[dbo].[Sys_Evento]";
            SqlCommand Mycommand = new SqlCommand();

            DateTime date1;
            IDALTipoEvento _DALTipoEvento = new DALTipoEvento();
            IDALLocalidad _DALLocalidad = new DALLocalidad();



            Mycommand.CommandText = sql;
            Mycommand.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(Mycommand, "query");
            }

            List<Evento> lista = new List<Evento>();

            if (ds.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Evento oEvento = new Evento()
                    {
                        IdEvento = int.Parse(dr["IdEvento"].ToString()),
                        DescripcionEvento = dr["DescripcionEvento"].ToString().Trim(),
                        EstadoEvento = int.Parse(dr["EstadoEvento"].ToString().Trim()),
                        LogoEvento = (Byte[])dr["LogoEvento"],
                        CantEntradasEvento = int.Parse(dr["CantEntradasEvento"].ToString().Trim()),
                        CostoPlata = int.Parse(dr["CostoPlata"].ToString().Trim()),
                        CostoPalco = int.Parse(dr["CostoPalco"].ToString().Trim()),
                        CostoVIP = int.Parse(dr["CostoVIP"].ToString().Trim()),
                        EntradasPalco = int.Parse(dr["EntradasPalco"].ToString().Trim()),
                        EntradasVIP = int.Parse(dr["EntradasVIP"].ToString().Trim()),
                        EntradasPlata = int.Parse(dr["EntradasPlata"].ToString().Trim()),
                    };

                    //Set the date for the event
                    DateTime.TryParse(dr["FechaEvento"].ToString().Trim(), out date1);
                    oEvento.FechaEvento = date1;

                    //Set the type of event
                    oEvento.TipoEvento = _DALTipoEvento.Get(int.Parse(dr["IdTipoEvento"].ToString().Trim()));

                    //Set the locality for the event
                    oEvento.LugarEvento = _DALLocalidad.Get(int.Parse(dr["IdLugarEvento"].ToString().Trim()));

                    
                    lista.Add(oEvento);
                }

            }

            return lista;
        }

        public void Delete(int pId)
        {
            string sql = @" delete   from  [PrjPrograIII].[dbo].[Sys_Evento] where IdEvento = @IdEvento ";


            SqlCommand command = new SqlCommand();

            // Pasar parámetros
            command.Parameters.AddWithValue("@IdEvento", pId);
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }

        public Evento Get(int pId)
        {
            DataSet ds = null;
            string sql = @" select * from  [PrjPrograIII].[dbo].[Sys_Evento] where IdEvento = @IdEvento ";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@IdEvento", pId);


            DateTime date1;
            IDALTipoEvento _DALTipoEvento = new DALTipoEvento();
            IDALLocalidad _DALLocalidad = new DALLocalidad();


            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(command, "query");
            }

            // Extraer la tabla 
            DataTable dt = ds.Tables[0];


            Evento objToReturn = null;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    objToReturn = new Evento()
                    {
                        IdEvento = int.Parse(dr["IdEvento"].ToString()),
                        DescripcionEvento = dr["DescripcionEvento"].ToString().Trim(),
                        EstadoEvento = int.Parse(dr["EstadoEvento"].ToString().Trim()),
                        LogoEvento = (Byte[])dr["LogoEvento"],
                        CantEntradasEvento = int.Parse(dr["CantEntradasEvento"].ToString().Trim()),
                        CostoPlata = int.Parse(dr["CostoPlata"].ToString().Trim()),
                        CostoPalco = int.Parse(dr["CostoPalco"].ToString().Trim()),
                        CostoVIP = int.Parse(dr["CostoVIP"].ToString().Trim()),
                        EntradasPalco = int.Parse(dr["EntradasPalco"].ToString().Trim()),
                        EntradasVIP = int.Parse(dr["EntradasVIP"].ToString().Trim()),
                        EntradasPlata = int.Parse(dr["EntradasPlata"].ToString().Trim()),
                    };

                    //Set the date for the event
                    DateTime.TryParse(dr["FechaEvento"].ToString().Trim(), out date1);
                    objToReturn.FechaEvento = date1;

                    //Set the type of event
                    objToReturn.TipoEvento = _DALTipoEvento.Get(int.Parse(dr["IdTipoEvento"].ToString().Trim()));

                    //Set the locality for the event
                    objToReturn.LugarEvento = _DALLocalidad.Get(int.Parse(dr["IdLugarEvento"].ToString().Trim()));
                }
            }
            return objToReturn;
        }

        public void Update(Evento param)
        {
           string sql = @"UPDATE     [PrjPrograIII].[dbo].[Sys_Evento]
                                Set    [IdEvento] = @IdEvento,  
                                       [IdTipoEvento] = @IdTipoEvento, 
                                       [DescripcionEvento] = @DescripcionEvento,
                                       [LogoEvento]   =@LogoEvento,
                                       [FechaEvento] =@FechaEvento,
                                       [EstadoEvento] = @EstadoEvento,
                                       [CantEntradasEvento] = @CantEntradasEvento,
                                        [IdLugarEvento] = @IdLugarEvento,
                                        [CostoPlata] = @CostoPlata,
                                        [CostoPalco] = @CostoPalco,
                                        [CostoVIP] = @CostoVIP,
[EntradasPlata] = @EntradasPlata,[EntradasPalco] = @EntradasPalco,[EntradasVIP] = @EntradasVIP
                                 WHERE [IdEvento] = @IdEvento";



            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            // Pasar parámetros
            command.Parameters.AddWithValue("@IdEvento", param.IdEvento);
            command.Parameters.AddWithValue("@IdTipoEvento", param.TipoEvento.IdTipoEvento);
            command.Parameters.AddWithValue("@DescripcionEvento", param.DescripcionEvento);
            command.Parameters.AddWithValue("@LogoEvento", param.LogoEvento);
            command.Parameters.AddWithValue("@FechaEvento", param.FechaEvento.Date);
            command.Parameters.AddWithValue("@EstadoEvento", param.EstadoEvento);
            command.Parameters.AddWithValue("@CantEntradasEvento", param.CantEntradasEvento);
            command.Parameters.AddWithValue("@IdLugarEvento", param.LugarEvento.IdLugar);
            command.Parameters.AddWithValue("@CostoPlata", param.CostoPlata);
            command.Parameters.AddWithValue("@CostoPalco", param.CostoPalco);
            command.Parameters.AddWithValue("@CostoVIP", param.CostoVIP);
            command.Parameters.AddWithValue("@EntradasPlata", param.EntradasPlata);
            command.Parameters.AddWithValue("@EntradasPalco", param.EntradasPalco);
            command.Parameters.AddWithValue("@EntradasVIP", param.EntradasVIP);

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                db.ExecuteNonQuery(command, IsolationLevel.ReadCommitted);
            }
        }

        public List<Evento> GetActiveEvents(DateTime pId)
        {
            DataSet ds = null;
            string sql = @" select * from  [PrjPrograIII].[dbo].[Sys_Evento] Where FechaEvento >= @FechaActual AND (EntradasPlata != 0 OR EntradasPalco != 0 OR EntradasVIP!= 0)";
            SqlCommand Mycommand = new SqlCommand();
            Mycommand.Parameters.AddWithValue("@FechaActual", pId.Date);


            DateTime date1;
            IDALTipoEvento _DALTipoEvento = new DALTipoEvento();
            IDALLocalidad _DALLocalidad = new DALLocalidad();



            Mycommand.CommandText = sql;
            Mycommand.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(Mycommand, "query");
            }

            List<Evento> lista = new List<Evento>();

            if (ds.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Evento oEvento = new Evento()
                    {
                        IdEvento = int.Parse(dr["IdEvento"].ToString()),
                        DescripcionEvento = dr["DescripcionEvento"].ToString().Trim(),
                        EstadoEvento = int.Parse(dr["EstadoEvento"].ToString().Trim()),
                        LogoEvento = (Byte[])dr["LogoEvento"],
                        CantEntradasEvento = int.Parse(dr["CantEntradasEvento"].ToString().Trim()),
                        CostoPlata = int.Parse(dr["CostoPlata"].ToString().Trim()),
                        CostoPalco = int.Parse(dr["CostoPalco"].ToString().Trim()),
                        CostoVIP = int.Parse(dr["CostoVIP"].ToString().Trim()),
                        EntradasPalco = int.Parse(dr["EntradasPalco"].ToString().Trim()),
                        EntradasVIP = int.Parse(dr["EntradasVIP"].ToString().Trim()),
                        EntradasPlata = int.Parse(dr["EntradasPlata"].ToString().Trim()),
                    };

                    //Set the date for the event
                    DateTime.TryParse(dr["FechaEvento"].ToString().Trim(), out date1);
                    oEvento.FechaEvento = date1;

                    //Set the type of event
                    oEvento.TipoEvento = _DALTipoEvento.Get(int.Parse(dr["IdTipoEvento"].ToString().Trim()));

                    //Set the locality for the event
                    oEvento.LugarEvento = _DALLocalidad.Get(int.Parse(dr["IdLugarEvento"].ToString().Trim()));


                    lista.Add(oEvento);
                }

            }

            return lista;
        }
    }
}
