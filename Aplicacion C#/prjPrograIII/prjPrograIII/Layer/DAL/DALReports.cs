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
    class DALReports : IDALReports
    {


        public DataTable GetEventsByDateRange(DateTime fromDate, DateTime toDate) {
            DataTable rtrn = new DataTable();

            using (SqlConnection cn = new SqlConnection(FactoryConexion.CrearConexion()))
            {
                SqlCommand command = new SqlCommand("rpt_GetSalesByDay", cn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@From", SqlDbType.DateTime).Value = fromDate;
                command.Parameters.AddWithValue("@To", SqlDbType.DateTime).Value = toDate;
                SqlDataAdapter adp = new SqlDataAdapter(command);
                adp.Fill(rtrn);
            }

            return rtrn;
        }


        public DataTable GetEmptySeats(int pId)
        {
            DataTable rtrn = new DataTable();

            using (SqlConnection cn = new SqlConnection(FactoryConexion.CrearConexion()))
            {
                SqlCommand command = new SqlCommand("rpt_FreeSpacesOnEvent", cn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idEvento", SqlDbType.DateTime).Value = pId;
                SqlDataAdapter adp = new SqlDataAdapter(command);
                adp.Fill(rtrn);
            }

            return rtrn;
        }




    }
}
