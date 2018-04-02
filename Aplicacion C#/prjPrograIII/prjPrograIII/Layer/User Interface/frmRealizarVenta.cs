using Interfaces;
using prjPrograIII.Layer.Business_Logic;
using prjPrograIII.Layer.DAL;
using prjPrograIII.Layer.Entities;
using prjPrograIII.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPrograIII
{
    public partial class frmRealizarVenta : Form
    {
        private Evento SelEvt; //Selected event

        private VentaCabecera ActualSell; //Actual selling
        public frmRealizarVenta()
        {
            InitializeComponent();
            this.PutTodayDate(); //Setup todays date
            this.LoadActiveEventsOnGrid(); //Setup available events

        }

        /// <summary>
        /// This function closes the application when the user clicks the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //Back to main menu
            frmMainMenu temp = new frmMainMenu();
            temp.Show();
            this.Close();
        }

        /// <summary>
        /// Load the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRealizarVenta_Load(object sender, EventArgs e)
        {
            this.SelEvt = null; //null to selected event
            this.ActualSell = null; //null to actual sell
        }

        /// <summary>
        /// Put todays Date & Time on the dtp
        /// </summary>
        private void PutTodayDate() {
            this.dtp_FechaActual.Value = DateTime.Now;
        }

        /// <summary>
        /// Get all the active events
        /// </summary>
        private void LoadActiveEventsOnGrid() {


            //Set the event date
            DateTime dt = this.dtp_FechaActual.Value.Date;

            IBLLEvento _BLLEvento = new BLLEvento();
            dgv_Datos.AutoGenerateColumns = true;
            dgv_Datos.RowTemplate.Height = 100;
            this.dgv_Datos.DataSource = _BLLEvento.GetActiveEvents(dt);
            //this.CambiarEstado(EstadoMatenimiento.Agregar);
        }

        /// <summary>
        /// Prepare Step1 controls
        /// </summary>
        private void PrepareStep1() {

            //Operation Variables
            Bitmap image;


            //Extract Event image to put on picturebox
            using (MemoryStream stream = new MemoryStream(this.SelEvt.LogoEvento))
            {
                image = new Bitmap(stream);
            }
            this.ptb_EventImage.Image = image;

            //Extract Location image to put on picturebox
            using (MemoryStream stream = new MemoryStream(this.SelEvt.LugarEvento.MapaLugar))
            {
                image = new Bitmap(stream);
            }
            this.ptb_LocationImage.Image = image;

            //Prices
            this.txtb_Palcos.Text = this.SelEvt.CostoPalco.ToString();
            this.txtb_Plata.Text = this.SelEvt.CostoPlata.ToString();
            this.txtb_VIP.Text = this.SelEvt.CostoVIP.ToString();

            //Prepare cbos (unable/disable)
            if (this.SelEvt.CostoPalco == 0)
                this.cbo_Palcos.Enabled=false;

            if (this.SelEvt.CostoPlata == 0)
                this.cbo_Plata.Enabled = false;

            if (this.SelEvt.CostoVIP == 0)
                this.cbo_VIP.Enabled = false;
            //Prepare cbos (fill with qty entries)
            for (int i=0; i<=100; i++)
            {
                this.cbo_Palcos.Items.Add(i);
                this.cbo_Plata.Items.Add(i);
                this.cbo_VIP.Items.Add(i);
            }
            //Prepare cbos (set value to 0)
            this.cbo_Palcos.SelectedIndex = 0;
            this.cbo_Plata.SelectedIndex = 0;
            this.cbo_VIP.SelectedIndex = 0;

            //Put the total on 0
            this.txtb_Total.Text = "0";

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Step 0 process button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Step0_Process_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.dgv_Datos.SelectedRows.Count > 0)
                {
                    //Extract the selected object on the instance & prepare controls for next step
                    this.SelEvt = this.dgv_Datos.SelectedRows[0].DataBoundItem as Evento;
                    this.PrepareStep00();//Prepare controls for step00
                    this.tbc_SellSteps.Controls.Remove(this.tb_Principal); //Delete this tab
                    this.tbc_SellSteps.SelectedTab = this.tb_Paso00; //Select Step00
                }
                else
                {
                    MessageBox.Show("Seleccione el registro !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Step 1 Process Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Step1_Process_Click(object sender, EventArgs e)
        {
            //Validate if entries have been selected
            if (this.ValidateStep2())
            {

                try
                {

                   //Prepare detail to add
                    VentaDetalle DetalleDeCompra = new VentaDetalle()
                    {
                        EventoComprado = this.SelEvt,
                        EntradasPalco = this.cbo_Palcos.SelectedIndex,
                        EntradasVIP = this.cbo_VIP.SelectedIndex,
                        EntradasPlata = this.cbo_Plata.SelectedIndex,
                        TotalDetalle = int.Parse(this.txtb_Total.Text)
                    };

                    //Add detail to Sell & update the total
                    if (this.ActualSell.DetalleEventosComprados == null) {
                        this.ActualSell.DetalleEventosComprados = new List<VentaDetalle> { };

                    }
                    this.ActualSell.DetalleEventosComprados.Add(DetalleDeCompra);
                    this.ActualSell.TotalVenta = this.ActualSell.TotalVenta + DetalleDeCompra.TotalDetalle;

                    //Select the next step
                    this.tbc_SellSteps.Controls.Remove(this.tb_Paso1); //Delete actual tab
                    this.tbc_SellSteps.SelectedTab = this.tb_Paso3; //Select next step
                    this.PrepareStep03(); //Prepare next step

                }
                catch (Exception er)
                {

                    StringBuilder msg = new StringBuilder();
                    msg.AppendFormat("Message        {0}\n", er.Message);
                    msg.AppendFormat("Source         {0}\n", er.Source);
                    msg.AppendFormat("InnerException {0}\n", er.InnerException);
                    msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                    msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);

                    MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }
        }

        /// <summary>
        /// Used to validate the selected fields on the sell
        /// </summary>
        /// <returns></returns>
        private bool ValidateStep2() {

            //If the client is trying to buy more tickets than authorized
            if (((this.cbo_Palcos.SelectedIndex + this.cbo_Plata.SelectedIndex + this.cbo_VIP.SelectedIndex) > this.SelEvt.CantEntradasEvento))
            {
                this.errPrvder1.SetError(this.cbo_Palcos, "The total qty of tickets cannot be greater than: "+this.SelEvt.CantEntradasEvento);
                this.errPrvder1.SetError(this.cbo_VIP, "The total qty of tickets cannot be greater than: " + this.SelEvt.CantEntradasEvento);
                this.errPrvder1.SetError(this.cbo_Plata, "The total qty of tickets cannot be greater than: " + this.SelEvt.CantEntradasEvento);
                return false;
            }


            //If the total is equal to zero the client has not selected any ticket to buy
            if (this.txtb_Total.Text == "0")
            {
                this.errPrvder1.SetError(this.cbo_Palcos, "You need to select a qty of tickets to proceed");
                this.errPrvder1.SetError(this.cbo_VIP, "You need to select a qty of tickets to proceed");
                this.errPrvder1.SetError(this.cbo_Plata, "You need to select a qty of tickets to proceed");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Used to calculate the total on the field
        /// </summary>
        private void CalculateTotalOnField()
        {
            int retrn = 0;
            //Calculate the new grand total
            retrn += this.cbo_Palcos.SelectedIndex * this.SelEvt.CostoPalco;
            retrn += this.cbo_Plata.SelectedIndex * this.SelEvt.CostoPlata;
            retrn += this.cbo_VIP.SelectedIndex * this.SelEvt.CostoVIP;
            this.txtb_Total.Text = retrn.ToString();

        }

        /// <summary>
        /// Happens when Palcos qty is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_Palcos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.CalculateTotalOnField();
        }
        /// <summary>
        /// Happens when Plata qty is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_Plata_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.CalculateTotalOnField();

        }
        /// <summary>
        /// Happens when VIP qty is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_VIP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.CalculateTotalOnField();
        }

        /// <summary>
        /// uncheck name check box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkb_Identif_CheckedChanged(object sender, EventArgs e)
        {
            this.chk_Nombre.Checked = false;
        }

        /// <summary>
        /// Uncheck Identf check box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_Nombre_CheckedChanged(object sender, EventArgs e)
        {
            this.chkb_Identif.Checked = false;
        }

        /// <summary>
        /// Perform a search on the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Search_Click(object sender, EventArgs e)
        {
            //See what method use to look for client
            IDALCliente _Buscador = new DALCliente();
            dgv_Datos.AutoGenerateColumns = true;
            dgv_Datos.RowTemplate.Height = 100;

            if (this.chkb_Identif.Checked)
            {
                try
                {
                    List<Cliente> temporal = new List<Cliente> { _Buscador.Get(int.Parse(this.txb_Identificacion.Text)) };
                    this.dgv_DatosCliente.DataSource = temporal ;
                }
                catch (Exception)
                {
                    this.errPrvder1.SetError(this.txb_Identificacion, "You should write a number!");
                }
            }
            else if (this.chk_Nombre.Checked)
            {
                try
                {
                    this.dgv_DatosCliente.DataSource = _Buscador.GetByName(this.txtb_Nombre.Text);
                    this.errPrvder1.SetError(this.txtb_Nombre, "You should write a name or client not found");

                }
                catch (Exception)
                {
                }
            }
            else
            {
                this.errPrvder1.SetError(this.chk_Nombre, "You should select an option!");
                this.errPrvder1.SetError(this.chkb_Identif, "You should select an option!");
            }
        }

        /// <summary>
        /// Process the selection of the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Step00_Process_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.dgv_DatosCliente.SelectedRows.Count > 0)
                {
                    //If necessary create a new instance of the sell
                    if (this.ActualSell == null)
                    {
                        this.ActualSell = new VentaCabecera();
                        this.ActualSell.FechaActual = this.dtp_FechaActual.Value;
                    }
                    this.ActualSell.ClienteComprador = this.dgv_DatosCliente.SelectedRows[0].DataBoundItem as Cliente; //Select the client and save it on the instance
                    this.tbc_SellSteps.Controls.Remove(this.tb_Paso00); //Delete this tab
                    this.tbc_SellSteps.SelectedTab = this.tb_Paso1; //Select Step1 
                    this.PrepareStep1(); //Prepare Step1 controls
                }
                else
                {
                    MessageBox.Show("Seleccione el cliente !", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception er)
            {

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);

                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        /// <summary>
        /// Prepare the controls for the step00
        /// </summary>
        private void PrepareStep00() {
            this.chkb_Identif.Checked = false;
            this.chk_Nombre.Checked = false;
            this.txtb_Nombre.Text = "";
            this.txb_Identificacion.Text = "";
            this.dgv_DatosCliente.Rows.Clear();

        }
        
        /// <summary>
        /// Prepare the step 3
        /// </summary>
        private void PrepareStep03()
        {
            this.cbo_TiposTarjetas.DataSource = Enum.GetNames(typeof(TipoTarjeta)); //Load types of cards
            this.rct_Descripcion.Text = this.ActualSell.PrevioVenta(); //Load the data to be paid
            this.cbo_TiposTarjetas.SelectedIndex = 0;
        }

        /// <summary>
        /// Instantiate the card number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Step3_Process_Click(object sender, EventArgs e)
        {

            if (this.ValidateCardNumber()) {
                Tarjeta temporal = new Tarjeta()
                {
                    NumeroTarjeta = this.txtb_NumeroTarjeta.Text,
                    NumeroVerificacion = int.Parse(this.txtb_NumeroVerificacion.Text),
                    FechaTarjeta = this.dtp_FechaVencimiento.Value,
            };
               // Tipo = (TipoTarjeta)Enum.Parse(typeof(TipoTarjeta), cbo_TiposTarjetas.SelectedText)

                this.ActualSell.ModoPago = temporal; //Save card
                this.CommitTransaction(); //Commit transaction on database
                this.CreateInvoice(); //Create the invoice
                this.PrepareStep005(); //Prepare step5

                //Delete this tab and show next
                this.tbc_SellSteps.Controls.Remove(this.tb_Paso3); //Delete this tab
                this.tbc_SellSteps.SelectedTab = this.tb_Paso5; //Select Step1 

            }
            else
            {
                MessageBox.Show("Verifique el numero de su tarjeta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Validate with Luhn algorythm the number of card
        /// </summary>
        /// <returns></returns>
        private bool ValidateCardNumber()
        {
            try
            {
                Convert.ToInt64(this.txtb_NumeroTarjeta.Text);
                int.Parse(this.txtb_NumeroVerificacion.Text); 
                if(this.txtb_NumeroVerificacion.Text.Length != 3)
                {
                    throw new Exception("No 3 digits on verification"); ;
                }
                return Utl_CardVerifier.LuhnCheck(this.txtb_NumeroTarjeta.Text);
            }
            catch (Exception)
            {
                this.errPrvder1.SetError(this.txtb_NumeroTarjeta, "Please digit the correct number");
                this.errPrvder1.SetError(this.txtb_NumeroVerificacion, "Please digit the 3 digit number on the back of the card");

                return false;
            }
        }

        /// <summary>
        /// Button to process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Sign_Click(object sender, EventArgs e)
        {
            this.pnl_Firma.Visible = true; //Enable signature panel
            this.btn_Step3_Process.Enabled = true; //Enable the processing button


            Utl_SignatureDrawer f = new Util.Utl_SignatureDrawer();
            var dialogResult = f.ShowDialog();

            try
            {
                if (dialogResult == DialogResult.OK)
                {
                    ptb_Signature.Image = f.signature;
                    ImageConverter _ImageConverter = new ImageConverter();
                    this.ActualSell.FirmaCompra = (byte[])_ImageConverter.ConvertTo(this.ptb_Signature.Image, typeof(byte[]));

                }
            }
            catch (Exception) { }


        }

        /// <summary>
        /// Prepare the step 5 of the form
        /// </summary>
        private void PrepareStep005()
        {
            this.LoadPdfInvoice();
        }

        /// <summary>
        /// commits the transaction on the database
        /// </summary>
        private void CommitTransaction()
        {
            //First update the new data for the recently selled event(s)
            IBLLEvento EventUpdter = new BLLEvento();
            foreach (VentaDetalle item in this.ActualSell.DetalleEventosComprados)
            {
                item.EventoComprado.EntradasPalco = item.EventoComprado.EntradasPalco - item.EntradasPalco; //New value for qty of avail palco tickets
                item.EventoComprado.EntradasPlata = item.EventoComprado.EntradasPlata - item.EntradasPlata; //New value for qty of avail Plata tickets
                item.EventoComprado.EntradasVIP = item.EventoComprado.EntradasVIP - item.EntradasVIP; //New value for qty of avail VIP tickets
                EventUpdter.Update(item.EventoComprado); //Update the event on the db
            }
            //Commit Header to table
            IBLLVentaCabecera _VentaCabecera = new BLLVentaCabecera();
            int IdVenta = _VentaCabecera.Insert(this.ActualSell);
            this.ActualSell.IdVenta = IdVenta;

            //Commit detail(s) to table
            IBLLVentaDetalle _VentaDetalle = new BLLVentaDetalle();

            foreach (VentaDetalle item in this.ActualSell.DetalleEventosComprados)
            {
                _VentaDetalle.Insert(item, IdVenta);

            }
        }

        /// <summary>
        /// Creates the invoice for this transaction on C:
        /// </summary>
        private void CreateInvoice()
        {
            int nivel = 0; // depende del máximo de caracteres permitidos
            nivel = 0;   // Existen los niveles  17,32,53,78,108,134,154, 192,230,271,321,367,425,458,520,586,644,718, 792, 858
            Utl_PdfGenerator.GenerateInvoice(this.ActualSell, Utl_QrGenerator.QuickResponseGenerador(this.ActualSell.ParaQR(),nivel));
        }

        /// <summary>
        /// Loads the pdf invoice on the control
        /// </summary>
        private void LoadPdfInvoice()
        {
            this.pdf_Invoice.src = @"C:\DetalleVenta.pdf";
        }

        /// <summary>
        /// Send the email to the client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SendEmail_Click(object sender, EventArgs e)
        {
            Utl_EmailSender.SendEmail(this.ActualSell.ClienteComprador.CorreoCliente);
        }

        /// <summary>
        /// Copy the file to the selected directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveFactura_Click(object sender, EventArgs e)
        {
            string fileToCopy = @"c:\DetalleVenta.pdf"; // file to copy
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = fileToCopy;
            //sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.Copy(fileToCopy, sfd.FileName, true);
            }
        }
    }
}
