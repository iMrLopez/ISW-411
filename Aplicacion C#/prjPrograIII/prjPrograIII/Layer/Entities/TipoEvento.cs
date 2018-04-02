using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPrograIII.Layer.Entities
{
    class TipoEvento
    {
        public int IdTipoEvento { get; set; }
        public string DescripcionTipoEvento { get; set; }


        public override string ToString()
        {
            return DescripcionTipoEvento;
        }
    }
}
