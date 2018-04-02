using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
namespace Interfaces
{
    interface IDALEmpleado
    {
        Empleado Get(int pId);
        void Insert(Empleado param);
        void Update(Empleado param);
        void Delete(int pId);
        List<Empleado> GetAll();

    }
}
