using Interfaces;
using prjPrograIII.Layer.Business_Logic;
using prjPrograIII.Layer.DAL;
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
using log4net;

namespace prjPrograIII
{


    public partial class frmCliente : Form
    {
        private EstadoMatenimiento AccionAEjecutar;

        private static readonly log4net.ILog _MyLogControlEventos =
                                         log4net.LogManager.GetLogger("MyControlEventos");
        public frmCliente()
        {
            InitializeComponent();
            this.CambiarEstado(EstadoMatenimiento.Agregar);
            this.RefreshGrid();
        }

        /// <summary>
        /// This function closes the application when the user clicks the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMainMenu temp = new frmMainMenu();
            temp.Show();
            this.Close();
        }


        #region Logic Management methods

        /// <summary>
        /// Changes the status of the form
        /// </summary>
        /// <param name="estado"></param>
        private void CambiarEstado(EstadoMatenimiento estado)
        {
            //Reset the form
            this.txtb_Nombre.Clear();
            this.txb_Cedula.Clear();
            this.txtb_Direccion.Clear();
            this.dtp_FechaNac.Enabled = false;
            this.txtb_Nombre.Enabled = false;
            this.txb_Cedula.Enabled = false;
            this.txtb_Direccion.Enabled = false;
            this.btn_Procesar.Enabled = false;
            this.cbo_Sexo.DataSource = Enum.GetNames(typeof(Sexo));
            this.PrepareNacionalidades();

            //Save the action to execute

            this.AccionAEjecutar = estado;


            switch (estado)
            {
                case EstadoMatenimiento.Agregar:
                    this.dtp_FechaNac.Enabled = true;
                    this.txtb_Nombre.Enabled = true;
                    this.txb_Cedula.Enabled = true;
                    this.txtb_Direccion.Enabled = true;
                    this.btn_Procesar.Enabled = true;
                    txtb_Nombre.Focus();
                    break;
                case EstadoMatenimiento.Modificar:
                    this.dtp_FechaNac.Enabled = true;
                    this.txtb_Nombre.Enabled = true;
                    this.txb_Cedula.Enabled = false;
                    this.txtb_Direccion.Enabled = true;
                    this.btn_Procesar.Enabled = true;
                    txtb_Nombre.Focus();
                    break;
                case EstadoMatenimiento.Eliminar:
                    break;
                default:

                    break;
            }
        }

        /// <summary>
        /// Prepare and show the nationalities on the cbo
        /// </summary>
        private void PrepareNacionalidades() {
            IDALNacionalidad tp = new DALNacionalidad();
            this.cbo_Nacionalidad.DataSource = tp.GetAll();

        }

        /// <summary>
        /// Gets all the Clients and sets them up on the DGV
        /// </summary>
        private void RefreshGrid() {
            BLLCliente _BLLCliente = new BLLCliente();
            dgv_Datos.AutoGenerateColumns = true;
            dgv_Datos.RowTemplate.Height = 100;
            this.dgv_Datos.DataSource = _BLLCliente.GetAll();
            this.CambiarEstado(EstadoMatenimiento.Agregar);
        }

        #endregion

        /// <summary>
        /// Event that happens when you click the add button
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
        /// Event that happens when you click the mod button
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

                    Cliente obj1 = this.dgv_Datos.SelectedRows[0].DataBoundItem as Cliente;
                    this.txb_Cedula.Text = obj1.IdCliente.ToString();
                    txtb_Nombre.Text = obj1.NombreCliente;
                    this.txtb_Direccion.Text = obj1.CorreoCliente;
                    this.cbo_Nacionalidad.SelectedItem = obj1.NacionalidadCliente;
                    this.cbo_Sexo.SelectedItem = obj1.SexoCliente;
                    this.dtp_FechaNac.Value = obj1.FNacimCliente;


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
                ////_MyLogControlEventos.Error(msg.ToString());

            }
        }

        /// <summary>
        /// Event that happens when you click the delete button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                this.CambiarEstado(EstadoMatenimiento.Eliminar);


                //Delete the data 

                BLLCliente _BLLCliente = new BLLCliente();


                if (this.dgv_Datos.SelectedRows.Count > 0)
                {
                    Cliente objToDelete = this.dgv_Datos.SelectedRows[0].DataBoundItem as Cliente;
                    if (MessageBox.Show("¿Seguro que desea borrar el cliente " + objToDelete.NombreCliente + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _BLLCliente.BorrarCliente(objToDelete.IdCliente);
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

                ////_MyLogControlEventos.Error(msg.ToString());
            }
        }

        private void dgv_Datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Processes the fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            if (this.ValidateFields())
            {
                try
                {
                    IBLLCliente _IBLLCliente = new BLLCliente();

                    Cliente objToReturn = new Cliente()
                    {
                        IdCliente = int.Parse(this.txb_Cedula.Text),
                        NombreCliente = this.txtb_Nombre.Text,
                        CorreoCliente = this.txtb_Direccion.Text,
                    };

                    objToReturn.NacionalidadCliente = (Nacionalidad)(cbo_Nacionalidad.SelectedItem);
                    //objToReturn.SexoCliente = new Sexo(this.cbo_Sexo.SelectedItem.ToString());

                    //Set the born date for the client
                    DateTime dt = this.dtp_FechaNac.Value.Date;

                    objToReturn.FNacimCliente = dt;


                    _IBLLCliente.Insert(objToReturn);

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

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Validates the fields on the form
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields() {

            if (this.txb_Cedula.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txb_Cedula, "Please enter an ID");
                //_MyLogControlEventos.Error("Please enter a correct ID (on frmCliente)");

                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(this.txtb_Direccion.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                this.errPrvder1.SetError(this.txtb_Direccion, "Please enter an email");
                //_MyLogControlEventos.Error("Please enter a correct email (on frmCliente)");

                return false;
            }
            if (this.txtb_Nombre.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txtb_Nombre, "Please enter a Name");
                //_MyLogControlEventos.Error("Please enter a correct name (on frmCliente)");

                return false;
            }
            try { int.Parse(this.txb_Cedula.Text); } catch (Exception)
            {
                this.errPrvder1.SetError(this.txb_Cedula, "Please enter a numeric ID");
                //_MyLogControlEventos.Error("Please enter a correct number (on frmCliente)");

                return false;
            }
            return true;
        }

    }
}

