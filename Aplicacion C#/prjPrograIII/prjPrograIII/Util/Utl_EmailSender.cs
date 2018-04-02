using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace prjPrograIII.Util
{
    class Utl_EmailSender
    {
 
        public static void SendEmail(String destinatario)
        {
            MailMessage mensaje = new MailMessage();
            mensaje.IsBodyHtml = true;
            mensaje.Subject = "Comprobante de compra de entradas";
            mensaje.Body = "Adjunto puede encontrar el comprobante de compra para las entradas";
            mensaje.From = new MailAddress("noreply@eticket.com");
            mensaje.To.Add(destinatario);
            SmtpClient smtp = new SmtpClient("smtp.mlopezitsolutions.com");
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("correotemporal@mlopezitsolutions.com", "Correotemporal6");
            smtp.EnableSsl = true;
            Attachment attachment = new Attachment(@"C:\DetalleVenta.pdf");
            mensaje.Attachments.Add(attachment);

            // CODE NOT TO BE USED ON PRODUCTION!!! DISABLES SECURITY TO ALLOW MESSAGE TO BE SENT!!
            ServicePointManager.ServerCertificateValidationCallback =
    delegate (object s, X509Certificate certificate,
             X509Chain chain, SslPolicyErrors sslPolicyErrors)
    { return true; };

            smtp.Send(mensaje);

            MessageBox.Show("Correo Enviado");

        }


    }
}
