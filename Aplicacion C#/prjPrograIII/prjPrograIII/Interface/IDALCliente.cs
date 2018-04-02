using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
namespace Interfaces
{
    interface IDALCliente
    {
        Cliente Get(int pId);
        void Insert(Cliente param);
        void Update(Cliente param);
        void Delete(int pId);
        List<Cliente> GetAll();
        List<Cliente> GetByName(string piD);
    }
}
