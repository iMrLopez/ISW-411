using Interfaces;
using prjPrograIII.Layer.Business_Logic;
using prjPrograIII.Layer.Entities;
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
    public partial class frmEvento : Form
    {
        public frmEvento()
        {
            InitializeComponent();
            this.CambiarEstado(EstadoMatenimiento.Agregar);
            this.RefreshGrid();
            this.LoadEventPlaces();
            this.LoadEventTypes();
            this.LoadEventStatus();
        }

        /// <summary>
        /// This function backs to main menu
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

        private void lbl_Correo_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Action executed when the user wants to add an event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                this.CambiarEstado(EstadoMatenimiento.Agregar);
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
        /// Action executed when the user wants to modify an event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Mod_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.dgv_Datos.SelectedRows.Count > 0)
                {

                    this.CambiarEstado(EstadoMatenimiento.Modificar);

                    Evento obj1 = this.dgv_Datos.SelectedRows[0].DataBoundItem as Evento;

                    this.txb_IdEvento.Text = obj1.IdEvento.ToString();
                    this.txb_Descripcion.Text = obj1.DescripcionEvento;
                    this.txb_CantEntradas.Text = obj1.CantEntradasEvento.ToString();
                    this.cbo_Estado.SelectedIndex = obj1.EstadoEvento;
                    this.cbo_LugarEvento.SelectedItem = obj1.LugarEvento;
                    this.cbo_TipoEvento.SelectedItem = obj1.TipoEvento;
                    this.txb_CostoPalcos.Text = obj1.CostoPalco.ToString();
                    this.txb_CostoPlata.Text = obj1.CostoPlata.ToString();
                    this.txb_CostoVIP.Text = obj1.CostoVIP.ToString();
                    this.txtb_QtyPalcos.Text = obj1.EntradasPalco.ToString();
                    this.txtb_QtyPlatas.Text = obj1.EntradasPlata.ToString();
                    this.txtb_QtyVIP.Text = obj1.EntradasVIP.ToString();


                    //Extract image to put on picturebox
                    Bitmap image;
                    using (MemoryStream stream = new MemoryStream(obj1.LogoEvento))
                    {
                        image = new Bitmap(stream);
                    }
                    this.ptb_Fotografia.Image = image;
                    this.ptb_Fotografia.Tag = obj1.LogoEvento;
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
        /// Action executed when the user wants to delete data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                this.CambiarEstado(EstadoMatenimiento.Eliminar);

                IBLLEvento _BLLEvento = new BLLEvento();
                
                if (this.dgv_Datos.SelectedRows.Count > 0)
                {
                    Evento objToDelete = this.dgv_Datos.SelectedRows[0].DataBoundItem as Evento;
                    if (MessageBox.Show("¿Seguro que desea borrar el Evento " + objToDelete.DescripcionEvento + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _BLLEvento.Borrar(objToDelete.IdEvento);
                        this.RefreshGrid();
                    }
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
        /// Action executed when the user wants to change the photo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptb_Fotografia_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opt = new OpenFileDialog();
                opt.Title = "Seleccione la Imagen ";
                opt.SupportMultiDottedExtensions = true;
                opt.DefaultExt = "*.jpg";
                opt.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";
                opt.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                opt.FileName = "";

                if (opt.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        //ruta = opt.FileName.Trim();
                        ptb_Fotografia.ImageLocation = opt.FileName;
                        ptb_Fotografia.SizeMode = PictureBoxSizeMode.StretchImage;

                        byte[] cadenaBytes = File.ReadAllBytes(opt.FileName);

                        // Convertir la imagen a bytes !
                        //MemoryStream ms = new MemoryStream();
                        //Bitmap b = new Bitmap(this.pbFotografia.Image);
                        //b.Save(ms, ImageFormat.Jpeg);
                        ptb_Fotografia.Tag = (byte[])cadenaBytes;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:  " + ex.Message);
                    }

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
        /// Action executed when the user wants to process the changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Process_Click(object sender, EventArgs e)
        {
            if (this.ValidateFields())
            {
                try
                {
                    IBLLEvento _IBLLEvento = new BLLEvento();

                    Evento objToReturn = new Evento()
                    {

                        IdEvento = int.Parse(this.txb_IdEvento.Text),
                        DescripcionEvento = this.txb_Descripcion.Text,
                        CantEntradasEvento = int.Parse(this.txb_CantEntradas.Text),
                        CostoPalco = int.Parse(this.txb_CostoPalcos.Text),
                        CostoPlata = int.Parse(this.txb_CostoPlata.Text),
                        CostoVIP = int.Parse(this.txb_CostoVIP.Text),
                        LogoEvento = (byte[])this.ptb_Fotografia.Tag,
                        EstadoEvento = this.cbo_Estado.SelectedIndex,
                        LugarEvento = (Localidad)this.cbo_LugarEvento.SelectedItem,
                        TipoEvento = (TipoEvento)this.cbo_TipoEvento.SelectedItem,
                        EntradasPalco = int.Parse(this.txtb_QtyPalcos.Text),
                        EntradasPlata = int.Parse(this.txtb_QtyPlatas.Text),
                        EntradasVIP = int.Parse(this.txtb_QtyVIP.Text),
                    };


                    //Set the event date
                    DateTime dt = this.dtp_FechaEvento.Value.Date;
                    objToReturn.FechaEvento = dt;


                    _IBLLEvento.Insert(objToReturn);

                    this.RefreshGrid();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nMessage ---\n{0}", ex.Message);
                    Console.WriteLine(
                        "\nHelpLink ---\n{0}", ex.HelpLink);
                    Console.WriteLine("\nSource ---\n{0}", ex.Source);
                    Console.WriteLine(
                        "\nStackTrace ---\n{0}", ex.StackTrace);
                    Console.WriteLine(
                        "\nTargetSite ---\n{0}", ex.TargetSite);
                }
            }
        }

        /// <summary>
        /// Changes the status of the form
        /// </summary>
        /// <param name="estado"></param>
        private void CambiarEstado(EstadoMatenimiento estado)
        {
            //Reset the form
            this.txb_IdEvento.Clear();
            this.txb_Descripcion.Clear();
            //Fill event types
            //Fill event status
            //Fill lugar events
            this.txb_CantEntradas.Clear();
            this.txb_CostoPalcos.Clear();
            this.txb_CostoPlata.Clear();
            this.txb_CostoVIP.Clear();
            this.txtb_QtyVIP.Clear();
            this.txtb_QtyPalcos.Clear();
            this.txtb_QtyPlatas.Clear();
            this.ptb_Fotografia.Image = Properties.Resources.Default_Person;

            //Convert the image to byte[] and save it to the tag
            ImageConverter converter = new ImageConverter();
            this.ptb_Fotografia.Tag = (byte[])converter.ConvertTo(Properties.Resources.Default_Person, typeof(byte[]));

            switch (estado)
            {
                case EstadoMatenimiento.Agregar:
                    this.txb_IdEvento.Enabled = true;
                    this.txb_CantEntradas.Enabled = true;
                    this.txb_CostoPalcos.Enabled = false;
                    this.txb_CostoPlata.Enabled = false;
                    this.txb_CostoVIP.Enabled = false;
                    this.txtb_QtyVIP.Enabled = false;
                    this.txtb_QtyPalcos.Enabled = false;
                    this.txtb_QtyPlatas.Enabled = false;
                    this.ptb_Fotografia.Enabled = true;
                    txb_Descripcion.Focus();
                    break;
                case EstadoMatenimiento.Modificar:
                    this.txb_IdEvento.Enabled = false;
                    this.txb_CantEntradas.Enabled = true;
                    this.txb_CostoPalcos.Enabled = true;
                    this.txb_CostoPlata.Enabled = true;
                    this.txb_CostoVIP.Enabled = true;
                    this.txtb_QtyVIP.Enabled = true;
                    this.txtb_QtyPalcos.Enabled = true;
                    this.txtb_QtyPlatas.Enabled = true;
                    this.ptb_Fotografia.Enabled = true;
                    txb_Descripcion.Focus();
                    this.UpdateCostsQty();
                    break;
                case EstadoMatenimiento.Eliminar:
                    break;
                default:

                    break;
            }
        }

        /// <summary>
        /// Refresh the data grid on the client side
        /// </summary>
        private void RefreshGrid()
        {
            IBLLEvento _BLLEvento = new BLLEvento();
            dgv_Datos.AutoGenerateColumns = true;
            dgv_Datos.RowTemplate.Height = 100;
            this.dgv_Datos.DataSource = _BLLEvento.GetAll();
            this.CambiarEstado(EstadoMatenimiento.Agregar);
        }

        /// <summary>
        /// Load all the event types on the designated CBO
        /// </summary>
        private void LoadEventTypes()
        {
            IBLLTipoEvento _BLLTipoEvento = new BLLTipoEvento();
            this.cbo_TipoEvento.DataSource = _BLLTipoEvento.GetAll();
        }

        /// <summary>
        /// Fill all the localities for the events
        /// </summary>
        private void LoadEventPlaces() {
            IBLLLocalidad _BLLLocalidad = new BLLLocalidad();
            this.cbo_LugarEvento.DataSource = _BLLLocalidad.GetAll();
        }

        /// <summary>
        /// Load the status of the events
        /// </summary>
        private void LoadEventStatus() {
            this.cbo_Estado.DataSource = Enum.GetNames(typeof(EstadoEvento));

        }


        /// <summary>
        /// Unables and disables costs and qtyes based on the location of the event
        /// </summary>
        private void UpdateCostsQty()
        {
         }


        /// <summary>
        /// Action executed when the Selection has been commited on the field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_LugarEvento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Localidad obj1 = this.cbo_LugarEvento.SelectedItem as Localidad;
            //Update the fields for the costs and quantities
            if (!obj1.EspaciosPalco.Equals(0))
            {
                this.txb_CostoPalcos.Enabled = true;
                this.txtb_QtyPalcos.Enabled = true;
            }
            else
            {
                this.txb_CostoPalcos.Text = "0";
                this.txtb_QtyPalcos.Text = "0";

            }

            if (!obj1.EspaciosPlata.Equals(0))
            {
                this.txb_CostoPlata.Enabled = true;
                this.txtb_QtyPlatas.Enabled = true;
            }
            else
            {
                this.txb_CostoPlata.Text = "0";
                this.txtb_QtyPlatas.Text = "0";

            }

            if (!obj1.EspaciosVIP.Equals(0))
            {
                this.txb_CostoVIP.Enabled = true;
                this.txtb_QtyVIP.Enabled = true;
            }
            else
            {
                this.txb_CostoVIP.Text = "0";
                this.txtb_QtyVIP.Text = "0";

            }
        }

        /// <summary>
        /// Validates the fields on the form
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {

            if (this.txb_IdEvento.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txb_IdEvento, "Please enter an ID");
                return false;
            }
            else
            {
                try { int.Parse(this.txb_IdEvento.Text); }
                catch (Exception)
                {
                    this.errPrvder1.SetError(this.txb_IdEvento, "Please enter a numeric ID");
                    return false;
                }
            }
            if (this.txb_Descripcion.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txb_Descripcion, "Please enter a name");
                return false;
            }
            if (this.txb_CantEntradas.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txb_CantEntradas, "Please enter a numeric value");
                return false;
            }
            else
            {
                try { int.Parse(this.txb_CantEntradas.Text); }
                catch (Exception)
                {
                    this.errPrvder1.SetError(this.txb_CantEntradas, "Please enter a numeric value");
                    return false;
                }
            }
            if (this.txb_CostoPalcos.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txb_CostoPalcos, "Please enter a numeric value");
                return false;
            }
            else
            {
                try { int.Parse(this.txb_CostoPalcos.Text); }
                catch (Exception)
                {
                    this.errPrvder1.SetError(this.txb_CostoPalcos, "Please enter a numeric value");
                    return false;
                }
            }
            if (this.txb_CostoPlata.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txb_CostoPlata, "Please enter a numeric value");
                return false;
            }
            else
            {
                try { int.Parse(this.txb_CostoPlata.Text); }
                catch (Exception)
                {
                    this.errPrvder1.SetError(this.txb_CostoPlata, "Please enter a numeric value");
                    return false;
                }
            }
            if (this.txb_CostoVIP.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txb_CostoVIP, "Please enter a numeric value");
                return false;
            }
            else
            {
                try { int.Parse(this.txb_CostoVIP.Text); }
                catch (Exception)
                {
                    this.errPrvder1.SetError(this.txb_CostoVIP, "Please enter a numeric value");
                    return false;
                }
            }
            if (this.txtb_QtyPalcos.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txtb_QtyPalcos, "Please enter a numeric value");
                return false;
            }
            else
            {
                try { int.Parse(this.txtb_QtyPalcos.Text); }
                catch (Exception)
                {
                    this.errPrvder1.SetError(this.txtb_QtyPalcos, "Please enter a numeric value");
                    return false;
                }
            }
            if (this.txtb_QtyPlatas.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txtb_QtyPlatas, "Please enter a numeric value");
                return false;
            }
            else
            {
                try { int.Parse(this.txtb_QtyPlatas.Text); }
                catch (Exception)
                {
                    this.errPrvder1.SetError(this.txtb_QtyPlatas, "Please enter a numeric value");
                    return false;
                }
            }
            if (this.txtb_QtyVIP.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txtb_QtyVIP, "Please enter a numeric value");
                return false;
            }
            else
            {
                try { int.Parse(this.txtb_QtyVIP.Text); }
                catch (Exception)
                {
                    this.errPrvder1.SetError(this.txtb_QtyVIP, "Please enter a numeric value");
                    return false;
                }
            }
            return true;
        }

        private void cbo_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
