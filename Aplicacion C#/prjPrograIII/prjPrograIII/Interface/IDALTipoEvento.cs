using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
namespace Interfaces
{
    interface IDALTipoEvento
    {
        TipoEvento Get(int pId);
        void Insert(TipoEvento param);
        void Update(TipoEvento param);
        void Delete(int pId);
        List<TipoEvento> GetAll();

    }
}
