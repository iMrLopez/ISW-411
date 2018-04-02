using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPrograIII.Layer.Entities
{
    class Tarjeta
    {

        public TipoTarjeta Tipo { get; set; }
        public string NumeroTarjeta { get; set; }
        public int NumeroVerificacion { get; set; }
        public DateTime FechaTarjeta { get; set; }

    }
}
