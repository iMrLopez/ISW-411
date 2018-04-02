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
    class BLLVentaDetalle : IBLLVentaDetalle
    {


        public void Insert(VentaDetalle param, int p2)
        {
            IDALVentaDetalle _DALVentaDetalle = new DALVentaDetalle();
                _DALVentaDetalle.Insert(param, p2);
        }

        public List<VentaDetalle> GetAll()
        {
            IDALVentaDetalle _DALVentaDetalle = new DALVentaDetalle();
            return _DALVentaDetalle.GetAll();
        }

    }
}
