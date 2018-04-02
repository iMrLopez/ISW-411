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
    public partial class frmEmpleado : Form
    {
        private EstadoMatenimiento AccionAEjecutar;

        public frmEmpleado()
        {
            InitializeComponent();
            this.RefreshGrid();

            this.CambiarEstado(EstadoMatenimiento.Agregar);

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

        private void btn_PickImg_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = opF_Fotografia.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
               // string file = opF_Fotografia.FileName;
                try
                {
                   // this.txtb_Fotografia.Text = opF_Fotografia.FileName;
                   // string text = File.ReadAllText(file);
                   // size = text.Length;
                }
                catch (IOException ae)
                {
                }
            }
           // Console.WriteLine(size); // <-- Shows file size in debugging mode.
          // Console.WriteLine(result); // <-- For debugging use.
        }

        /// <summary>
        /// Gets all the Clients and sets them up on the DGV
        /// </summary>
        private void RefreshGrid()
        {
            IBLLEmpleado _BLLEmpleado = new BLLEmpleado();
            dgv_Datos.AutoGenerateColumns = true;
            dgv_Datos.RowTemplate.Height = 100;
            this.dgv_Datos.DataSource = _BLLEmpleado.GetAll();
            this.CambiarEstado(EstadoMatenimiento.Agregar);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
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
        /// Changes the status of the form
        /// </summary>
        /// <param name="estado"></param>
        private void CambiarEstado(EstadoMatenimiento estado)
        {
            //Reset the form
            this.txtb_Nombre.Clear();
            this.txtb_Apellidos.Clear();
            this.txb_Cedula.Clear();
            this.txtb_Direccion.Clear();
            this.txtb_Telefono.Clear();
            this.txtb_email.Clear();
            this.ptb_Fotografia.Image = Properties.Resources.Default_Person;
            this.cbo_TipoEmpleado.DataSource = Enum.GetValues(typeof(TipoEmpleado));

            //Convert the image to byte[]
            ImageConverter converter = new ImageConverter();
            this.ptb_Fotografia.Tag = (byte[])converter.ConvertTo(Properties.Resources.Default_Person, typeof(byte[]));

            //Save the action to execute

            this.AccionAEjecutar = estado;


            switch (estado)
            {
                case EstadoMatenimiento.Agregar:
                    this.txtb_Nombre.Enabled = true;
                    this.txtb_Apellidos.Enabled = true;
                    this.txb_Cedula.Enabled = true;
                    this.txtb_Direccion.Enabled = true;
                    this.txtb_Telefono.Enabled = true;
                    this.txtb_email.Enabled = true;
                    this.btn_Procesar.Enabled = true;
                    this.ptb_Fotografia.Enabled = true;
                    txtb_Nombre.Focus();
                    break;
                case EstadoMatenimiento.Modificar:
                    this.txtb_Nombre.Enabled = true;
                    this.txtb_Apellidos.Enabled = true;
                    this.txb_Cedula.Enabled = false;
                    this.txtb_Direccion.Enabled = true;
                    this.txtb_Telefono.Enabled = true;
                    this.txtb_email.Enabled = true;
                    this.btn_Procesar.Enabled = true;
                    this.ptb_Fotografia.Enabled = true;
                    txtb_Nombre.Focus();
                    break;
                case EstadoMatenimiento.Eliminar:
                    break;
                default:

                    break;
            }
        }

        /// <summary>
        /// Adds a Employee to the db
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
        private void btn_Mod_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.dgv_Datos.SelectedRows.Count > 0)
                {

                    this.CambiarEstado(EstadoMatenimiento.Modificar);

                    Empleado obj1 = this.dgv_Datos.SelectedRows[0].DataBoundItem as Empleado;

                    this.txtb_Nombre.Text = obj1.NombreEmpleado;
                    this.txtb_Apellidos.Text = obj1.ApellidosEmpleado;
                    this.txb_Cedula.Text = obj1.IdEmpleado.ToString();
                    this.txtb_Direccion.Text = obj1.DireccionEmpleado;
                    this.txtb_Telefono.Text = obj1.TelefonoEmpleado;
                    this.txtb_email.Text = obj1.CorreoEmpleado;

                    //Extract image to put on picturebox
                    Bitmap image;
                    using (MemoryStream stream = new MemoryStream(obj1.FotografiaEmpleado))
                    {
                        image = new Bitmap(stream);
                    }
                    this.ptb_Fotografia.Image = image;
                    this.ptb_Fotografia.Tag = obj1.FotografiaEmpleado;

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
        /// Deletes the employee from the db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                this.CambiarEstado(EstadoMatenimiento.Eliminar);


                //Delete the data 

                IBLLEmpleado _BLLEmpleado = new BLLEmpleado();


                if (this.dgv_Datos.SelectedRows.Count > 0)
                {
                    Empleado objToDelete = this.dgv_Datos.SelectedRows[0].DataBoundItem as Empleado;
                    if (MessageBox.Show("¿Seguro que desea borrar el empleado " + objToDelete.NombreEmpleado + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _BLLEmpleado.BorrarEmpleado(objToDelete.IdEmpleado);
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
        /// Action that happens when you click the process button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            if (this.ValidateFields())
            {
                try
                {
                    IBLLEmpleado _IBLLEmpleado = new BLLEmpleado();
                    Empleado objToReturn = new Empleado()
                    {
                        IdEmpleado = int.Parse(this.txb_Cedula.Text),
                        NombreEmpleado = this.txtb_Nombre.Text,
                        ApellidosEmpleado = this.txtb_Apellidos.Text,
                        TelefonoEmpleado = this.txtb_Telefono.Text,
                        CorreoEmpleado = this.txtb_email.Text,
                        DireccionEmpleado = this.txtb_Direccion.Text,
                        FotografiaEmpleado = (byte[])this.ptb_Fotografia.Tag,
                    };

                    objToReturn.Tipo = (TipoEmpleado)this.cbo_TipoEmpleado.SelectedItem;

                    _IBLLEmpleado.Insert(objToReturn);

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
        /// Validates the fields on the form
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {

           if (this.txb_Cedula.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txb_Cedula, "Please enter an ID");
                return false;
            }else
            {
                try { int.Parse(this.txb_Cedula.Text); }
                catch (Exception)
                {
                    this.errPrvder1.SetError(this.txb_Cedula, "Please enter a numeric ID");
                    return false;
                }
            }
            if (this.txtb_Nombre.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txtb_Nombre, "Please enter a name");
                return false;
            }
            if (this.txtb_Apellidos.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txtb_Apellidos, "Please enter a last name");
                return false;
            }
            if (this.txtb_Telefono.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txtb_Telefono, "Please enter phone number");
                return false;
            }
            if (this.txtb_Direccion.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txtb_Direccion, "Please enter an address");
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(this.txtb_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                this.errPrvder1.SetError(this.txtb_email, "Please enter an address");
                return false;
            }
            return true;
        }


    }
    
}
