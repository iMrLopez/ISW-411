namespace prjPrograIII
{
    partial class frmLocalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalidad));
            this.errPrvder1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_Add_Process = new System.Windows.Forms.Button();
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
            this.ptb_Fotografia = new System.Windows.Forms.PictureBox();
            this.txb_Add_Vip = new System.Windows.Forms.TextBox();
            this.txtb_Add_Capacidad = new System.Windows.Forms.TextBox();
            this.lbl_Foto = new System.Windows.Forms.Label();
            this.lbl_Add_Vip = new System.Windows.Forms.Label();
            this.lbl_Add_Capacidad = new System.Windows.Forms.Label();
            this.txtb_Add_Plata = new System.Windows.Forms.TextBox();
            this.txtb_Add_Palco = new System.Windows.Forms.TextBox();
            this.txtb_Add_Name = new System.Windows.Forms.TextBox();
            this.txtb_Add_Identif = new System.Windows.Forms.TextBox();
            this.lbl_Cedula = new System.Windows.Forms.Label();
            this.lbl_Add_Plata = new System.Windows.Forms.Label();
            this.lbl_Add_Palco = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.pnl_Sum = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tst_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Fotografia)).BeginInit();
            this.pnl_Sum.SuspendLayout();
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
            // btn_Add_Process
            // 
            this.btn_Add_Process.Image = global::prjPrograIII.Properties.Resources._checked;
            this.btn_Add_Process.Location = new System.Drawing.Point(240, 518);
            this.btn_Add_Process.Name = "btn_Add_Process";
            this.btn_Add_Process.Size = new System.Drawing.Size(188, 97);
            this.btn_Add_Process.TabIndex = 7;
            this.btn_Add_Process.UseVisualStyleBackColor = true;
            this.btn_Add_Process.Click += new System.EventHandler(this.btn_Add_Process_Click);
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
            this.lbl_Title.Size = new System.Drawing.Size(408, 31);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Mantenimiento de Localidades";
            this.lbl_Title.Click += new System.EventHandler(this.lbl_Title_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(23, 126);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tst_Menu);
            this.splitContainer1.Panel1.Controls.Add(this.dgv_Datos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ptb_Fotografia);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Add_Process);
            this.splitContainer1.Panel2.Controls.Add(this.txb_Add_Vip);
            this.splitContainer1.Panel2.Controls.Add(this.txtb_Add_Capacidad);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Foto);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Add_Vip);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Add_Capacidad);
            this.splitContainer1.Panel2.Controls.Add(this.txtb_Add_Plata);
            this.splitContainer1.Panel2.Controls.Add(this.txtb_Add_Palco);
            this.splitContainer1.Panel2.Controls.Add(this.txtb_Add_Name);
            this.splitContainer1.Panel2.Controls.Add(this.txtb_Add_Identif);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Cedula);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_Name);
            this.splitContainer1.Panel2.Controls.Add(this.pnl_Sum);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(1124, 629);
            this.splitContainer1.SplitterDistance = 663;
            this.splitContainer1.TabIndex = 4;
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
            this.tst_Menu.Size = new System.Drawing.Size(663, 71);
            this.tst_Menu.TabIndex = 4;
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
            this.btn_Mod.Click += new System.EventHandler(this.btn_Mod_Click_1);
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
            this.dgv_Datos.Location = new System.Drawing.Point(-9, 66);
            this.dgv_Datos.Name = "dgv_Datos";
            this.dgv_Datos.Size = new System.Drawing.Size(680, 562);
            this.dgv_Datos.TabIndex = 3;
            // 
            // ptb_Fotografia
            // 
            this.ptb_Fotografia.Location = new System.Drawing.Point(143, 310);
            this.ptb_Fotografia.Name = "ptb_Fotografia";
            this.ptb_Fotografia.Size = new System.Drawing.Size(183, 186);
            this.ptb_Fotografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Fotografia.TabIndex = 27;
            this.ptb_Fotografia.TabStop = false;
            this.ptb_Fotografia.Click += new System.EventHandler(this.ptb_Fotografia_Click);
            // 
            // txb_Add_Vip
            // 
            this.txb_Add_Vip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Add_Vip.Location = new System.Drawing.Point(143, 267);
            this.txb_Add_Vip.Name = "txb_Add_Vip";
            this.txb_Add_Vip.Size = new System.Drawing.Size(296, 29);
            this.txb_Add_Vip.TabIndex = 26;
            this.txb_Add_Vip.Text = "0";
            // 
            // txtb_Add_Capacidad
            // 
            this.txtb_Add_Capacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Add_Capacidad.Location = new System.Drawing.Point(143, 154);
            this.txtb_Add_Capacidad.Name = "txtb_Add_Capacidad";
            this.txtb_Add_Capacidad.Size = new System.Drawing.Size(296, 29);
            this.txtb_Add_Capacidad.TabIndex = 25;
            this.txtb_Add_Capacidad.Text = "0";
            // 
            // lbl_Foto
            // 
            this.lbl_Foto.AutoSize = true;
            this.lbl_Foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Foto.Location = new System.Drawing.Point(37, 308);
            this.lbl_Foto.Name = "lbl_Foto";
            this.lbl_Foto.Size = new System.Drawing.Size(93, 24);
            this.lbl_Foto.TabIndex = 24;
            this.lbl_Foto.Text = "Fotografia";
            // 
            // lbl_Add_Vip
            // 
            this.lbl_Add_Vip.AutoSize = true;
            this.lbl_Add_Vip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Vip.Location = new System.Drawing.Point(61, 272);
            this.lbl_Add_Vip.Name = "lbl_Add_Vip";
            this.lbl_Add_Vip.Size = new System.Drawing.Size(49, 24);
            this.lbl_Add_Vip.TabIndex = 23;
            this.lbl_Add_Vip.Text = "V.I.P";
            // 
            // lbl_Add_Capacidad
            // 
            this.lbl_Add_Capacidad.AutoSize = true;
            this.lbl_Add_Capacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Capacidad.Location = new System.Drawing.Point(33, 159);
            this.lbl_Add_Capacidad.Name = "lbl_Add_Capacidad";
            this.lbl_Add_Capacidad.Size = new System.Drawing.Size(100, 24);
            this.lbl_Add_Capacidad.TabIndex = 22;
            this.lbl_Add_Capacidad.Text = "Capacidad";
            // 
            // txtb_Add_Plata
            // 
            this.txtb_Add_Plata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Add_Plata.Location = new System.Drawing.Point(143, 231);
            this.txtb_Add_Plata.Name = "txtb_Add_Plata";
            this.txtb_Add_Plata.Size = new System.Drawing.Size(296, 29);
            this.txtb_Add_Plata.TabIndex = 21;
            this.txtb_Add_Plata.Text = "0";
            // 
            // txtb_Add_Palco
            // 
            this.txtb_Add_Palco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Add_Palco.Location = new System.Drawing.Point(143, 196);
            this.txtb_Add_Palco.Name = "txtb_Add_Palco";
            this.txtb_Add_Palco.Size = new System.Drawing.Size(296, 29);
            this.txtb_Add_Palco.TabIndex = 20;
            this.txtb_Add_Palco.Text = "0";
            // 
            // txtb_Add_Name
            // 
            this.txtb_Add_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Add_Name.Location = new System.Drawing.Point(143, 115);
            this.txtb_Add_Name.Name = "txtb_Add_Name";
            this.txtb_Add_Name.Size = new System.Drawing.Size(296, 29);
            this.txtb_Add_Name.TabIndex = 19;
            // 
            // txtb_Add_Identif
            // 
            this.txtb_Add_Identif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Add_Identif.Location = new System.Drawing.Point(143, 69);
            this.txtb_Add_Identif.Name = "txtb_Add_Identif";
            this.txtb_Add_Identif.Size = new System.Drawing.Size(296, 29);
            this.txtb_Add_Identif.TabIndex = 18;
            // 
            // lbl_Cedula
            // 
            this.lbl_Cedula.AutoSize = true;
            this.lbl_Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cedula.Location = new System.Drawing.Point(21, 74);
            this.lbl_Cedula.Name = "lbl_Cedula";
            this.lbl_Cedula.Size = new System.Drawing.Size(119, 24);
            this.lbl_Cedula.TabIndex = 17;
            this.lbl_Cedula.Text = "Identificacion";
            // 
            // lbl_Add_Plata
            // 
            this.lbl_Add_Plata.AutoSize = true;
            this.lbl_Add_Plata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Plata.Location = new System.Drawing.Point(21, 42);
            this.lbl_Add_Plata.Name = "lbl_Add_Plata";
            this.lbl_Add_Plata.Size = new System.Drawing.Size(50, 24);
            this.lbl_Add_Plata.TabIndex = 16;
            this.lbl_Add_Plata.Text = "Plata";
            // 
            // lbl_Add_Palco
            // 
            this.lbl_Add_Palco.AutoSize = true;
            this.lbl_Add_Palco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Palco.Location = new System.Drawing.Point(18, 7);
            this.lbl_Add_Palco.Name = "lbl_Add_Palco";
            this.lbl_Add_Palco.Size = new System.Drawing.Size(57, 24);
            this.lbl_Add_Palco.TabIndex = 15;
            this.lbl_Add_Palco.Text = "Palco";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(47, 116);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(79, 24);
            this.lbl_Name.TabIndex = 14;
            this.lbl_Name.Text = "Nombre";
            // 
            // pnl_Sum
            // 
            this.pnl_Sum.Controls.Add(this.lbl_Add_Plata);
            this.pnl_Sum.Controls.Add(this.lbl_Add_Palco);
            this.pnl_Sum.Location = new System.Drawing.Point(40, 195);
            this.pnl_Sum.Name = "pnl_Sum";
            this.pnl_Sum.Size = new System.Drawing.Size(399, 101);
            this.pnl_Sum.TabIndex = 28;
            // 
            // frmLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1159, 777);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLocalidad";
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
            this.tst_Menu.ResumeLayout(false);
            this.tst_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Fotografia)).EndInit();
            this.pnl_Sum.ResumeLayout(false);
            this.pnl_Sum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errPrvder1;
        private System.Windows.Forms.Button btn_Add_Process;
        private System.Windows.Forms.OpenFileDialog opF_Fotografia;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txb_Add_Vip;
        private System.Windows.Forms.TextBox txtb_Add_Capacidad;
        private System.Windows.Forms.Label lbl_Foto;
        private System.Windows.Forms.Label lbl_Add_Vip;
        private System.Windows.Forms.Label lbl_Add_Capacidad;
        private System.Windows.Forms.TextBox txtb_Add_Plata;
        private System.Windows.Forms.TextBox txtb_Add_Palco;
        private System.Windows.Forms.TextBox txtb_Add_Name;
        private System.Windows.Forms.TextBox txtb_Add_Identif;
        private System.Windows.Forms.Label lbl_Cedula;
        private System.Windows.Forms.Label lbl_Add_Plata;
        private System.Windows.Forms.Label lbl_Add_Palco;
        private System.Windows.Forms.Label lbl_Name;
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
        private System.Windows.Forms.PictureBox ptb_Fotografia;
        private System.Windows.Forms.Panel pnl_Sum;
    }
}

