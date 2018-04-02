using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
namespace Interfaces
{
    interface IBLLEvento
    {
        Evento Get(int pId);
        void Insert(Evento objToReturn);
        List<Evento> GetAll();
        void Borrar(int idCliente);
        List<Evento> GetActiveEvents(DateTime pId);
                void Update(Evento param);

    }
}
