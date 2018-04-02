using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
namespace Interfaces
{
    interface IDALVentaCabecera
    {
        int Insert(VentaCabecera param);
        List<VentaCabecera> GetAll();
    }
}
