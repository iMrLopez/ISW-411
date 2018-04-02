using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
namespace Interfaces
{
    interface IBLLLocalidad
    {
        Localidad Get(int pId);
        void Insert(Localidad objToReturn);
        List<Localidad> GetAll();
        void Borrar(int idCliente);
    }
}
