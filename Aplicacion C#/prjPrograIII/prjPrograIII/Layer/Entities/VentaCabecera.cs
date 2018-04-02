using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPrograIII.Layer.Entities
{
    class VentaCabecera
    {
        public int IdVenta { get; set; }
        public Cliente ClienteComprador { get; set; }
        public List<VentaDetalle> DetalleEventosComprados { get; set; }
        public DateTime FechaActual { get; set; }
        public int TotalVenta { get; set; }
        public Tarjeta ModoPago { get; set; }

        public byte[] FirmaCompra { get; set; }


        /// <summary>
        /// Prepares a string to be shown to client on screen
        /// </summary>
        /// <returns></returns>
        public string PrevioVenta()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine("IdVenta: " + IdVenta);
            retorno.AppendLine("Cliente: " + ClienteComprador.NombreCliente);

            foreach (VentaDetalle item in DetalleEventosComprados)
            {
                retorno.AppendLine("Evento: " + item.EventoComprado.DescripcionEvento);
                retorno.AppendLine("Entradas Palco: " + item.EntradasPalco);
                retorno.AppendLine("Entradas Plata:  " + item.EntradasPlata);
                retorno.AppendLine("Entradas vIP: : " + item.EntradasVIP);

            }
            retorno.AppendLine("Total de venta: " + TotalVenta);
            retorno.AppendLine("Fecha venta: " + FechaActual.Date);
            //retorno.AppendLine("IdVenta: " + IdVenta);


            return retorno.ToString();
        }

        /// <summary>
        /// Retorno para generar QR
        /// </summary>
        /// <returns></returns>
        public string ParaQR()
        {
            string retorno;

            retorno = "Cliente:" + ClienteComprador.NombreCliente;

            foreach (VentaDetalle item in DetalleEventosComprados)
            {
                retorno += "Evento: " + item.EventoComprado.DescripcionEvento;
                 retorno += ("Entradas Palco: " + item.EntradasPalco);
                retorno += ("Entradas Plata:  " + item.EntradasPlata);
                retorno += ("Entradas vIP: : " + item.EntradasVIP);

            }
            retorno += ("Total de venta: " + TotalVenta);
            retorno += ("Fecha venta: " + FechaActual.Date);
            return retorno;
        }





    }
}
