using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjPrograIII.Layer.Entities;
using prjPrograIII.Layer.DAL;
using Microsoft.SqlServer;

namespace prjPrograIII.Layer.Business_Logic
{
    class BLLEmpleado : IBLLEmpleado
    {
        public void Insert(Empleado param)
        {
            IDALEmpleado _DALEmpleado = new DALEmpleado();
            if (Existe(param.IdEmpleado) == null)
                _DALEmpleado.Insert(param);
            else
                _DALEmpleado.Update(param);
        }


        public Empleado Existe(int pId)
        {
            IDALEmpleado _DALEmpleado = new DALEmpleado();

            return _DALEmpleado.Get(pId);
        }


        public void BorrarEmpleado(int pId)
        {
            IDALEmpleado _DALEmpleado = new DALEmpleado();
            _DALEmpleado.Delete(pId);
        }

        public List<Empleado> GetAll()
        {
            IDALEmpleado _DALEmpleado = new DALEmpleado();
            return _DALEmpleado.GetAll();
        }

        public Empleado Get(int pId)
        {
            IDALEmpleado _DALEmpleado = new DALEmpleado();
            return _DALEmpleado.Get(pId);
        }


    }
}
