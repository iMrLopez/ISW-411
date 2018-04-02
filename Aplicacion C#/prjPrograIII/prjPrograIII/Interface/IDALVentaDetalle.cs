using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
namespace Interfaces
{
    interface IDALVentaDetalle
    {
        void Insert(VentaDetalle param, int Cabecera);
        List<VentaDetalle> GetAll();
    }
}
