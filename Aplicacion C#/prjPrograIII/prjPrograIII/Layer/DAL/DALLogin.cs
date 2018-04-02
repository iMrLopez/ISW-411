using prjPrograIII.Layer.Entities;
using prjPrograIII.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPrograIII.Layer.DAL
{
    class DALLogin : IDALLogin
    {
        public   void Login(string pUsuario, string pContrasena)
        {

            StringBuilder conexion = new StringBuilder();


            conexion.Append(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            // Lee la conexion default
            //conexion.AppendFormat("{0}", ConfigurationManager.ConnectionStrings["default"].ConnectionString);
            // Agrega al usuario
            //conexion.AppendFormat("User Id={0};Password={1}", pUsuario, pContrasena);


            DataBase db = DatabaseFactory.CreateDataBase(conexion.ToString());
           
        }

     
    }
}
