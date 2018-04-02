using Interfaces;
using prjPrograIII.Layer.DAL;
using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPrograIII.Layer.Business_Logic
{
    class BLLLogin : IBLLLogin
    {
        public void Login(string pUsuario, string pContrasena)
        {
            DALLogin _DALLogin = new DALLogin();
            _DALLogin.Login(pUsuario, pContrasena);
        }
    }
}
