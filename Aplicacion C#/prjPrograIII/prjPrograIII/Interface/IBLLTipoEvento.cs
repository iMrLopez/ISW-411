using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
namespace Interfaces
{
    interface IBLLTipoEvento
    {
        TipoEvento Get(int pId);
        void Insert(TipoEvento objToReturn);
        List<TipoEvento> GetAll();
        void Borrar(int pId);
    }
}
