namespace prjPrograIII
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.errPrvder1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.tbReportes = new System.Windows.Forms.TabPage();
            this.rptViewer_GeneratedReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnl_GenRpt_EventSlots = new System.Windows.Forms.Panel();
            this.cbo_GenRpt_EventSlots = new System.Windows.Forms.ComboBox();
            this.lbl_SelectEventAndDates = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.pnl_GenRpt_SalesByDateRange = new System.Windows.Forms.Panel();
            this.dtp_DateRange_To = new System.Windows.Forms.DateTimePicker();
            this.lbl_Hasta = new System.Windows.Forms.Label();
            this.dtp_DateRange_From = new System.Windows.Forms.DateTimePicker();
            this.lbl_From = new System.Windows.Forms.Label();
            this.lbl_SalesByDateRange = new System.Windows.Forms.Label();
            this.btn_GenRpt_FreeSlots = new System.Windows.Forms.Button();
            this.btn_GenRpt_SalesByDay = new System.Windows.Forms.Button();
            this.tbProcesos = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_RevisarVenta = new System.Windows.Forms.Button();
            this.btn_RealizarVenta = new System.Windows.Forms.Button();
            this.tbMantenimientos = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Eventos = new System.Windows.Forms.Button();
            this.btn_Localidades = new System.Windows.Forms.Button();
            this.btn_TiposEventos = new System.Windows.Forms.Button();
            this.pnl_Empleados = new System.Windows.Forms.Panel();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_Empleado = new System.Windows.Forms.Button();
            this.tbc_MenuPrincipal = new System.Windows.Forms.TabControl();
            this.tb_Principal = new System.Windows.Forms.TabPage();
            this.lbl_Instruccion = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvder1)).BeginInit();
            this.tbReportes.SuspendLayout();
            this.pnl_GenRpt_EventSlots.SuspendLayout();
            this.pnl_GenRpt_SalesByDateRange.SuspendLayout();
            this.tbProcesos.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tbMantenimientos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_Empleados.SuspendLayout();
            this.tbc_MenuPrincipal.SuspendLayout();
            this.tb_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // errPrvder1
            // 
            this.errPrvder1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::prjPrograIII.Properties.Resources.close_button;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1061, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 78);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbReportes
            // 
            this.tbReportes.BackgroundImage = global::prjPrograIII.Properties.Resources.bg;
            this.tbReportes.Controls.Add(this.rptViewer_GeneratedReport);
            this.tbReportes.Controls.Add(this.pnl_GenRpt_EventSlots);
            this.tbReportes.Controls.Add(this.btn_Reset);
            this.tbReportes.Controls.Add(this.btn_Generate);
            this.tbReportes.Controls.Add(this.pnl_GenRpt_SalesByDateRange);
            this.tbReportes.Controls.Add(this.btn_GenRpt_FreeSlots);
            this.tbReportes.Controls.Add(this.btn_GenRpt_SalesByDay);
            this.tbReportes.Location = new System.Drawing.Point(4, 33);
            this.tbReportes.Name = "tbReportes";
            this.tbReportes.Size = new System.Drawing.Size(1151, 740);
            this.tbReportes.TabIndex = 2;
            this.tbReportes.Text = "Reportes";
            this.tbReportes.UseVisualStyleBackColor = true;
            // 
            // rptViewer_GeneratedReport
            // 
            this.rptViewer_GeneratedReport.Location = new System.Drawing.Point(270, 342);
            this.rptViewer_GeneratedReport.Name = "rptViewer_GeneratedReport";
            this.rptViewer_GeneratedReport.Size = new System.Drawing.Size(829, 328);
            this.rptViewer_GeneratedReport.TabIndex = 7;
            // 
            // pnl_GenRpt_EventSlots
            // 
            this.pnl_GenRpt_EventSlots.Controls.Add(this.cbo_GenRpt_EventSlots);
            this.pnl_GenRpt_EventSlots.Controls.Add(this.lbl_SelectEventAndDates);
            this.pnl_GenRpt_EventSlots.Location = new System.Drawing.Point(270, 188);
            this.pnl_GenRpt_EventSlots.Name = "pnl_GenRpt_EventSlots";
            this.pnl_GenRpt_EventSlots.Size = new System.Drawing.Size(765, 132);
            this.pnl_GenRpt_EventSlots.TabIndex = 6;
            this.pnl_GenRpt_EventSlots.Visible = false;
            // 
            // cbo_GenRpt_EventSlots
            // 
            this.cbo_GenRpt_EventSlots.FormattingEnabled = true;
            this.cbo_GenRpt_EventSlots.Location = new System.Drawing.Point(445, 43);
            this.cbo_GenRpt_EventSlots.Name = "cbo_GenRpt_EventSlots";
            this.cbo_GenRpt_EventSlots.Size = new System.Drawing.Size(218, 32);
            this.cbo_GenRpt_EventSlots.TabIndex = 6;
            // 
            // lbl_SelectEventAndDates
            // 
            this.lbl_SelectEventAndDates.AutoSize = true;
            this.lbl_SelectEventAndDates.Location = new System.Drawing.Point(140, 51);
            this.lbl_SelectEventAndDates.Name = "lbl_SelectEventAndDates";
            this.lbl_SelectEventAndDates.Size = new System.Drawing.Size(194, 24);
            this.lbl_SelectEventAndDates.TabIndex = 0;
            this.lbl_SelectEventAndDates.Text = "Seleccione un evento";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(39, 492);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(176, 76);
            this.btn_Reset.TabIndex = 4;
            this.btn_Reset.Text = "Reiniciar proceso";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Generate
            // 
            this.btn_Generate.Location = new System.Drawing.Point(39, 357);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(176, 76);
            this.btn_Generate.TabIndex = 3;
            this.btn_Generate.Text = "Generar Reporte";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // pnl_GenRpt_SalesByDateRange
            // 
            this.pnl_GenRpt_SalesByDateRange.Controls.Add(this.dtp_DateRange_To);
            this.pnl_GenRpt_SalesByDateRange.Controls.Add(this.lbl_Hasta);
            this.pnl_GenRpt_SalesByDateRange.Controls.Add(this.dtp_DateRange_From);
            this.pnl_GenRpt_SalesByDateRange.Controls.Add(this.lbl_From);
            this.pnl_GenRpt_SalesByDateRange.Controls.Add(this.lbl_SalesByDateRange);
            this.pnl_GenRpt_SalesByDateRange.Location = new System.Drawing.Point(270, 33);
            this.pnl_GenRpt_SalesByDateRange.Name = "pnl_GenRpt_SalesByDateRange";
            this.pnl_GenRpt_SalesByDateRange.Size = new System.Drawing.Size(765, 132);
            this.pnl_GenRpt_SalesByDateRange.TabIndex = 2;
            this.pnl_GenRpt_SalesByDateRange.Visible = false;
            // 
            // dtp_DateRange_To
            // 
            this.dtp_DateRange_To.Location = new System.Drawing.Point(489, 71);
            this.dtp_DateRange_To.Name = "dtp_DateRange_To";
            this.dtp_DateRange_To.Size = new System.Drawing.Size(250, 29);
            this.dtp_DateRange_To.TabIndex = 5;
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.AutoSize = true;
            this.lbl_Hasta.Location = new System.Drawing.Point(413, 76);
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(62, 24);
            this.lbl_Hasta.TabIndex = 4;
            this.lbl_Hasta.Text = "Hasta:";
            // 
            // dtp_DateRange_From
            // 
            this.dtp_DateRange_From.Location = new System.Drawing.Point(112, 72);
            this.dtp_DateRange_From.Name = "dtp_DateRange_From";
            this.dtp_DateRange_From.Size = new System.Drawing.Size(250, 29);
            this.dtp_DateRange_From.TabIndex = 3;
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Location = new System.Drawing.Point(36, 77);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(70, 24);
            this.lbl_From.TabIndex = 1;
            this.lbl_From.Text = "Desde:";
            // 
            // lbl_SalesByDateRange
            // 
            this.lbl_SalesByDateRange.AutoSize = true;
            this.lbl_SalesByDateRange.Location = new System.Drawing.Point(257, 19);
            this.lbl_SalesByDateRange.Name = "lbl_SalesByDateRange";
            this.lbl_SalesByDateRange.Size = new System.Drawing.Size(273, 24);
            this.lbl_SalesByDateRange.TabIndex = 0;
            this.lbl_SalesByDateRange.Text = "Seleccione un rango de fechas";
            // 
            // btn_GenRpt_FreeSlots
            // 
            this.btn_GenRpt_FreeSlots.Location = new System.Drawing.Point(39, 206);
            this.btn_GenRpt_FreeSlots.Name = "btn_GenRpt_FreeSlots";
            this.btn_GenRpt_FreeSlots.Size = new System.Drawing.Size(176, 81);
            this.btn_GenRpt_FreeSlots.TabIndex = 1;
            this.btn_GenRpt_FreeSlots.Text = "Free Slots for event";
            this.btn_GenRpt_FreeSlots.UseVisualStyleBackColor = true;
            this.btn_GenRpt_FreeSlots.Click += new System.EventHandler(this.btn_GenRpt_FreeSlots_Click);
            // 
            // btn_GenRpt_SalesByDay
            // 
            this.btn_GenRpt_SalesByDay.Location = new System.Drawing.Point(39, 52);
            this.btn_GenRpt_SalesByDay.Name = "btn_GenRpt_SalesByDay";
            this.btn_GenRpt_SalesByDay.Size = new System.Drawing.Size(176, 81);
            this.btn_GenRpt_SalesByDay.TabIndex = 0;
            this.btn_GenRpt_SalesByDay.Text = "Sales by date range";
            this.btn_GenRpt_SalesByDay.UseVisualStyleBackColor = true;
            this.btn_GenRpt_SalesByDay.Click += new System.EventHandler(this.btn_GenRpt_SalesByDay_Click);
            // 
            // tbProcesos
            // 
            this.tbProcesos.BackgroundImage = global::prjPrograIII.Properties.Resources.bg;
            this.tbProcesos.Controls.Add(this.panel4);
            this.tbProcesos.Location = new System.Drawing.Point(4, 33);
            this.tbProcesos.Name = "tbProcesos";
            this.tbProcesos.Padding = new System.Windows.Forms.Padding(3);
            this.tbProcesos.Size = new System.Drawing.Size(1151, 740);
            this.tbProcesos.TabIndex = 1;
            this.tbProcesos.Text = "Procesos";
            this.tbProcesos.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_RevisarVenta);
            this.panel4.Controls.Add(this.btn_RealizarVenta);
            this.panel4.Location = new System.Drawing.Point(23, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 646);
            this.panel4.TabIndex = 3;
            // 
            // btn_RevisarVenta
            // 
            this.btn_RevisarVenta.Image = ((System.Drawing.Image)(resources.GetObject("btn_RevisarVenta.Image")));
            this.btn_RevisarVenta.Location = new System.Drawing.Point(47, 185);
            this.btn_RevisarVenta.Name = "btn_RevisarVenta";
            this.btn_RevisarVenta.Size = new System.Drawing.Size(184, 120);
            this.btn_RevisarVenta.TabIndex = 1;
            this.btn_RevisarVenta.Text = "Verificar Compra";
            this.btn_RevisarVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_RevisarVenta.UseVisualStyleBackColor = true;
            this.btn_RevisarVenta.Click += new System.EventHandler(this.btn_RevisarVenta_Click);
            // 
            // btn_RealizarVenta
            // 
            this.btn_RealizarVenta.Image = ((System.Drawing.Image)(resources.GetObject("btn_RealizarVenta.Image")));
            this.btn_RealizarVenta.Location = new System.Drawing.Point(47, 16);
            this.btn_RealizarVenta.Name = "btn_RealizarVenta";
            this.btn_RealizarVenta.Size = new System.Drawing.Size(184, 120);
            this.btn_RealizarVenta.TabIndex = 0;
            this.btn_RealizarVenta.Text = "Realizar Compra";
            this.btn_RealizarVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_RealizarVenta.UseVisualStyleBackColor = true;
            this.btn_RealizarVenta.Click += new System.EventHandler(this.btn_RealizarVenta_Click);
            // 
            // tbMantenimientos
            // 
            this.tbMantenimientos.BackColor = System.Drawing.Color.Transparent;
            this.tbMantenimientos.BackgroundImage = global::prjPrograIII.Properties.Resources.bg;
            this.tbMantenimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tbMantenimientos.Controls.Add(this.panel2);
            this.tbMantenimientos.Controls.Add(this.panel1);
            this.tbMantenimientos.Controls.Add(this.pnl_Empleados);
            this.tbMantenimientos.Location = new System.Drawing.Point(4, 33);
            this.tbMantenimientos.Name = "tbMantenimientos";
            this.tbMantenimientos.Padding = new System.Windows.Forms.Padding(3);
            this.tbMantenimientos.Size = new System.Drawing.Size(1151, 740);
            this.tbMantenimientos.TabIndex = 0;
            this.tbMantenimientos.Text = "Administracion";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::prjPrograIII.Properties.Resources.logo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(700, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 249);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Eventos);
            this.panel1.Controls.Add(this.btn_Localidades);
            this.panel1.Controls.Add(this.btn_TiposEventos);
            this.panel1.Location = new System.Drawing.Point(380, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 646);
            this.panel1.TabIndex = 6;
            // 
            // btn_Eventos
            // 
            this.btn_Eventos.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eventos.Image")));
            this.btn_Eventos.Location = new System.Drawing.Point(47, 358);
            this.btn_Eventos.Name = "btn_Eventos";
            this.btn_Eventos.Size = new System.Drawing.Size(186, 120);
            this.btn_Eventos.TabIndex = 6;
            this.btn_Eventos.Text = "Eventos";
            this.btn_Eventos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Eventos.UseVisualStyleBackColor = true;
            this.btn_Eventos.Click += new System.EventHandler(this.btn_Eventos_Click);
            // 
            // btn_Localidades
            // 
            this.btn_Localidades.Image = ((System.Drawing.Image)(resources.GetObject("btn_Localidades.Image")));
            this.btn_Localidades.Location = new System.Drawing.Point(47, 185);
            this.btn_Localidades.Name = "btn_Localidades";
            this.btn_Localidades.Size = new System.Drawing.Size(186, 120);
            this.btn_Localidades.TabIndex = 5;
            this.btn_Localidades.Text = "Localidades";
            this.btn_Localidades.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Localidades.UseVisualStyleBackColor = true;
            this.btn_Localidades.Click += new System.EventHandler(this.btn_Localidades_Click);
            // 
            // btn_TiposEventos
            // 
            this.btn_TiposEventos.Image = ((System.Drawing.Image)(resources.GetObject("btn_TiposEventos.Image")));
            this.btn_TiposEventos.Location = new System.Drawing.Point(47, 16);
            this.btn_TiposEventos.Name = "btn_TiposEventos";
            this.btn_TiposEventos.Size = new System.Drawing.Size(186, 120);
            this.btn_TiposEventos.TabIndex = 1;
            this.btn_TiposEventos.Text = "Tipos de Eventos";
            this.btn_TiposEventos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_TiposEventos.UseVisualStyleBackColor = true;
            this.btn_TiposEventos.Click += new System.EventHandler(this.btn_TiposEventos_Click);
            // 
            // pnl_Empleados
            // 
            this.pnl_Empleados.Controls.Add(this.btn_Clientes);
            this.pnl_Empleados.Controls.Add(this.btn_Empleado);
            this.pnl_Empleados.Location = new System.Drawing.Point(22, 18);
            this.pnl_Empleados.Name = "pnl_Empleados";
            this.pnl_Empleados.Size = new System.Drawing.Size(293, 646);
            this.pnl_Empleados.TabIndex = 2;
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clientes.Image")));
            this.btn_Clientes.Location = new System.Drawing.Point(47, 185);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(184, 120);
            this.btn_Clientes.TabIndex = 1;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // btn_Empleado
            // 
            this.btn_Empleado.Image = ((System.Drawing.Image)(resources.GetObject("btn_Empleado.Image")));
            this.btn_Empleado.Location = new System.Drawing.Point(47, 16);
            this.btn_Empleado.Name = "btn_Empleado";
            this.btn_Empleado.Size = new System.Drawing.Size(184, 120);
            this.btn_Empleado.TabIndex = 0;
            this.btn_Empleado.Text = "Colaboradores";
            this.btn_Empleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Empleado.UseVisualStyleBackColor = true;
            this.btn_Empleado.Click += new System.EventHandler(this.btn_Empleado_Click);
            // 
            // tbc_MenuPrincipal
            // 
            this.tbc_MenuPrincipal.Controls.Add(this.tb_Principal);
            this.tbc_MenuPrincipal.Controls.Add(this.tbMantenimientos);
            this.tbc_MenuPrincipal.Controls.Add(this.tbProcesos);
            this.tbc_MenuPrincipal.Controls.Add(this.tbReportes);
            this.tbc_MenuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_MenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tbc_MenuPrincipal.Name = "tbc_MenuPrincipal";
            this.tbc_MenuPrincipal.SelectedIndex = 0;
            this.tbc_MenuPrincipal.Size = new System.Drawing.Size(1159, 777);
            this.tbc_MenuPrincipal.TabIndex = 1;
            // 
            // tb_Principal
            // 
            this.tb_Principal.BackgroundImage = global::prjPrograIII.Properties.Resources.bg;
            this.tb_Principal.Controls.Add(this.lbl_Instruccion);
            this.tb_Principal.Controls.Add(this.panel3);
            this.tb_Principal.Controls.Add(this.lbl_Title);
            this.tb_Principal.Location = new System.Drawing.Point(4, 33);
            this.tb_Principal.Name = "tb_Principal";
            this.tb_Principal.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Principal.Size = new System.Drawing.Size(1151, 740);
            this.tb_Principal.TabIndex = 3;
            this.tb_Principal.Text = "Menu Principal";
            this.tb_Principal.UseVisualStyleBackColor = true;
            this.tb_Principal.Click += new System.EventHandler(this.tb_Principal_Click);
            // 
            // lbl_Instruccion
            // 
            this.lbl_Instruccion.AutoSize = true;
            this.lbl_Instruccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instruccion.Location = new System.Drawing.Point(205, 160);
            this.lbl_Instruccion.Name = "lbl_Instruccion";
            this.lbl_Instruccion.Size = new System.Drawing.Size(603, 37);
            this.lbl_Instruccion.TabIndex = 2;
            this.lbl_Instruccion.Text = "Seleccione una opcion del menu superior";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::prjPrograIII.Properties.Resources.logo;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(278, 280);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 243);
            this.panel3.TabIndex = 1;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(345, 55);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(335, 37);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Bienvenido al sistema!";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1159, 777);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbc_MenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy-Ticket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errPrvder1)).EndInit();
            this.tbReportes.ResumeLayout(false);
            this.pnl_GenRpt_EventSlots.ResumeLayout(false);
            this.pnl_GenRpt_EventSlots.PerformLayout();
            this.pnl_GenRpt_SalesByDateRange.ResumeLayout(false);
            this.pnl_GenRpt_SalesByDateRange.PerformLayout();
            this.tbProcesos.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tbMantenimientos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnl_Empleados.ResumeLayout(false);
            this.tbc_MenuPrincipal.ResumeLayout(false);
            this.tb_Principal.ResumeLayout(false);
            this.tb_Principal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errPrvder1;
        private System.Windows.Forms.TabControl tbc_MenuPrincipal;
        private System.Windows.Forms.TabPage tbMantenimientos;
        private System.Windows.Forms.Panel pnl_Empleados;
        private System.Windows.Forms.TabPage tbProcesos;
        private System.Windows.Forms.TabPage tbReportes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Eventos;
        private System.Windows.Forms.Button btn_Localidades;
        private System.Windows.Forms.Button btn_TiposEventos;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_Empleado;
        private System.Windows.Forms.TabPage tb_Principal;
        private System.Windows.Forms.Label lbl_Instruccion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_RevisarVenta;
        private System.Windows.Forms.Button btn_RealizarVenta;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewer_GeneratedReport;
        private System.Windows.Forms.Panel pnl_GenRpt_EventSlots;
        private System.Windows.Forms.ComboBox cbo_GenRpt_EventSlots;
        private System.Windows.Forms.Label lbl_SelectEventAndDates;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Panel pnl_GenRpt_SalesByDateRange;
        private System.Windows.Forms.DateTimePicker dtp_DateRange_To;
        private System.Windows.Forms.Label lbl_Hasta;
        private System.Windows.Forms.DateTimePicker dtp_DateRange_From;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_SalesByDateRange;
        private System.Windows.Forms.Button btn_GenRpt_FreeSlots;
        private System.Windows.Forms.Button btn_GenRpt_SalesByDay;
    }
}

