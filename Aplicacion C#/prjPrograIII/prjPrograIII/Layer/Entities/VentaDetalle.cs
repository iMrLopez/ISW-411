using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPrograIII.Layer.Entities
{
    class VentaDetalle
    {
        public Evento EventoComprado { get; set; }
        public int EntradasPalco { get; set; }
        public int EntradasPlata { get; set; }
        public int EntradasVIP { get; set; }
        public int TotalDetalle { get; set; }

    }
}
