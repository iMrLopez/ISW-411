using iTextSharp.text;
using iTextSharp.text.pdf;
using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPrograIII.Util
{
    static class Utl_PdfGenerator
    {

        /// <summary>
        /// This generates the invoice on C:\temp.pdf to be used by the program
        /// </summary>
        /// <param name="p1">The header for the sell</param>
        /// <param name="p2">The QR code to be added</param>
        /// <returns></returns>
        public static bool GenerateInvoice(VentaCabecera p1, System.Drawing.Image p2)
        {
            //Working variables
            string pdfpath = @"C:/";
            Document doc = new Document();
            try

            {

                PdfWriter.GetInstance(doc, new FileStream(pdfpath + "DetalleVenta.pdf", FileMode.Create)); //Creates the pdf file
                doc.Open(); //Opens the pdf file
                doc.Add(new Paragraph(p1.PrevioVenta())); //Adds the tostring of the buy

                doc.Add(new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator()))); //Divisor line


                try
                {
                    Bitmap image;
                    iTextSharp.text.Image ImgEvento;
                    foreach (var item in p1.DetalleEventosComprados) //for all the images
                    {
                        using (MemoryStream stream = new MemoryStream(item.EventoComprado.LogoEvento))
                        {
                             ImgEvento = iTextSharp.text.Image.GetInstance(stream); //Generate the image to add to pdf
                        }
                        doc.Add(new Paragraph("Imagen del evento " + item.EventoComprado.DescripcionEvento + ":")); //Evt image
                        doc.Add(ImgEvento); //Adds the event
                    }

                }catch (Exception) { }
                doc.Add(new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator()))); //Divisor line

                doc.Add(new Paragraph("QR de confirmacion:"));
                iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(p2, System.Drawing.Imaging.ImageFormat.Jpeg); //Parses the QR
                doc.Add(pdfImage); //Adds the qr 



            } catch (Exception ex)
            {
                return false;
            }

            finally
            {
                doc.Close();
            }
            return true;
        }
    }
}
