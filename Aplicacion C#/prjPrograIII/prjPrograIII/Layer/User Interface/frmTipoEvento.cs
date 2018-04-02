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
    public partial class frmTipoEvento : Form
    {
        public frmTipoEvento()
        {
            InitializeComponent();
            this.RefreshGrid();
            this.CambiarEstado(EstadoMatenimiento.Agregar);
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

        /// <summary>
        /// Action processed when the Add button is clicked
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
        /// Action processed when the Mod button is clicked
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

                    TipoEvento obj1 = this.dgv_Datos.SelectedRows[0].DataBoundItem as TipoEvento;

                    this.txtb_Nombre.Text = obj1.DescripcionTipoEvento;
                    this.txb_Cedula.Text = obj1.IdTipoEvento.ToString();

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
        /// Action processed when the Del button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Click(object sender, EventArgs e)
        {
            try
            {
                this.CambiarEstado(EstadoMatenimiento.Eliminar);


                //Delete the data 

                IBLLTipoEvento _BLLTipoEvento = new BLLTipoEvento();


                if (this.dgv_Datos.SelectedRows.Count > 0)
                {
                    TipoEvento objToDelete = this.dgv_Datos.SelectedRows[0].DataBoundItem as TipoEvento;
                    if (MessageBox.Show("¿Seguro que desea borrar el empleado " + objToDelete.DescripcionTipoEvento + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _BLLTipoEvento.Borrar(objToDelete.IdTipoEvento);
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
        /// Changes the status of the form
        /// </summary>
        /// <param name="estado"></param>
        private void CambiarEstado(EstadoMatenimiento estado)
        {
            //Reset the form
            this.txb_Cedula.Clear();
            this.txtb_Nombre.Clear();


            switch (estado)
            {
                case EstadoMatenimiento.Agregar:
                    this.txtb_Nombre.Enabled = true;
                    this.txb_Cedula.Enabled = true;
                    txtb_Nombre.Focus();
                    break;
                case EstadoMatenimiento.Modificar:
                    this.txtb_Nombre.Enabled = true;
                    this.txb_Cedula.Enabled = false;
                    txtb_Nombre.Focus();
                    break;
                case EstadoMatenimiento.Eliminar:
                    break;
                default:

                    break;
            }
        }

        /// <summary>
        /// Gets all the Event Types and sets them up on the DGV
        /// </summary>
        private void RefreshGrid()
        {
            IBLLTipoEvento _BLLTipoEvento = new BLLTipoEvento();
            dgv_Datos.AutoGenerateColumns = true;
            dgv_Datos.RowTemplate.Height = 100;
            this.dgv_Datos.DataSource = _BLLTipoEvento.GetAll();
            this.CambiarEstado(EstadoMatenimiento.Agregar);
        }

        /// <summary>
        /// Process the form action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            if (this.ValidateFields())
            {
                try
                {
                    IBLLTipoEvento _BLLTipoEvento = new BLLTipoEvento();



                    TipoEvento objToReturn = new TipoEvento()
                    {
                        IdTipoEvento = int.Parse(this.txb_Cedula.Text),
                        DescripcionTipoEvento = this.txtb_Nombre.Text,
                    };


                    _BLLTipoEvento.Insert(objToReturn);

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
        /// Validates the fields on the form are filled
        /// </summary>
        /// <returns></returns>
        private bool ValidateFields()
        {
            //
            if (this.txb_Cedula.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txb_Cedula, "Please enter an ID");
                return false;
            }
            else
            {
                try { int.Parse(this.txb_Cedula.Text); }
                catch (Exception)
                {
                    this.errPrvder1.SetError(this.txb_Cedula, "Please enter a numeric ID");
                    return false;
                }
            }
            //
            if (this.txtb_Nombre.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txtb_Nombre, "Please enter a name");
                return false;
            }
            return true;
        }



    }
}

