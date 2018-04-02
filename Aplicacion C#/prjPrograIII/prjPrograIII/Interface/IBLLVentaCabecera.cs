using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
namespace Interfaces
{
    interface IBLLVentaCabecera
    {
        int Insert(VentaCabecera objToReturn);
        List<VentaCabecera> GetAll();
    }
}
