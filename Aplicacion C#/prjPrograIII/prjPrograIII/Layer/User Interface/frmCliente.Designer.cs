namespace prjPrograIII
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.errPrvder1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.opF_Fotografia = new System.Windows.Forms.OpenFileDialog();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.spc_Clientes = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Add = new System.Windows.Forms.ToolStripButton();
            this.tsp_lbl = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Mod = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Del = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dgv_Datos = new System.Windows.Forms.DataGridView();
            this.cbo_Nacionalidad = new System.Windows.Forms.ComboBox();
            this.lbl_Nacionalidad = new System.Windows.Forms.Label();
            this.dtp_FechaNac = new System.Windows.Forms.DateTimePicker();
            this.lbl_Add_Cedula = new System.Windows.Forms.Label();
            this.cbo_Sexo = new System.Windows.Forms.ComboBox();
            this.lbl_Add_Name = new System.Windows.Forms.Label();
            this.txtb_Direccion = new System.Windows.Forms.TextBox();
            this.lbl_Add_FNacim = new System.Windows.Forms.Label();
            this.txtb_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Add_Sexo = new System.Windows.Forms.Label();
            this.txb_Cedula = new System.Windows.Forms.TextBox();
            this.lbl_Add_Email = new System.Windows.Forms.Label();
            this.btn_Procesar = new System.Windows.Forms.Button();
            this.spc_FlowContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Clientes)).BeginInit();
            this.spc_Clientes.Panel1.SuspendLayout();
            this.spc_Clientes.Panel2.SuspendLayout();
            this.spc_Clientes.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spc_FlowContainer)).BeginInit();
            this.spc_FlowContainer.Panel2.SuspendLayout();
            this.spc_FlowContainer.SuspendLayout();
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
            // opF_Fotografia
            // 
            this.opF_Fotografia.FileName = "openFileDialog1";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(355, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(359, 31);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Mantenimiento de Clientes";
            // 
            // spc_Clientes
            // 
            this.spc_Clientes.BackColor = System.Drawing.Color.Transparent;
            this.spc_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_Clientes.Location = new System.Drawing.Point(0, 0);
            this.spc_Clientes.Name = "spc_Clientes";
            // 
            // spc_Clientes.Panel1
            // 
            this.spc_Clientes.Panel1.Controls.Add(this.toolStrip1);
            this.spc_Clientes.Panel1.Controls.Add(this.dgv_Datos);
            // 
            // spc_Clientes.Panel2
            // 
            this.spc_Clientes.Panel2.Controls.Add(this.cbo_Nacionalidad);
            this.spc_Clientes.Panel2.Controls.Add(this.lbl_Nacionalidad);
            this.spc_Clientes.Panel2.Controls.Add(this.dtp_FechaNac);
            this.spc_Clientes.Panel2.Controls.Add(this.lbl_Add_Cedula);
            this.spc_Clientes.Panel2.Controls.Add(this.cbo_Sexo);
            this.spc_Clientes.Panel2.Controls.Add(this.lbl_Add_Name);
            this.spc_Clientes.Panel2.Controls.Add(this.txtb_Direccion);
            this.spc_Clientes.Panel2.Controls.Add(this.lbl_Add_FNacim);
            this.spc_Clientes.Panel2.Controls.Add(this.txtb_Nombre);
            this.spc_Clientes.Panel2.Controls.Add(this.lbl_Add_Sexo);
            this.spc_Clientes.Panel2.Controls.Add(this.txb_Cedula);
            this.spc_Clientes.Panel2.Controls.Add(this.lbl_Add_Email);
            this.spc_Clientes.Panel2.Controls.Add(this.btn_Procesar);
            this.spc_Clientes.Size = new System.Drawing.Size(1159, 673);
            this.spc_Clientes.SplitterDistance = 563;
            this.spc_Clientes.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Add,
            this.tsp_lbl,
            this.toolStripSeparator1,
            this.btn_Mod,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.btn_Del,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(563, 71);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
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
            this.dgv_Datos.AllowUserToAddRows = false;
            this.dgv_Datos.AllowUserToDeleteRows = false;
            this.dgv_Datos.AllowUserToOrderColumns = true;
            this.dgv_Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Datos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Datos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Datos.Location = new System.Drawing.Point(0, 74);
            this.dgv_Datos.Name = "dgv_Datos";
            this.dgv_Datos.Size = new System.Drawing.Size(563, 599);
            this.dgv_Datos.TabIndex = 0;
            this.dgv_Datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Datos_CellContentClick);
            // 
            // cbo_Nacionalidad
            // 
            this.cbo_Nacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Nacionalidad.FormattingEnabled = true;
            this.cbo_Nacionalidad.Location = new System.Drawing.Point(159, 337);
            this.cbo_Nacionalidad.Name = "cbo_Nacionalidad";
            this.cbo_Nacionalidad.Size = new System.Drawing.Size(350, 32);
            this.cbo_Nacionalidad.TabIndex = 30;
            // 
            // lbl_Nacionalidad
            // 
            this.lbl_Nacionalidad.AutoSize = true;
            this.lbl_Nacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nacionalidad.Location = new System.Drawing.Point(15, 345);
            this.lbl_Nacionalidad.Name = "lbl_Nacionalidad";
            this.lbl_Nacionalidad.Size = new System.Drawing.Size(120, 24);
            this.lbl_Nacionalidad.TabIndex = 29;
            this.lbl_Nacionalidad.Text = "Nacionalidad";
            // 
            // dtp_FechaNac
            // 
            this.dtp_FechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaNac.Location = new System.Drawing.Point(159, 204);
            this.dtp_FechaNac.Name = "dtp_FechaNac";
            this.dtp_FechaNac.Size = new System.Drawing.Size(350, 29);
            this.dtp_FechaNac.TabIndex = 28;
            // 
            // lbl_Add_Cedula
            // 
            this.lbl_Add_Cedula.AutoSize = true;
            this.lbl_Add_Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Cedula.Location = new System.Drawing.Point(15, 34);
            this.lbl_Add_Cedula.Name = "lbl_Add_Cedula";
            this.lbl_Add_Cedula.Size = new System.Drawing.Size(119, 24);
            this.lbl_Add_Cedula.TabIndex = 22;
            this.lbl_Add_Cedula.Text = "Identificacion";
            // 
            // cbo_Sexo
            // 
            this.cbo_Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Sexo.FormattingEnabled = true;
            this.cbo_Sexo.Location = new System.Drawing.Point(159, 147);
            this.cbo_Sexo.Name = "cbo_Sexo";
            this.cbo_Sexo.Size = new System.Drawing.Size(350, 32);
            this.cbo_Sexo.TabIndex = 27;
            // 
            // lbl_Add_Name
            // 
            this.lbl_Add_Name.AutoSize = true;
            this.lbl_Add_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Name.Location = new System.Drawing.Point(15, 103);
            this.lbl_Add_Name.Name = "lbl_Add_Name";
            this.lbl_Add_Name.Size = new System.Drawing.Size(79, 24);
            this.lbl_Add_Name.TabIndex = 18;
            this.lbl_Add_Name.Text = "Nombre";
            // 
            // txtb_Direccion
            // 
            this.txtb_Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Direccion.Location = new System.Drawing.Point(159, 267);
            this.txtb_Direccion.Name = "txtb_Direccion";
            this.txtb_Direccion.Size = new System.Drawing.Size(350, 29);
            this.txtb_Direccion.TabIndex = 26;
            // 
            // lbl_Add_FNacim
            // 
            this.lbl_Add_FNacim.AutoSize = true;
            this.lbl_Add_FNacim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_FNacim.Location = new System.Drawing.Point(15, 210);
            this.lbl_Add_FNacim.Name = "lbl_Add_FNacim";
            this.lbl_Add_FNacim.Size = new System.Drawing.Size(103, 24);
            this.lbl_Add_FNacim.TabIndex = 19;
            this.lbl_Add_FNacim.Text = "Fecha Nac";
            // 
            // txtb_Nombre
            // 
            this.txtb_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Nombre.Location = new System.Drawing.Point(159, 97);
            this.txtb_Nombre.Name = "txtb_Nombre";
            this.txtb_Nombre.Size = new System.Drawing.Size(350, 29);
            this.txtb_Nombre.TabIndex = 25;
            // 
            // lbl_Add_Sexo
            // 
            this.lbl_Add_Sexo.AutoSize = true;
            this.lbl_Add_Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Sexo.Location = new System.Drawing.Point(15, 150);
            this.lbl_Add_Sexo.Name = "lbl_Add_Sexo";
            this.lbl_Add_Sexo.Size = new System.Drawing.Size(54, 24);
            this.lbl_Add_Sexo.TabIndex = 20;
            this.lbl_Add_Sexo.Text = "Sexo";
            // 
            // txb_Cedula
            // 
            this.txb_Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Cedula.Location = new System.Drawing.Point(159, 34);
            this.txb_Cedula.Name = "txb_Cedula";
            this.txb_Cedula.Size = new System.Drawing.Size(350, 29);
            this.txb_Cedula.TabIndex = 24;
            // 
            // lbl_Add_Email
            // 
            this.lbl_Add_Email.AutoSize = true;
            this.lbl_Add_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Email.Location = new System.Drawing.Point(15, 274);
            this.lbl_Add_Email.Name = "lbl_Add_Email";
            this.lbl_Add_Email.Size = new System.Drawing.Size(55, 24);
            this.lbl_Add_Email.TabIndex = 21;
            this.lbl_Add_Email.Text = "email";
            // 
            // btn_Procesar
            // 
            this.btn_Procesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Procesar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Procesar.Image")));
            this.btn_Procesar.Location = new System.Drawing.Point(159, 437);
            this.btn_Procesar.Name = "btn_Procesar";
            this.btn_Procesar.Size = new System.Drawing.Size(188, 84);
            this.btn_Procesar.TabIndex = 23;
            this.btn_Procesar.UseVisualStyleBackColor = true;
            this.btn_Procesar.Click += new System.EventHandler(this.btn_Procesar_Click);
            // 
            // spc_FlowContainer
            // 
            this.spc_FlowContainer.BackColor = System.Drawing.Color.Transparent;
            this.spc_FlowContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_FlowContainer.Location = new System.Drawing.Point(0, 0);
            this.spc_FlowContainer.Name = "spc_FlowContainer";
            this.spc_FlowContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc_FlowContainer.Panel2
            // 
            this.spc_FlowContainer.Panel2.Controls.Add(this.spc_Clientes);
            this.spc_FlowContainer.Size = new System.Drawing.Size(1159, 777);
            this.spc_FlowContainer.SplitterDistance = 100;
            this.spc_FlowContainer.TabIndex = 5;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1159, 777);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.spc_FlowContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy-Ticket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.errPrvder1)).EndInit();
            this.spc_Clientes.Panel1.ResumeLayout(false);
            this.spc_Clientes.Panel1.PerformLayout();
            this.spc_Clientes.Panel2.ResumeLayout(false);
            this.spc_Clientes.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Clientes)).EndInit();
            this.spc_Clientes.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).EndInit();
            this.spc_FlowContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc_FlowContainer)).EndInit();
            this.spc_FlowContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errPrvder1;
        private System.Windows.Forms.OpenFileDialog opF_Fotografia;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.SplitContainer spc_Clientes;
        private System.Windows.Forms.DateTimePicker dtp_FechaNac;
        private System.Windows.Forms.Label lbl_Add_Cedula;
        private System.Windows.Forms.ComboBox cbo_Sexo;
        private System.Windows.Forms.Label lbl_Add_Name;
        private System.Windows.Forms.TextBox txtb_Direccion;
        private System.Windows.Forms.Label lbl_Add_FNacim;
        private System.Windows.Forms.TextBox txtb_Nombre;
        private System.Windows.Forms.Label lbl_Add_Sexo;
        private System.Windows.Forms.TextBox txb_Cedula;
        private System.Windows.Forms.Label lbl_Add_Email;
        private System.Windows.Forms.Button btn_Procesar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Add;
        private System.Windows.Forms.ToolStripLabel tsp_lbl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Mod;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Del;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridView dgv_Datos;
        private System.Windows.Forms.ComboBox cbo_Nacionalidad;
        private System.Windows.Forms.Label lbl_Nacionalidad;
        private System.Windows.Forms.SplitContainer spc_FlowContainer;
    }
}

