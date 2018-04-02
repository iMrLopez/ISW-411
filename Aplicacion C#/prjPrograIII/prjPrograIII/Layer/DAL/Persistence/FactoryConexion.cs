using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FactoryConexion
{

    public static string CrearConexion()
    {

        StringBuilder conexion = new StringBuilder();

        conexion.Append(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PrjPrograIII;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        // Lee la conexion default
        //conexion.AppendFormat("{0}", ConfigurationManager.ConnectionStrings["default"].ConnectionString);
        // Agrega al usuario
        //conexion.AppendFormat("User Id={0};Password={1}", Usuario.GetInstance().Nombre, Usuario.GetInstance().Contrasena);

        return conexion.ToString();
    }

}

