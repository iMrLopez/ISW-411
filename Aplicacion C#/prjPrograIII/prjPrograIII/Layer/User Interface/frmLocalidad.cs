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
    public partial class frmLocalidad : Form
    {
        public frmLocalidad()
        {
            InitializeComponent();
            this.CambiarEstado(EstadoMatenimiento.Agregar);
            this.RefreshGrid();
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



        private void lbl_Title_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Action that happens when you click the add button
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
        /// Saves the employee to the db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                this.CambiarEstado(EstadoMatenimiento.Eliminar);


                //Delete the data 

                IBLLLocalidad _BLLLocalidad = new BLLLocalidad();


                if (this.dgv_Datos.SelectedRows.Count > 0)
                {
                    Localidad objToDelete = this.dgv_Datos.SelectedRows[0].DataBoundItem as Localidad;
                    if (MessageBox.Show("¿Seguro que desea borrar la localidad " + objToDelete.NombreLugar + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _BLLLocalidad.Borrar(objToDelete.IdLugar);
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
        /// Action executed when you click the mod button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Mod_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (this.dgv_Datos.SelectedRows.Count > 0)
                {

                    this.CambiarEstado(EstadoMatenimiento.Modificar);

                    Localidad obj1 = this.dgv_Datos.SelectedRows[0].DataBoundItem as Localidad;

                    this.txtb_Add_Name.Text = obj1.NombreLugar;
                    this.txtb_Add_Identif.Text = obj1.IdLugar.ToString();
                    this.txtb_Add_Capacidad.Text = obj1.CapacidadLugar.ToString();
                    this.txtb_Add_Palco.Text = obj1.EspaciosPalco.ToString();
                    this.txb_Add_Vip.Text = obj1.EspaciosVIP.ToString();
                    this.txtb_Add_Plata.Text = obj1.EspaciosPlata.ToString();

                    //Extract image to put on picturebox
                    Bitmap image;
                    using (MemoryStream stream = new MemoryStream(obj1.MapaLugar))
                    {
                        image = new Bitmap(stream);
                    }
                    this.ptb_Fotografia.Image = image;
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
        /// Changes the status of the form
        /// </summary>
        /// <param name="estado"></param>
        private void CambiarEstado(EstadoMatenimiento estado)
        {
            //Reset the form
            this.txtb_Add_Name.Clear();
            this.txtb_Add_Identif.Clear();
            this.txtb_Add_Capacidad.Clear();
            this.txtb_Add_Palco.Clear();
            this.txb_Add_Vip.Clear();
            this.txtb_Add_Plata.Clear();
            this.ptb_Fotografia.Image = Properties.Resources.Default_Person;

            //Convert the image to byte[]
            ImageConverter converter = new ImageConverter();
            this.ptb_Fotografia.Tag = (byte[])converter.ConvertTo(Properties.Resources.Default_Person, typeof(byte[]));

            switch (estado)
            {
                case EstadoMatenimiento.Agregar:
                    this.txtb_Add_Name.Enabled = true;
                    this.txtb_Add_Identif.Enabled = true;
                    this.txtb_Add_Capacidad.Enabled = true;
                    this.txtb_Add_Palco.Enabled = true;
                    this.txb_Add_Vip.Enabled = true;
                    this.txtb_Add_Plata.Enabled = true;
                    this.btn_Add_Process.Enabled = true;
                    this.ptb_Fotografia.Enabled = true;
                    txtb_Add_Name.Focus();
                    break;
                case EstadoMatenimiento.Modificar:
                    this.txtb_Add_Name.Enabled = true;
                    this.txtb_Add_Identif.Enabled = false;
                    this.txtb_Add_Capacidad.Enabled = true;
                    this.txtb_Add_Palco.Enabled = true;
                    this.txb_Add_Vip.Enabled = true;
                    this.txtb_Add_Plata.Enabled = true;
                    this.btn_Add_Process.Enabled = true;
                    this.ptb_Fotografia.Enabled = true;
                    txtb_Add_Name.Focus();
                    break;
                case EstadoMatenimiento.Eliminar:
                    break;
                default:

                    break;
            }
        }

        /// <summary>
        /// Refreshes the grid on the form
        /// </summary>
        private void RefreshGrid()
        {
            IBLLLocalidad _BLLLocalidad = new BLLLocalidad();
            dgv_Datos.AutoGenerateColumns = true;
            dgv_Datos.RowTemplate.Height = 100;
            this.dgv_Datos.DataSource = _BLLLocalidad.GetAll();
            this.CambiarEstado(EstadoMatenimiento.Agregar);
        }

        /// <summary>
        /// Action happened when you click the process button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Process_Click(object sender, EventArgs e)
        {
            if (this.ValidateFields())
            {
                if (this.ValidateSumOfFields())
                {
                    try
                    {
                        IBLLLocalidad _IBLLLocalidad = new BLLLocalidad();



                        Localidad objToReturn = new Localidad()
                        {

                            IdLugar = int.Parse(this.txtb_Add_Identif.Text),
                            NombreLugar = this.txtb_Add_Name.Text,
                            CapacidadLugar = int.Parse(this.txtb_Add_Capacidad.Text),
                            EspaciosPalco = int.Parse(this.txtb_Add_Palco.Text),
                            EspaciosVIP = int.Parse(this.txb_Add_Vip.Text),
                            EspaciosPlata = int.Parse(this.txtb_Add_Plata.Text),
                            MapaLugar = (byte[])this.ptb_Fotografia.Tag,
                        };


                        _IBLLLocalidad.Insert(objToReturn);

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
        }

        /// <summary>
        /// Action that happens when you click the ptb Fotografia
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
        /// Validates the fields on the form are filled
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            //
            if (this.txtb_Add_Identif.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txtb_Add_Identif, "Please enter an ID");
                return false;
            }
            else
            {
                try { int.Parse(this.txtb_Add_Identif.Text); }
                catch (Exception)
                {
                    this.errPrvder1.SetError(this.txtb_Add_Identif, "Please enter a numeric ID");
                    return false;
                }
            }
            //
            if (this.txtb_Add_Name.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txtb_Add_Name, "Please enter a name");
                return false;
            }
            //
            if (this.txtb_Add_Capacidad.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txtb_Add_Capacidad, "Please enter a numeric value");
                return false;
            }
            else
            {
                try { int.Parse(this.txtb_Add_Capacidad.Text); }
                catch (Exception)
                {
                    this.errPrvder1.SetError(this.txtb_Add_Capacidad, "Please enter a numeric value");
                    return false;
                }
            }
            //
            if (this.txtb_Add_Palco.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txtb_Add_Palco, "Please enter a numeric value");
                return false;
            }
            else
            {
                try { int.Parse(this.txtb_Add_Palco.Text); }
                catch (Exception)
                {
                    this.errPrvder1.SetError(this.txtb_Add_Palco, "Please enter a numeric value");
                    return false;
                }
            }
            //
            if (this.txtb_Add_Plata.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txtb_Add_Plata, "Please enter a numeric value");
                return false;
            }
            else
            {
                try { int.Parse(this.txtb_Add_Plata.Text); }
                catch (Exception)
                {
                    this.errPrvder1.SetError(this.txtb_Add_Plata, "Please enter a numeric value");
                    return false;
                }
            }
            //
            if (this.txb_Add_Vip.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txb_Add_Vip, "Please enter a numeric value");
                return false;
            }
            else
            {
                try { int.Parse(this.txb_Add_Vip.Text); }
                catch (Exception)
                {
                    this.errPrvder1.SetError(this.txb_Add_Vip, "Please enter a numeric value");
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Validates the sum of the fields
        /// </summary>
        /// <returns></returns>
        private bool ValidateSumOfFields()
        {
            if (int.Parse(this.txb_Add_Vip.Text) + int.Parse(this.txtb_Add_Palco.Text) + int.Parse(this.txtb_Add_Plata.Text) < int.Parse(this.txtb_Add_Capacidad.Text))
            {
                this.errPrvder1.SetError(this.pnl_Sum, "The sum of these values should be more or equal to the Capacity fields");
                return false;
            }
            return true;
        }


    }
}
