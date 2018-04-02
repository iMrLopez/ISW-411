using Interfaces;
using prjPrograIII.Layer.Business_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPrograIII.Layer.Entities
{
    class Usuario
    {
        public static Empleado _Usuario;

        private Usuario() { }

        public static void GetInstance(int UserId)
        {
          IBLLEmpleado _BLLEmpleado = new BLLEmpleado();
             if (_Usuario == null)
                _Usuario = _BLLEmpleado.Get(UserId);
        }
    }
}
