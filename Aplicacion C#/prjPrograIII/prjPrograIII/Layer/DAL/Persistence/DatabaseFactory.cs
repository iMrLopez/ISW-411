using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;
using System.Data;


class DatabaseFactory
{

    public static DataBase CreateDataBase(string pStringConnection)
    {

        try
        {

            DataBase db = new DataBase();

            SqlConnection conexion = new SqlConnection(pStringConnection);

            conexion.Open();

            db.Conexion = conexion;

            if (conexion.State != ConnectionState.Open)
            {

                throw new Exception("No se pudo abrir la Base de Datos, revise los parámetros de conexión! ");
            }

            return db;
        }
        catch (Exception )
        {    
                throw ;

        }

    }
  
}

