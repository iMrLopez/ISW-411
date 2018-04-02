using Interfaces;
using prjPrograIII.Layer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjPrograIII.Layer.Entities;

namespace prjPrograIII.Layer.Business_Logic
{
    class BLLCliente : IBLLCliente
    {


        public void Insert(Cliente param)
        {
            IDALCliente _DALCliente = new DALCliente();
            if (Existe(param.IdCliente) == null)
                _DALCliente.Insert(param);
            else
                _DALCliente.Update(param);
        }


        public Cliente Existe(int pId)
        {
            IDALCliente _DALCliente = new DALCliente();

            return _DALCliente.Get(pId);
        }


        public void BorrarCliente(int pId)
        {
            IDALCliente _DALCliente = new DALCliente();
            _DALCliente.Delete(pId);
        }

        internal object GetAll()
        {
            IDALCliente _DALCliente = new DALCliente();
            return _DALCliente.GetAll();
        }

        public Cliente Get(int pId)
        {
            IDALCliente _DALCliente = new DALCliente();
            return _DALCliente.Get(pId);
        }

        public List<Cliente> GetByName(string piD)
        {
            IDALCliente _DALCliente = new DALCliente();
            return _DALCliente.GetByName(piD);
        }
    }
}
