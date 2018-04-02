namespace prjPrograIII
{
    partial class frmEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvento));
            this.errPrvder1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.pnl_Precios = new System.Windows.Forms.Panel();
            this.lbl_Ttl_Prices = new System.Windows.Forms.Label();
            this.txb_CostoVIP = new System.Windows.Forms.TextBox();
            this.lbl_Add_CostoPalco = new System.Windows.Forms.Label();
            this.txb_CostoPlata = new System.Windows.Forms.TextBox();
            this.txb_CostoPalcos = new System.Windows.Forms.TextBox();
            this.lbl_Add_CostoVIP = new System.Windows.Forms.Label();
            this.lbl_Add_CostoPlata = new System.Windows.Forms.Label();
            this.cbo_LugarEvento = new System.Windows.Forms.ComboBox();
            this.cbo_Estado = new System.Windows.Forms.ComboBox();
            this.dtp_FechaEvento = new System.Windows.Forms.DateTimePicker();
            this.cbo_TipoEvento = new System.Windows.Forms.ComboBox();
            this.lbl_Add_TipoEvento = new System.Windows.Forms.Label();
            this.txb_CantEntradas = new System.Windows.Forms.TextBox();
            this.txb_Descripcion = new System.Windows.Forms.TextBox();
            this.txb_IdEvento = new System.Windows.Forms.TextBox();
            this.lbl_Add_Logo = new System.Windows.Forms.Label();
            this.lbl_Add_Identf = new System.Windows.Forms.Label();
            this.lbl_Add_CantEntradas = new System.Windows.Forms.Label();
            this.lbl_Add_LugarEvento = new System.Windows.Forms.Label();
            this.lbl_Add_Estado = new System.Windows.Forms.Label();
            this.lbl_Add_Fecha = new System.Windows.Forms.Label();
            this.lbl_Add_Descripcion = new System.Windows.Forms.Label();
            this.opF_Fotografia = new System.Windows.Forms.OpenFileDialog();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tst_Menu = new System.Windows.Forms.ToolStrip();
            this.btn_Add = new System.Windows.Forms.ToolStripButton();
            this.tsp_lbl = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Mod = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Del = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dgv_Datos = new System.Windows.Forms.DataGridView();
            this.btn_Process = new System.Windows.Forms.Button();
            this.ptb_Fotografia = new System.Windows.Forms.PictureBox();
            this.txtb_QtyPalcos = new System.Windows.Forms.TextBox();
            this.txtb_QtyPlatas = new System.Windows.Forms.TextBox();
            this.txtb_QtyVIP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvder1)).BeginInit();
            this.pnl_Precios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tst_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Fotografia)).BeginInit();
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
            // pnl_Precios
            // 
            this.pnl_Precios.BackColor = System.Drawing.Color.Silver;
            this.pnl_Precios.Controls.Add(this.txtb_QtyVIP);
            this.pnl_Precios.Controls.Add(this.txtb_QtyPlatas);
            this.pnl_Precios.Controls.Add(this.txtb_QtyPalcos);
            this.pnl_Precios.Controls.Add(this.lbl_Ttl_Prices);
            this.pnl_Precios.Controls.Add(this.txb_CostoVIP);
            this.pnl_Precios.Controls.Add(this.lbl_Add_CostoPalco);
            this.pnl_Precios.Controls.Add(this.txb_CostoPlata);
            this.pnl_Precios.Controls.Add(this.txb_CostoPalcos);
            this.pnl_Precios.Controls.Add(this.lbl_Add_CostoVIP);
            this.pnl_Precios.Controls.Add(this.lbl_Add_CostoPlata);
            this.pnl_Precios.Location = new System.Drawing.Point(29, 219);
            this.pnl_Precios.Name = "pnl_Precios";
            this.pnl_Precios.Size = new System.Drawing.Size(314, 126);
            this.pnl_Precios.TabIndex = 29;
            // 
            // lbl_Ttl_Prices
            // 
            this.lbl_Ttl_Prices.AutoSize = true;
            this.lbl_Ttl_Prices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ttl_Prices.Location = new System.Drawing.Point(45, 13);
            this.lbl_Ttl_Prices.Name = "lbl_Ttl_Prices";
            this.lbl_Ttl_Prices.Size = new System.Drawing.Size(227, 18);
            this.lbl_Ttl_Prices.TabIndex = 29;
            this.lbl_Ttl_Prices.Text = "Precios y cantidades por seccion";
            // 
            // txb_CostoVIP
            // 
            this.txb_CostoVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CostoVIP.Location = new System.Drawing.Point(100, 89);
            this.txb_CostoVIP.Name = "txb_CostoVIP";
            this.txb_CostoVIP.Size = new System.Drawing.Size(105, 24);
            this.txb_CostoVIP.TabIndex = 28;
            // 
            // lbl_Add_CostoPalco
            // 
            this.lbl_Add_CostoPalco.AutoSize = true;
            this.lbl_Add_CostoPalco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_CostoPalco.Location = new System.Drawing.Point(22, 44);
            this.lbl_Add_CostoPalco.Name = "lbl_Add_CostoPalco";
            this.lbl_Add_CostoPalco.Size = new System.Drawing.Size(54, 18);
            this.lbl_Add_CostoPalco.TabIndex = 22;
            this.lbl_Add_CostoPalco.Text = "Palcos";
            // 
            // txb_CostoPlata
            // 
            this.txb_CostoPlata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CostoPlata.Location = new System.Drawing.Point(100, 60);
            this.txb_CostoPlata.Name = "txb_CostoPlata";
            this.txb_CostoPlata.Size = new System.Drawing.Size(105, 24);
            this.txb_CostoPlata.TabIndex = 27;
            // 
            // txb_CostoPalcos
            // 
            this.txb_CostoPalcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CostoPalcos.Location = new System.Drawing.Point(100, 34);
            this.txb_CostoPalcos.Name = "txb_CostoPalcos";
            this.txb_CostoPalcos.Size = new System.Drawing.Size(105, 24);
            this.txb_CostoPalcos.TabIndex = 23;
            // 
            // lbl_Add_CostoVIP
            // 
            this.lbl_Add_CostoVIP.AutoSize = true;
            this.lbl_Add_CostoVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_CostoVIP.Location = new System.Drawing.Point(22, 92);
            this.lbl_Add_CostoVIP.Name = "lbl_Add_CostoVIP";
            this.lbl_Add_CostoVIP.Size = new System.Drawing.Size(38, 18);
            this.lbl_Add_CostoVIP.TabIndex = 26;
            this.lbl_Add_CostoVIP.Text = "V.I.P";
            // 
            // lbl_Add_CostoPlata
            // 
            this.lbl_Add_CostoPlata.AutoSize = true;
            this.lbl_Add_CostoPlata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_CostoPlata.Location = new System.Drawing.Point(22, 70);
            this.lbl_Add_CostoPlata.Name = "lbl_Add_CostoPlata";
            this.lbl_Add_CostoPlata.Size = new System.Drawing.Size(49, 18);
            this.lbl_Add_CostoPlata.TabIndex = 24;
            this.lbl_Add_CostoPlata.Text = "Platas";
            // 
            // cbo_LugarEvento
            // 
            this.cbo_LugarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_LugarEvento.FormattingEnabled = true;
            this.cbo_LugarEvento.Location = new System.Drawing.Point(129, 160);
            this.cbo_LugarEvento.Name = "cbo_LugarEvento";
            this.cbo_LugarEvento.Size = new System.Drawing.Size(210, 26);
            this.cbo_LugarEvento.TabIndex = 21;
            this.cbo_LugarEvento.SelectionChangeCommitted += new System.EventHandler(this.cbo_LugarEvento_SelectionChangeCommitted);
            // 
            // cbo_Estado
            // 
            this.cbo_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Estado.FormattingEnabled = true;
            this.cbo_Estado.Location = new System.Drawing.Point(129, 106);
            this.cbo_Estado.Name = "cbo_Estado";
            this.cbo_Estado.Size = new System.Drawing.Size(210, 26);
            this.cbo_Estado.TabIndex = 20;
            this.cbo_Estado.SelectedIndexChanged += new System.EventHandler(this.cbo_Estado_SelectedIndexChanged);
            // 
            // dtp_FechaEvento
            // 
            this.dtp_FechaEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaEvento.Location = new System.Drawing.Point(129, 133);
            this.dtp_FechaEvento.Name = "dtp_FechaEvento";
            this.dtp_FechaEvento.Size = new System.Drawing.Size(210, 24);
            this.dtp_FechaEvento.TabIndex = 19;
            this.dtp_FechaEvento.Value = new System.DateTime(2016, 11, 25, 0, 57, 25, 0);
            // 
            // cbo_TipoEvento
            // 
            this.cbo_TipoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TipoEvento.FormattingEnabled = true;
            this.cbo_TipoEvento.Location = new System.Drawing.Point(129, 79);
            this.cbo_TipoEvento.Name = "cbo_TipoEvento";
            this.cbo_TipoEvento.Size = new System.Drawing.Size(210, 26);
            this.cbo_TipoEvento.TabIndex = 18;
            // 
            // lbl_Add_TipoEvento
            // 
            this.lbl_Add_TipoEvento.AutoSize = true;
            this.lbl_Add_TipoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_TipoEvento.Location = new System.Drawing.Point(26, 87);
            this.lbl_Add_TipoEvento.Name = "lbl_Add_TipoEvento";
            this.lbl_Add_TipoEvento.Size = new System.Drawing.Size(87, 18);
            this.lbl_Add_TipoEvento.TabIndex = 16;
            this.lbl_Add_TipoEvento.Text = "Tipo Evento";
            // 
            // txb_CantEntradas
            // 
            this.txb_CantEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CantEntradas.Location = new System.Drawing.Point(129, 189);
            this.txb_CantEntradas.Name = "txb_CantEntradas";
            this.txb_CantEntradas.Size = new System.Drawing.Size(210, 24);
            this.txb_CantEntradas.TabIndex = 12;
            this.txb_CantEntradas.Text = "0";
            // 
            // txb_Descripcion
            // 
            this.txb_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Descripcion.Location = new System.Drawing.Point(129, 53);
            this.txb_Descripcion.Name = "txb_Descripcion";
            this.txb_Descripcion.Size = new System.Drawing.Size(210, 24);
            this.txb_Descripcion.TabIndex = 9;
            // 
            // txb_IdEvento
            // 
            this.txb_IdEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_IdEvento.Location = new System.Drawing.Point(129, 27);
            this.txb_IdEvento.Name = "txb_IdEvento";
            this.txb_IdEvento.Size = new System.Drawing.Size(210, 24);
            this.txb_IdEvento.TabIndex = 8;
            // 
            // lbl_Add_Logo
            // 
            this.lbl_Add_Logo.AutoSize = true;
            this.lbl_Add_Logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Logo.Location = new System.Drawing.Point(26, 351);
            this.lbl_Add_Logo.Name = "lbl_Add_Logo";
            this.lbl_Add_Logo.Size = new System.Drawing.Size(75, 18);
            this.lbl_Add_Logo.TabIndex = 6;
            this.lbl_Add_Logo.Text = "Fotografia";
            // 
            // lbl_Add_Identf
            // 
            this.lbl_Add_Identf.AutoSize = true;
            this.lbl_Add_Identf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Identf.Location = new System.Drawing.Point(26, 34);
            this.lbl_Add_Identf.Name = "lbl_Add_Identf";
            this.lbl_Add_Identf.Size = new System.Drawing.Size(93, 18);
            this.lbl_Add_Identf.TabIndex = 5;
            this.lbl_Add_Identf.Text = "Identificacion";
            // 
            // lbl_Add_CantEntradas
            // 
            this.lbl_Add_CantEntradas.AutoSize = true;
            this.lbl_Add_CantEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_CantEntradas.Location = new System.Drawing.Point(26, 195);
            this.lbl_Add_CantEntradas.Name = "lbl_Add_CantEntradas";
            this.lbl_Add_CantEntradas.Size = new System.Drawing.Size(67, 18);
            this.lbl_Add_CantEntradas.TabIndex = 4;
            this.lbl_Add_CantEntradas.Text = "Entradas";
            // 
            // lbl_Add_LugarEvento
            // 
            this.lbl_Add_LugarEvento.AutoSize = true;
            this.lbl_Add_LugarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_LugarEvento.Location = new System.Drawing.Point(26, 168);
            this.lbl_Add_LugarEvento.Name = "lbl_Add_LugarEvento";
            this.lbl_Add_LugarEvento.Size = new System.Drawing.Size(95, 18);
            this.lbl_Add_LugarEvento.TabIndex = 3;
            this.lbl_Add_LugarEvento.Text = "Lugar Evento";
            this.lbl_Add_LugarEvento.Click += new System.EventHandler(this.lbl_Correo_Click);
            // 
            // lbl_Add_Estado
            // 
            this.lbl_Add_Estado.AutoSize = true;
            this.lbl_Add_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Estado.Location = new System.Drawing.Point(26, 114);
            this.lbl_Add_Estado.Name = "lbl_Add_Estado";
            this.lbl_Add_Estado.Size = new System.Drawing.Size(105, 18);
            this.lbl_Add_Estado.TabIndex = 2;
            this.lbl_Add_Estado.Text = "Estado Evento";
            // 
            // lbl_Add_Fecha
            // 
            this.lbl_Add_Fecha.AutoSize = true;
            this.lbl_Add_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Fecha.Location = new System.Drawing.Point(26, 140);
            this.lbl_Add_Fecha.Name = "lbl_Add_Fecha";
            this.lbl_Add_Fecha.Size = new System.Drawing.Size(49, 18);
            this.lbl_Add_Fecha.TabIndex = 1;
            this.lbl_Add_Fecha.Text = "Fecha";
            // 
            // lbl_Add_Descripcion
            // 
            this.lbl_Add_Descripcion.AutoSize = true;
            this.lbl_Add_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Descripcion.Location = new System.Drawing.Point(26, 60);
            this.lbl_Add_Descripcion.Name = "lbl_Add_Descripcion";
            this.lbl_Add_Descripcion.Size = new System.Drawing.Size(87, 18);
            this.lbl_Add_Descripcion.TabIndex = 0;
            this.lbl_Add_Descripcion.Text = "Descripcion";
            // 
            // opF_Fotografia
            // 
            this.opF_Fotografia.FileName = "openFileDialog1";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(334, 59);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(358, 31);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Mantenimiento de Eventos";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 140);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tst_Menu);
            this.splitContainer1.Panel1.Controls.Add(this.dgv_Datos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_Process);
            this.splitContainer1.Panel2.Controls.Add(this.ptb_Fotografia);
            this.splitContainer1.Panel2.Controls.Add(this.pnl_Precios);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Add_LugarEvento);
            this.splitContainer1.Panel2.Controls.Add(this.dtp_FechaEvento);
            this.splitContainer1.Panel2.Controls.Add(this.cbo_LugarEvento);
            this.splitContainer1.Panel2.Controls.Add(this.cbo_TipoEvento);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Add_Descripcion);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Add_TipoEvento);
            this.splitContainer1.Panel2.Controls.Add(this.cbo_Estado);
            this.splitContainer1.Panel2.Controls.Add(this.txb_CantEntradas);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Add_Estado);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Add_Identf);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Add_Logo);
            this.splitContainer1.Panel2.Controls.Add(this.txb_IdEvento);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Add_CantEntradas);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Add_Fecha);
            this.splitContainer1.Panel2.Controls.Add(this.txb_Descripcion);
            this.splitContainer1.Size = new System.Drawing.Size(1135, 625);
            this.splitContainer1.SplitterDistance = 741;
            this.splitContainer1.TabIndex = 30;
            // 
            // tst_Menu
            // 
            this.tst_Menu.BackColor = System.Drawing.Color.Transparent;
            this.tst_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Add,
            this.tsp_lbl,
            this.toolStripSeparator1,
            this.btn_Mod,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.btn_Del,
            this.toolStripLabel2});
            this.tst_Menu.Location = new System.Drawing.Point(0, 0);
            this.tst_Menu.Name = "tst_Menu";
            this.tst_Menu.Size = new System.Drawing.Size(741, 71);
            this.tst_Menu.TabIndex = 6;
            this.tst_Menu.Text = "toolStrip1";
            // 
            // btn_Add
            // 
            this.btn_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Image = global::prjPrograIII.Properties.Resources.add;
            this.btn_Add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(68, 68);
            this.btn_Add.Text = "AgregarCliente";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tsp_lbl
            // 
            this.tsp_lbl.Name = "tsp_lbl";
            this.tsp_lbl.Size = new System.Drawing.Size(49, 68);
            this.tsp_lbl.Text = "Agregar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // btn_Mod
            // 
            this.btn_Mod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Mod.Image = global::prjPrograIII.Properties.Resources.edit;
            this.btn_Mod.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Mod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Mod.Name = "btn_Mod";
            this.btn_Mod.Size = new System.Drawing.Size(68, 68);
            this.btn_Mod.Text = "Modificar Cliente";
            this.btn_Mod.Click += new System.EventHandler(this.btn_Mod_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 68);
            this.toolStripLabel1.Text = "Modificar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 71);
            // 
            // btn_Del
            // 
            this.btn_Del.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Del.Image = global::prjPrograIII.Properties.Resources.delete;
            this.btn_Del.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(68, 68);
            this.btn_Del.Text = "Eliminar Cliente";
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(50, 68);
            this.toolStripLabel2.Text = "Eliminar";
            // 
            // dgv_Datos
            // 
            this.dgv_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Datos.Location = new System.Drawing.Point(-5, 74);
            this.dgv_Datos.Name = "dgv_Datos";
            this.dgv_Datos.Size = new System.Drawing.Size(743, 552);
            this.dgv_Datos.TabIndex = 5;
            // 
            // btn_Process
            // 
            this.btn_Process.Image = global::prjPrograIII.Properties.Resources._checked;
            this.btn_Process.Location = new System.Drawing.Point(199, 533);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(188, 89);
            this.btn_Process.TabIndex = 7;
            this.btn_Process.UseVisualStyleBackColor = true;
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // ptb_Fotografia
            // 
            this.ptb_Fotografia.Location = new System.Drawing.Point(129, 351);
            this.ptb_Fotografia.Name = "ptb_Fotografia";
            this.ptb_Fotografia.Size = new System.Drawing.Size(210, 176);
            this.ptb_Fotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Fotografia.TabIndex = 30;
            this.ptb_Fotografia.TabStop = false;
            this.ptb_Fotografia.Click += new System.EventHandler(this.ptb_Fotografia_Click);
            // 
            // txtb_QtyPalcos
            // 
            this.txtb_QtyPalcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_QtyPalcos.Location = new System.Drawing.Point(209, 34);
            this.txtb_QtyPalcos.Name = "txtb_QtyPalcos";
            this.txtb_QtyPalcos.Size = new System.Drawing.Size(101, 24);
            this.txtb_QtyPalcos.TabIndex = 30;
            // 
            // txtb_QtyPlatas
            // 
            this.txtb_QtyPlatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_QtyPlatas.Location = new System.Drawing.Point(209, 60);
            this.txtb_QtyPlatas.Name = "txtb_QtyPlatas";
            this.txtb_QtyPlatas.Size = new System.Drawing.Size(101, 24);
            this.txtb_QtyPlatas.TabIndex = 31;
            // 
            // txtb_QtyVIP
            // 
            this.txtb_QtyVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_QtyVIP.Location = new System.Drawing.Point(209, 89);
            this.txtb_QtyVIP.Name = "txtb_QtyVIP";
            this.txtb_QtyVIP.Size = new System.Drawing.Size(101, 24);
            this.txtb_QtyVIP.TabIndex = 32;
            // 
            // frmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1159, 777);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy-Ticket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.errPrvder1)).EndInit();
            this.pnl_Precios.ResumeLayout(false);
            this.pnl_Precios.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tst_Menu.ResumeLayout(false);
            this.tst_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Fotografia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errPrvder1;
        private System.Windows.Forms.TextBox txb_IdEvento;
        private System.Windows.Forms.Label lbl_Add_Logo;
        private System.Windows.Forms.Label lbl_Add_Identf;
        private System.Windows.Forms.Label lbl_Add_CantEntradas;
        private System.Windows.Forms.Label lbl_Add_LugarEvento;
        private System.Windows.Forms.Label lbl_Add_Estado;
        private System.Windows.Forms.Label lbl_Add_Fecha;
        private System.Windows.Forms.TextBox txb_CantEntradas;
        private System.Windows.Forms.OpenFileDialog opF_Fotografia;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ComboBox cbo_TipoEvento;
        private System.Windows.Forms.Label lbl_Add_TipoEvento;
        private System.Windows.Forms.TextBox txb_Descripcion;
        private System.Windows.Forms.Label lbl_Add_Descripcion;
        private System.Windows.Forms.DateTimePicker dtp_FechaEvento;
        private System.Windows.Forms.ComboBox cbo_Estado;
        private System.Windows.Forms.Panel pnl_Precios;
        private System.Windows.Forms.Label lbl_Ttl_Prices;
        private System.Windows.Forms.TextBox txb_CostoVIP;
        private System.Windows.Forms.Label lbl_Add_CostoPalco;
        private System.Windows.Forms.TextBox txb_CostoPlata;
        private System.Windows.Forms.TextBox txb_CostoPalcos;
        private System.Windows.Forms.Label lbl_Add_CostoVIP;
        private System.Windows.Forms.Label lbl_Add_CostoPlata;
        private System.Windows.Forms.ComboBox cbo_LugarEvento;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Process;
        private System.Windows.Forms.PictureBox ptb_Fotografia;
        private System.Windows.Forms.ToolStrip tst_Menu;
        private System.Windows.Forms.ToolStripButton btn_Add;
        private System.Windows.Forms.ToolStripLabel tsp_lbl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Mod;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Del;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridView dgv_Datos;
        private System.Windows.Forms.TextBox txtb_QtyVIP;
        private System.Windows.Forms.TextBox txtb_QtyPlatas;
        private System.Windows.Forms.TextBox txtb_QtyPalcos;
    }
}

