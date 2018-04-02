using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPrograIII.Layer.Entities
{
    class Localidad
    {
        public int IdLugar { get; set; }
        public string NombreLugar { get; set; }
        public int CapacidadLugar { get; set; }
        public byte[] MapaLugar { get; set; }
        public int EspaciosPalco { get; set; }
        public int EspaciosVIP { get; set; }
        public int EspaciosPlata { get; set; }

        public override string ToString()
        {
            return NombreLugar;
        }
    }
}
