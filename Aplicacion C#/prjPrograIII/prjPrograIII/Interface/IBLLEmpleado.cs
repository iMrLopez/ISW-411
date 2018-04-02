using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
namespace Interfaces
{
    interface IBLLEmpleado
    {
        Empleado Get(int pId);
        void Insert(Empleado objToReturn);
        List<Empleado> GetAll();
        void BorrarEmpleado(int idCliente);
        //List<Empleado> ObtenerEmpleadoPorNombre(string pNombre);
    }
}
