using Interfaces;
using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPrograIII.Layer.DAL
{
    class DALNacionalidad : IDALNacionalidad
    {
        public void Delete(int pId)
        {
            throw new NotImplementedException();
        }

        public Nacionalidad Get (int pId)
        {
            DataSet ds = null;
            string sql = @" select * from  [PrjPrograIII].[dbo].[Sys_Nacionalidad] where IdNacionalidad = @IdNacionalidad ";

            SqlCommand command = new SqlCommand();
            // Pasar parámetros
            command.Parameters.AddWithValue("@IdNacionalidad", pId);


            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(command, "query");
            }

            // Extraer la tabla 
            DataTable dt = ds.Tables[0];


            Nacionalidad objToReturn = null;
            if (dt.Rows.Count > 0)
            {
                objToReturn = new Nacionalidad()
                {
                    IdNacionalidad = int.Parse(dt.Rows[0]["IdNacionalidad"].ToString()),
                    DescrNacionalidad = dt.Rows[0]["DescrNacionalidad"].ToString().Trim(),

                };

            }

            return objToReturn;

        }

        public List<Nacionalidad> GetAll()
        {
            DataSet ds = null;
            string sql = @" select * from  [PrjPrograIII].[dbo].[Sys_Nacionalidad]";
            SqlCommand Mycommand = new SqlCommand();

            Mycommand.CommandText = sql;
            Mycommand.CommandType = CommandType.Text;

            using (DataBase db = DatabaseFactory.CreateDataBase(FactoryConexion.CrearConexion()))
            {
                ds = db.ExecuteReader(Mycommand, "query");
            }

            List<Nacionalidad> lista = new List<Nacionalidad>();

            if (ds.Tables[0].Rows.Count > 0)
            {

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Nacionalidad obj2return = new Nacionalidad()
                    {
                        IdNacionalidad = int.Parse(dr["IdNacionalidad"].ToString()),
                        DescrNacionalidad = dr["DescrNacionalidad"].ToString().Trim(),

                    };

                    lista.Add(obj2return);

                }

            }

            return lista;
        }

        public void Insert(Nacionalidad param)
        {
            throw new NotImplementedException();
        }

        public void Update(Nacionalidad param)
        {
            throw new NotImplementedException();
        }

    }
}
