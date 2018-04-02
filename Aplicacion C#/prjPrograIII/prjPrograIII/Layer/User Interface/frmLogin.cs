using Interfaces;
using prjPrograIII.Layer.Business_Logic;
using prjPrograIII.Layer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPrograIII
{
    public partial class frmLogin : Form
    {
        private int contador = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function closes the application when the user clicks the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close the application
            System.Windows.Forms.Application.Exit();
        }

        /// <summary>
        ///  This function performs the Login on the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrfrmLogin_Click(object sender, EventArgs e)
        {
            if (this.CheckIfLoginFieldsAreEmpty()) {
                try
                {
                    //Do login on database
                    IBLLLogin _BLLLogin = new BLLLogin();
                    _BLLLogin.Login(this.txbUname.Text, this.txbUpwd.Text);

                    //Create instance of user
                    Usuario.GetInstance(int.Parse(txbUname.Text));


                    //Hide the actual form
                    this.Hide();
                    // Create a new instance of the Main Menu form and open it
                    frmMainMenu Mmenu = new frmMainMenu();
                    Mmenu.Show();
                }
                catch (Exception error)
                {

                    // Incrementar el contador
                    contador++;

                    // Si el mensaje es "Error de inicio de sesión del usuario" es un error de usuario inválido 
                    if (error.Message.Trim().Contains("Error de inicio de sesión del usuario") == true || error.Message.Trim().Contains("Login failed") == true)
                        MessageBox.Show("Usuario inválido, intento No " + contador, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        // otro Error
                        MessageBox.Show("Error ->" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Si el contador es 3 cierre la aplicación
                    if (contador == 3)
                    {
                        // se devuelve Cancel
                        this.DialogResult = DialogResult.Cancel;
                        Application.Exit();
                    }



                }

            }
        }

        /// <summary>
        /// This function performs a check to see if the User Name and the User Password have been entered
        /// </summary>
        /// <returns> bool with TRUE if the fields have been filled</returns>
        private bool CheckIfLoginFieldsAreEmpty() {
            if (this.txbUname.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txbUname, "Please enter your UserName");
                return false;
            }else if (this.txbUpwd.Text.Equals(""))
            {
                this.errPrvder1.SetError(this.txbUpwd, "Please enter your User Password");
                return false;
            }
            return true;
        }



    }
}
