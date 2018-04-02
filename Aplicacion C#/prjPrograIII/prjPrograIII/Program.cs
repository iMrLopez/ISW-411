using prjPrograIII.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPrograIII
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Setup the main culture to es-CR
            Utl_CulturePicker.SpanishCulture();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Utl_VerifyAdmin.IsAdministrator()) //Check if app is running with admin rights

            {
                Application.Run(new frmLogin());

            }
            else
            {
                MessageBox.Show("Error -> La aplicacion debe correr con privilegios de administrador. Cerrando", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Windows.Forms.Application.Exit();

            }



        }



    }
}
