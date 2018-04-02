using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
namespace Interfaces
{
    interface IBLLVentaDetalle
    {
        void Insert(VentaDetalle objToReturn, int p2);
        List<VentaDetalle> GetAll();
    }
}
