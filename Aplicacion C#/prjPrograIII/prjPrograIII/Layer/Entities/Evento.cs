using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPrograIII.Layer.Entities
{
    class Evento
    {
        public int IdEvento { get; set; }
        public TipoEvento TipoEvento { get; set; }
        public string DescripcionEvento { get; set; }
        public byte[] LogoEvento { get; set; }
        public DateTime FechaEvento { get; set; }
        public int EstadoEvento { get; set; }
        public int CantEntradasEvento { get; set; }
        public Localidad LugarEvento { get; set; }
        public int CostoPlata { get; set; }
        public int CostoPalco { get; set; }
        public int CostoVIP { get; set; }
        public int EntradasPlata { get; set; }
        public int EntradasPalco { get; set; }
        public int EntradasVIP { get; set; }



    }
}
