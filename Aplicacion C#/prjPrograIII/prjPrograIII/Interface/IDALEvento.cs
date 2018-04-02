using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
namespace Interfaces
{
    interface IDALEvento

    {
        Evento Get(int pId);
        void Insert(Evento param);
        void Update(Evento param);
        void Delete(int pId);
        List<Evento> GetAll();
        List<Evento> GetActiveEvents(DateTime pId);

    }
}
