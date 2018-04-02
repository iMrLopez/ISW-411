namespace prjPrograIII.Layer.User_Interface
{
    partial class frmValidarVenta
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
            this.btn_Ok = new System.Windows.Forms.Button();
            this.lbl_EstimadoCliente = new System.Windows.Forms.Label();
            this.lbl_FormaMasEfectiva = new System.Windows.Forms.Label();
            this.ptb_AppQR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_AppQR)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ok
            // 
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.Location = new System.Drawing.Point(244, 380);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(104, 51);
            this.btn_Ok.TabIndex = 0;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // lbl_EstimadoCliente
            // 
            this.lbl_EstimadoCliente.AutoSize = true;
            this.lbl_EstimadoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EstimadoCliente.Location = new System.Drawing.Point(195, 28);
            this.lbl_EstimadoCliente.Name = "lbl_EstimadoCliente";
            this.lbl_EstimadoCliente.Size = new System.Drawing.Size(219, 31);
            this.lbl_EstimadoCliente.TabIndex = 1;
            this.lbl_EstimadoCliente.Text = "Estimado Cliente";
            // 
            // lbl_FormaMasEfectiva
            // 
            this.lbl_FormaMasEfectiva.AutoSize = true;
            this.lbl_FormaMasEfectiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormaMasEfectiva.Location = new System.Drawing.Point(85, 336);
            this.lbl_FormaMasEfectiva.Name = "lbl_FormaMasEfectiva";
            this.lbl_FormaMasEfectiva.Size = new System.Drawing.Size(452, 31);
            this.lbl_FormaMasEfectiva.TabIndex = 2;
            this.lbl_FormaMasEfectiva.Text = "Valide su ticket con la aplicacion QR";
            // 
            // ptb_AppQR
            // 
            this.ptb_AppQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptb_AppQR.Image = global::prjPrograIII.Properties.Resources.vs_reader_qr;
            this.ptb_AppQR.Location = new System.Drawing.Point(64, 62);
            this.ptb_AppQR.Name = "ptb_AppQR";
            this.ptb_AppQR.Size = new System.Drawing.Size(506, 271);
            this.ptb_AppQR.TabIndex = 3;
            this.ptb_AppQR.TabStop = false;
            // 
            // frmValidarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 443);
            this.ControlBox = false;
            this.Controls.Add(this.ptb_AppQR);
            this.Controls.Add(this.lbl_FormaMasEfectiva);
            this.Controls.Add(this.lbl_EstimadoCliente);
            this.Controls.Add(this.btn_Ok);
            this.Name = "frmValidarVenta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso de Validacion de Venta";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ptb_AppQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lbl_EstimadoCliente;
        private System.Windows.Forms.Label lbl_FormaMasEfectiva;
        private System.Windows.Forms.PictureBox ptb_AppQR;
    }
}