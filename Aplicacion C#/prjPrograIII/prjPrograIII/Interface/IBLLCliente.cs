using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
namespace Interfaces
{
    interface IBLLCliente
    {
        Cliente Get(int pId);
        void Insert(Cliente objToReturn);

        List<Cliente> GetByName(string piD);
    }
}
