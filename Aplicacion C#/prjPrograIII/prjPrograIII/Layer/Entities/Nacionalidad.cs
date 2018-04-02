using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPrograIII.Layer.Entities
{
    class Nacionalidad
    {
        public int IdNacionalidad { get; set; }
        public string DescrNacionalidad { get; set; }

        public override string ToString()
        {
            return DescrNacionalidad;
        }
    }
}
