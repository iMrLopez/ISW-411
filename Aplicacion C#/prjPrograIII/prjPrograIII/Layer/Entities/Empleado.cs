using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPrograIII.Layer.Entities
{
    class Empleado
    {
        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidosEmpleado { get; set; }
        public string TelefonoEmpleado { get; set; }
        public string CorreoEmpleado { get; set; }
        public string DireccionEmpleado { get; set; }
        public byte[] FotografiaEmpleado { get; set; }
        public TipoEmpleado Tipo { get; set; }




    }
}
