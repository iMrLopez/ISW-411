using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
namespace Interfaces
{
    interface IDALNacionalidad
    {
        Nacionalidad Get(int pId);
        void Insert(Nacionalidad param);
        void Update(Nacionalidad param);
        void Delete(int pId);
        List<Nacionalidad> GetAll();
        //List<Cliente> GetClienteByName(string pNombre);
    }
}
