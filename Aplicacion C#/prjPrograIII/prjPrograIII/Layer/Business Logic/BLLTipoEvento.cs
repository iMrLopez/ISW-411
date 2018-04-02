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
    class BLLTipoEvento : IBLLTipoEvento
    {
        public void Insert(TipoEvento param)
        {
            IDALTipoEvento _DALTipoEvento = new DALTipoEvento();
            if (Existe(param.IdTipoEvento) == null)
                _DALTipoEvento.Insert(param);
            else
                _DALTipoEvento.Update(param);
        }


        public TipoEvento Existe(int pId)
        {
            IDALTipoEvento _DALTipoEvento = new DALTipoEvento();
                        return _DALTipoEvento.Get(pId);
        }


        public void Borrar(int pId)
        {
            IDALTipoEvento _DALTipoEvento = new DALTipoEvento();
            _DALTipoEvento.Delete(pId);
        }

        public List<TipoEvento> GetAll()
        {
            IDALTipoEvento _DALTipoEvento = new DALTipoEvento();
            return _DALTipoEvento.GetAll();
        }

        public TipoEvento Get(int pId)
        {
            IDALTipoEvento _DALTipoEvento = new DALTipoEvento();
            return _DALTipoEvento.Get(pId);
        }

    }
}
