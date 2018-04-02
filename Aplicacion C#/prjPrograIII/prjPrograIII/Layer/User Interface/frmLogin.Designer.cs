namespace prjPrograIII
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnPrfrmLogin = new System.Windows.Forms.Button();
            this.gpbUpwd = new System.Windows.Forms.GroupBox();
            this.txbUpwd = new System.Windows.Forms.TextBox();
            this.gpbUname = new System.Windows.Forms.GroupBox();
            this.txbUname = new System.Windows.Forms.TextBox();
            this.errPrvder1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gpbUpwd.SuspendLayout();
            this.gpbUname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvder1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLogin.Controls.Add(this.pbLogo);
            this.pnlLogin.Controls.Add(this.btnPrfrmLogin);
            this.pnlLogin.Controls.Add(this.gpbUpwd);
            this.pnlLogin.Controls.Add(this.gpbUname);
            this.pnlLogin.Location = new System.Drawing.Point(422, 137);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(353, 545);
            this.pnlLogin.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::prjPrograIII.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(28, 15);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(303, 155);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // btnPrfrmLogin
            // 
            this.btnPrfrmLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrfrmLogin.Location = new System.Drawing.Point(117, 460);
            this.btnPrfrmLogin.Name = "btnPrfrmLogin";
            this.btnPrfrmLogin.Size = new System.Drawing.Size(128, 45);
            this.btnPrfrmLogin.TabIndex = 2;
            this.btnPrfrmLogin.Text = "Login";
            this.btnPrfrmLogin.UseVisualStyleBackColor = true;
            this.btnPrfrmLogin.Click += new System.EventHandler(this.btnPrfrmLogin_Click);
            // 
            // gpbUpwd
            // 
            this.gpbUpwd.Controls.Add(this.txbUpwd);
            this.gpbUpwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpbUpwd.Location = new System.Drawing.Point(28, 365);
            this.gpbUpwd.Name = "gpbUpwd";
            this.gpbUpwd.Size = new System.Drawing.Size(303, 89);
            this.gpbUpwd.TabIndex = 1;
            this.gpbUpwd.TabStop = false;
            this.gpbUpwd.Text = "User Password";
            // 
            // txbUpwd
            // 
            this.txbUpwd.Location = new System.Drawing.Point(22, 32);
            this.txbUpwd.Name = "txbUpwd";
            this.txbUpwd.Size = new System.Drawing.Size(257, 20);
            this.txbUpwd.TabIndex = 1;
            // 
            // gpbUname
            // 
            this.gpbUname.Controls.Add(this.txbUname);
            this.gpbUname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpbUname.Location = new System.Drawing.Point(28, 251);
            this.gpbUname.Name = "gpbUname";
            this.gpbUname.Size = new System.Drawing.Size(303, 89);
            this.gpbUname.TabIndex = 0;
            this.gpbUname.TabStop = false;
            this.gpbUname.Text = "User Name";
            // 
            // txbUname
            // 
            this.txbUname.Location = new System.Drawing.Point(22, 33);
            this.txbUname.Name = "txbUname";
            this.txbUname.Size = new System.Drawing.Size(257, 20);
            this.txbUname.TabIndex = 0;
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
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1159, 777);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy-Ticket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gpbUpwd.ResumeLayout(false);
            this.gpbUpwd.PerformLayout();
            this.gpbUname.ResumeLayout(false);
            this.gpbUname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPrvder1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnPrfrmLogin;
        private System.Windows.Forms.GroupBox gpbUpwd;
        private System.Windows.Forms.TextBox txbUpwd;
        private System.Windows.Forms.GroupBox gpbUname;
        private System.Windows.Forms.TextBox txbUname;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errPrvder1;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

