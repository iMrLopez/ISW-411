namespace prjPrograIII
{
    partial class frmTipoEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoEvento));
            this.errPrvder1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.opF_Fotografia = new System.Windows.Forms.OpenFileDialog();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
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
            this.btn_Procesar = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txtb_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Cedula = new System.Windows.Forms.Label();
            this.txb_Cedula = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).BeginInit();
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
            this.lbl_Title.Location = new System.Drawing.Point(334, 59);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(478, 31);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Mantenimiento de Tipos de Eventos";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(27, 121);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.dgv_Datos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_Procesar);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Name);
            this.splitContainer1.Panel2.Controls.Add(this.txtb_Nombre);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Cedula);
            this.splitContainer1.Panel2.Controls.Add(this.txb_Cedula);
            this.splitContainer1.Size = new System.Drawing.Size(1120, 630);
            this.splitContainer1.SplitterDistance = 683;
            this.splitContainer1.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
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
            this.toolStrip1.Size = new System.Drawing.Size(683, 71);
            this.toolStrip1.TabIndex = 2;
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
            this.dgv_Datos.Location = new System.Drawing.Point(0, 65);
            this.dgv_Datos.Name = "dgv_Datos";
            this.dgv_Datos.Size = new System.Drawing.Size(680, 562);
            this.dgv_Datos.TabIndex = 0;
            // 
            // btn_Procesar
            // 
            this.btn_Procesar.Image = global::prjPrograIII.Properties.Resources._checked;
            this.btn_Procesar.Location = new System.Drawing.Point(232, 522);
            this.btn_Procesar.Name = "btn_Procesar";
            this.btn_Procesar.Size = new System.Drawing.Size(188, 89);
            this.btn_Procesar.TabIndex = 7;
            this.btn_Procesar.UseVisualStyleBackColor = true;
            this.btn_Procesar.Click += new System.EventHandler(this.btn_Procesar_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(161, 227);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(87, 25);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Nombre";
            // 
            // txtb_Nombre
            // 
            this.txtb_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Nombre.Location = new System.Drawing.Point(75, 255);
            this.txtb_Nombre.Name = "txtb_Nombre";
            this.txtb_Nombre.Size = new System.Drawing.Size(296, 31);
            this.txtb_Nombre.TabIndex = 9;
            // 
            // lbl_Cedula
            // 
            this.lbl_Cedula.AutoSize = true;
            this.lbl_Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cedula.Location = new System.Drawing.Point(134, 96);
            this.lbl_Cedula.Name = "lbl_Cedula";
            this.lbl_Cedula.Size = new System.Drawing.Size(138, 25);
            this.lbl_Cedula.TabIndex = 5;
            this.lbl_Cedula.Text = "Identificacion";
            // 
            // txb_Cedula
            // 
            this.txb_Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Cedula.Location = new System.Drawing.Point(75, 124);
            this.txb_Cedula.Name = "txb_Cedula";
            this.txb_Cedula.Size = new System.Drawing.Size(296, 31);
            this.txb_Cedula.TabIndex = 8;
            // 
            // frmTipoEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1159, 777);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTipoEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy-Ticket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.errPrvder1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errPrvder1;
        private System.Windows.Forms.OpenFileDialog opF_Fotografia;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.SplitContainer splitContainer1;
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
        private System.Windows.Forms.Button btn_Procesar;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txtb_Nombre;
        private System.Windows.Forms.Label lbl_Cedula;
        private System.Windows.Forms.TextBox txb_Cedula;
    }
}

