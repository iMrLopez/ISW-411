using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.IO;


public class DataBase : IDisposable
{

    public SqlConnection Conexion { get; set; }

    public SqlDataReader ExecuteReader(SqlCommand pSqlCommand)
    {

        SqlDataReader lector = null;
        try
        {

            pSqlCommand.Connection = Conexion;
            lector = pSqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
            return lector;
        }
        catch (Exception)
        {


            throw;
        }


    }

    public DataSet ExecuteReader(SqlCommand pSqlCommand, String pTabla)
    {

        DataSet dsTabla = new DataSet();
        try
        {
            using (SqlDataAdapter adaptador = new SqlDataAdapter(pSqlCommand))
            {
                pSqlCommand.Connection = Conexion;
                dsTabla = new DataSet();
                adaptador.Fill(dsTabla, pTabla);
            }
            return dsTabla;
        }
        catch (Exception)
        {

            // lanzar excepción                     
            throw;
        }
        finally
        {

            if (dsTabla != null)
                dsTabla.Dispose();


        }



    }

    public int ExecuteNonQuery(SqlCommand pSQLCommand, IsolationLevel pIsolationLevel)
    {
        using (SqlTransaction transaccion = Conexion.BeginTransaction(pIsolationLevel))
        {
            int registrosafectados = 0;
            try
            {

                pSQLCommand.Connection = Conexion;
                pSQLCommand.Transaction = transaccion;
                registrosafectados = pSQLCommand.ExecuteNonQuery();

                // Commit a la transacción
                transaccion.Commit();

                return registrosafectados;
            }

            catch (Exception)
            {

                throw;
            }

        }

    }

    public int ExecuteNonQuery(SqlCommand pSQLCommand)
    {

        int registrosafectados = 0;
        try
        {

            pSQLCommand.Connection = Conexion;

            registrosafectados = pSQLCommand.ExecuteNonQuery();

            return registrosafectados;

        }
        catch (Exception  )
        {

            throw  ;
        }
    }

    public void ExecuteNonQuery(ref SqlCommand pSQLCommand, IsolationLevel pIsolationLevel)
    {
        using (SqlTransaction transaccion = Conexion.BeginTransaction(pIsolationLevel))
        {

            try
            {

                pSQLCommand.Connection = Conexion;
                pSQLCommand.Transaction = transaccion;
                pSQLCommand.ExecuteNonQuery();

                // Commit a la transacción
                transaccion.Commit();


            }

            catch (Exception error)
            {

                throw error;
            }

        }

    }

    public void ExecuteNonQuery(List<SqlCommand> pCommands, IsolationLevel pIsolationLevel)
    {


        using (SqlTransaction transaccion = Conexion.BeginTransaction(pIsolationLevel))
        {
            try
            {
                foreach (SqlCommand command in pCommands)
                {
                    command.Connection = Conexion;
                    command.Transaction = transaccion;
                    // command.CommandTimeout = int.Parse(System.Configuration.ConfigurationManager.AppSettings["ConnectionTimeOut"].ToString());
                    command.ExecuteNonQuery();
                }
                // Commit a la transacción
                transaccion.Commit();
            }

            catch (Exception  )
            {
                 
                throw  ;
            }
            finally
            {
            }
        }
    }



    #region IDisposable Members

    public void Dispose()
    {
        if (Conexion != null)
            Conexion.Close();
    }

    #endregion
}

