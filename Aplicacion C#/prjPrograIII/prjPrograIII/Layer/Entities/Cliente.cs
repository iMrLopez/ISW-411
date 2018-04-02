using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPrograIII.Layer.Entities
{
    class Cliente
    {
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FNacimCliente { get; set; }
        public Sexo SexoCliente { get; set; }
        public string CorreoCliente { get; set; }
        public Nacionalidad NacionalidadCliente { get; set; }


    }
}
