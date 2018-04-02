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
    class BLLLocalidad : IBLLLocalidad
    {
        public void Insert(Localidad param)
        {
            IDALLocalidad _DALLocalidad = new DALLocalidad();
            if (Existe(param.IdLugar) == null)
                _DALLocalidad.Insert(param);
            else
                _DALLocalidad.Update(param);
        }


        public Localidad Existe(int pId)
        {
            IDALLocalidad _DALLocalidad = new DALLocalidad();

            return _DALLocalidad.Get(pId);
        }


        public void Borrar(int pId)
        {
            IDALLocalidad _DALLocalidad = new DALLocalidad();
            _DALLocalidad.Delete(pId);
        }

        public List<Localidad> GetAll()
        {
            IDALLocalidad _DALLocalidad = new DALLocalidad();
            return _DALLocalidad.GetAll();
        }

        public Localidad Get(int pId)
        {
            IDALLocalidad _DALLocalidad = new DALLocalidad();
            return _DALLocalidad.Get(pId);
        }

    }
}
