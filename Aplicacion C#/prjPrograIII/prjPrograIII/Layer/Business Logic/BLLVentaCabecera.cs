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
    class BLLVentaCabecera : IBLLVentaCabecera
    {


        public int Insert(VentaCabecera param)
        {
            IDALVentaCabecera _DALVentaCabecera = new DALVentaCabecera();
               return  _DALVentaCabecera.Insert(param);
        }

        public List<VentaCabecera> GetAll()
        {
            IDALVentaCabecera _DALVentaCabecera = new DALVentaCabecera();
            return _DALVentaCabecera.GetAll();
        }

    }
}
