using Interfaces;
using Microsoft.Reporting.WinForms;
using prjPrograIII.Layer.Business_Logic;
using prjPrograIII.Layer.DAL;
using prjPrograIII.Layer.Entities;
using prjPrograIII.Layer.User_Interface;
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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
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
        /// Show the requested form and hide this one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            frmEmpleado t = new frmEmpleado();
            t.Show();
            this.Close();
        }
        /// <summary>
        /// Show the requested form and hide this one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            frmCliente t = new frmCliente();
            t.Show();
            this.Close();
        }
        /// <summary>
        /// Show the requested form and hide this one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TiposEventos_Click(object sender, EventArgs e)
        {
            frmTipoEvento t = new frmTipoEvento();
            t.Show();
            this.Close();
        }
        /// <summary>
        /// Show the requested form and hide this one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Localidades_Click(object sender, EventArgs e)
        {
            frmLocalidad t = new frmLocalidad();
            t.Show();
            this.Close();
        }
        /// <summary>
        /// Show the requested form and hide this one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Eventos_Click(object sender, EventArgs e)
        {
            frmEvento t = new frmEvento();
            t.Show();
            this.Close();
        }
        /// <summary>
        /// Show the requested form and hide this one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RealizarVenta_Click(object sender, EventArgs e)
        {
            frmRealizarVenta t = new frmRealizarVenta();
            t.Show();
            this.Close();
        }
        /// <summary>
        /// Show the requested form and hide this one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_RevisarVenta_Click(object sender, EventArgs e)
        {
            frmValidarVenta f = new frmValidarVenta();
            f.Show();
        }

        /// <summary>
        /// Main load procedure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            this.rptViewer_GeneratedReport.RefreshReport(); //Just for control

            if (this.SetupMenu())
            {
              //  MessageBox.Show("Bienvenido al sistema", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Close();
            }
        }

        /// <summary>
        /// Activate/Deactivate controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GenRpt_SalesByDay_Click(object sender, EventArgs e)
        {
            this.pnl_GenRpt_SalesByDateRange.Visible = true; //Show necessary controls
            this.pnl_GenRpt_EventSlots.Visible = false; //Hide unnecesary controls

        }

        /// <summary>
        /// Activate/Deactivate controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GenRpt_FreeSlots_Click(object sender, EventArgs e)
        { 
            this.pnl_GenRpt_EventSlots.Visible = true; //Show necessary controls
            this.pnl_GenRpt_SalesByDateRange.Visible = false;//Hide unnecesary controls

            //Load the events
            IBLLEvento _BLLEvento = new BLLEvento();
            foreach (var item in _BLLEvento.GetAll())
            {
                this.cbo_GenRpt_EventSlots.Items.Add(item);
            }
            this.cbo_GenRpt_EventSlots.DisplayMember = "DescripcionEvento";
            this.cbo_GenRpt_EventSlots.SelectedIndex = 0;

        }

        /// <summary>
        /// Generate the report selected by the client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Generate_Click(object sender, EventArgs e)
        {
            if (this.pnl_GenRpt_EventSlots.Visible) //Gen rpt for event slots
            {
                this.GenRpt_EventEmptySeats();
            }
            else if (this.pnl_GenRpt_SalesByDateRange.Visible) //Gen rpt for sales by range
            {
                this.GenRpt_SalesByDateRange();
            }else
            {
                MessageBox.Show("Seleccione el reporte a realizar!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Generate the report for sale range by date
        /// </summary>
        private void GenRpt_SalesByDateRange()
        {
            this.rptViewer_GeneratedReport.Reset(); //Reset the report viewer

            IDALReports _DALReport = new DALReports();

            DateTime FromDate = this.dtp_DateRange_From.Value.Date;
            DateTime ToDate = this.dtp_DateRange_To.Value.Date;

            DataTable dt = _DALReport.GetEventsByDateRange(FromDate, ToDate);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            this.rptViewer_GeneratedReport.LocalReport.DataSources.Add(rds);

            this.rptViewer_GeneratedReport.LocalReport.ReportPath = "Rpt_SalesByRange.rdlc";
            
            this.rptViewer_GeneratedReport.RefreshReport();


        }

        /// <summary>
        /// Generate the report for the empt
        /// </summary>
        private void GenRpt_EventEmptySeats()
        {
            this.rptViewer_GeneratedReport.Reset(); //Reset the report viewer

            IDALReports _DALReport = new DALReports();

            Evento temporal = (Evento) this.cbo_GenRpt_EventSlots.SelectedItem;

            DataTable dt = _DALReport.GetEmptySeats(temporal.IdEvento);
            ReportDataSource rds = new ReportDataSource("Dst_Result_EventEmptySeats", dt);

            this.rptViewer_GeneratedReport.LocalReport.DataSources.Add(rds);

            this.rptViewer_GeneratedReport.LocalReport.ReportPath = "Rpt_EmptySeats.rdlc";

            this.rptViewer_GeneratedReport.RefreshReport();
        }

        /// <summary>
        /// Reset the UI for the user on the reports section
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            this.rptViewer_GeneratedReport.Reset();
            this.pnl_GenRpt_EventSlots.Hide();
            this.pnl_GenRpt_SalesByDateRange.Hide();
        }

        private bool SetupMenu()
        {

            try
            {
                switch (Usuario._Usuario.Tipo)
                {
                    case TipoEmpleado.Administrador: //Enable user UI for admin
                        break;
                    case TipoEmpleado.Procesador: //Enable user UI for process
                        this.tbc_MenuPrincipal.TabPages.Remove(this.tbMantenimientos); //Unable maintenance
                        this.tbc_MenuPrincipal.TabPages.Remove(this.tbReportes); //Unable reports
                        break;
                    case TipoEmpleado.Reportero: //Enable user UI for report
                        this.tbc_MenuPrincipal.TabPages.Remove(this.tbMantenimientos); //Unable maintenance
                        this.tbc_MenuPrincipal.TabPages.Remove(this.tbProcesos); //Unable process
                        break;
                    default:
                        throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error inesperado en el setup del menu principal!, contacte a soporte.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            return true;
        }

        private void tb_Principal_Click(object sender, EventArgs e)
        {

        }
    }
}
