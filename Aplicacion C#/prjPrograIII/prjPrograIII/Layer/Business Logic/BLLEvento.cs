using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjPrograIII.Layer.Entities;
using prjPrograIII.Layer.DAL;

namespace prjPrograIII.Layer.Business_Logic
{
    class BLLEvento : IBLLEvento
    {
        public void Insert(Evento param)
        {
            IDALEvento _DALEvento = new DALEvento();
            if (Existe(param.IdEvento) == null)
                _DALEvento.Insert(param);
            else
                _DALEvento.Update(param);
        }

        public Evento Existe(int pId)
        {
            IDALEvento _DALEvento = new DALEvento();

            return _DALEvento.Get(pId);
        }

        public void Borrar(int pId)
        {
            IDALEvento _DALEvento = new DALEvento();
            _DALEvento.Delete(pId);
        }

        public List<Evento> GetAll()
        {
            IDALEvento _DALEvento = new DALEvento();
            return _DALEvento.GetAll();
        }

        public List<Evento> GetActiveEvents(DateTime pId)
        {
            IDALEvento _DALEvento = new DALEvento();
            return _DALEvento.GetActiveEvents(pId);
        }

        public Evento Get(int pId)
        {
            IDALEvento _DALEvento = new DALEvento();
            return _DALEvento.Get(pId);
        }

        public void Update(Evento param)
        {
            IDALEvento _DALEvento = new DALEvento();
            _DALEvento.Update(param);
        }

    }
}
