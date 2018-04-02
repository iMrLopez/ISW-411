using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
namespace Interfaces
{
    interface IDALLocalidad

    {
        Localidad Get(int pId);
        void Insert(Localidad param);
        void Update(Localidad param);
        void Delete(int pId);
        List<Localidad> GetAll();

    }
}
