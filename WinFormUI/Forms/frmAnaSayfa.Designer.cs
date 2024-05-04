namespace WinFormUI
{
    partial class frmAnaSayfa
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
            this.frmAnaSayfaElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.frmAnaSayfaDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PnlAnaSayfa = new Guna.UI2.WinForms.Guna2Panel();
            this.PctrBxRapor = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PctrBxMuayeneEkrani = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PctrBxHastaCagirma = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PctrBxHastaKayit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PctrBxClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PnlAnaSayfa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxRapor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxMuayeneEkrani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxHastaCagirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxHastaKayit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // frmAnaSayfaDragControl
            // 
            this.frmAnaSayfaDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.frmAnaSayfaDragControl.UseTransparentDrag = true;
            // 
            // PnlAnaSayfa
            // 
            this.PnlAnaSayfa.Controls.Add(this.PctrBxRapor);
            this.PnlAnaSayfa.Controls.Add(this.PctrBxMuayeneEkrani);
            this.PnlAnaSayfa.Controls.Add(this.PctrBxHastaCagirma);
            this.PnlAnaSayfa.Controls.Add(this.PctrBxHastaKayit);
            this.PnlAnaSayfa.Controls.Add(this.PctrBxClose);
            this.PnlAnaSayfa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlAnaSayfa.Location = new System.Drawing.Point(0, 0);
            this.PnlAnaSayfa.Name = "PnlAnaSayfa";
            this.PnlAnaSayfa.Size = new System.Drawing.Size(1182, 560);
            this.PnlAnaSayfa.TabIndex = 0;
            // 
            // PctrBxRapor
            // 
            this.PctrBxRapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PctrBxRapor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PctrBxRapor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PctrBxRapor.Image = global::WinFormUI.Properties.Resources.pngrapor;
            this.PctrBxRapor.ImageRotate = 0F;
            this.PctrBxRapor.Location = new System.Drawing.Point(661, 291);
            this.PctrBxRapor.Name = "PctrBxRapor";
            this.PctrBxRapor.Size = new System.Drawing.Size(380, 230);
            this.PctrBxRapor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctrBxRapor.TabIndex = 31;
            this.PctrBxRapor.TabStop = false;
            this.PctrBxRapor.Click += new System.EventHandler(this.PctrBxRapor_Click);
            // 
            // PctrBxMuayeneEkrani
            // 
            this.PctrBxMuayeneEkrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PctrBxMuayeneEkrani.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PctrBxMuayeneEkrani.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PctrBxMuayeneEkrani.Image = global::WinFormUI.Properties.Resources.hastaCagir;
            this.PctrBxMuayeneEkrani.ImageRotate = 0F;
            this.PctrBxMuayeneEkrani.Location = new System.Drawing.Point(155, 291);
            this.PctrBxMuayeneEkrani.Name = "PctrBxMuayeneEkrani";
            this.PctrBxMuayeneEkrani.Size = new System.Drawing.Size(380, 230);
            this.PctrBxMuayeneEkrani.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctrBxMuayeneEkrani.TabIndex = 29;
            this.PctrBxMuayeneEkrani.TabStop = false;
            this.PctrBxMuayeneEkrani.Click += new System.EventHandler(this.PctrBxMuayeneEkrani_Click);
            // 
            // PctrBxHastaCagirma
            // 
            this.PctrBxHastaCagirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PctrBxHastaCagirma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PctrBxHastaCagirma.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PctrBxHastaCagirma.Image = global::WinFormUI.Properties.Resources.pnghastaMuayene;
            this.PctrBxHastaCagirma.ImageRotate = 0F;
            this.PctrBxHastaCagirma.Location = new System.Drawing.Point(661, 45);
            this.PctrBxHastaCagirma.Name = "PctrBxHastaCagirma";
            this.PctrBxHastaCagirma.Size = new System.Drawing.Size(380, 230);
            this.PctrBxHastaCagirma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctrBxHastaCagirma.TabIndex = 27;
            this.PctrBxHastaCagirma.TabStop = false;
            this.PctrBxHastaCagirma.Click += new System.EventHandler(this.PctrBxHastaCagirma_Click);
            // 
            // PctrBxHastaKayit
            // 
            this.PctrBxHastaKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PctrBxHastaKayit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PctrBxHastaKayit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PctrBxHastaKayit.Image = global::WinFormUI.Properties.Resources.pngegg;
            this.PctrBxHastaKayit.ImageRotate = 0F;
            this.PctrBxHastaKayit.Location = new System.Drawing.Point(155, 45);
            this.PctrBxHastaKayit.Name = "PctrBxHastaKayit";
            this.PctrBxHastaKayit.Size = new System.Drawing.Size(380, 230);
            this.PctrBxHastaKayit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctrBxHastaKayit.TabIndex = 26;
            this.PctrBxHastaKayit.TabStop = false;
            this.PctrBxHastaKayit.Click += new System.EventHandler(this.PctrBxHastaKayit_Click);
            // 
            // PctrBxClose
            // 
            this.PctrBxClose.Image = global::WinFormUI.Properties.Resources.multiply;
            this.PctrBxClose.ImageRotate = 0F;
            this.PctrBxClose.Location = new System.Drawing.Point(1134, 3);
            this.PctrBxClose.Name = "PctrBxClose";
            this.PctrBxClose.Size = new System.Drawing.Size(45, 45);
            this.PctrBxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctrBxClose.TabIndex = 25;
            this.PctrBxClose.TabStop = false;
            this.PctrBxClose.Click += new System.EventHandler(this.PctrBxClose_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 560);
            this.Controls.Add(this.PnlAnaSayfa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnaSayfa";
            this.PnlAnaSayfa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxRapor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxMuayeneEkrani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxHastaCagirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxHastaKayit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse frmAnaSayfaElipse;
        private Guna.UI2.WinForms.Guna2DragControl frmAnaSayfaDragControl;
        private Guna.UI2.WinForms.Guna2Panel PnlAnaSayfa;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxClose;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxMuayeneEkrani;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxHastaCagirma;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxHastaKayit;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxRapor;
    }
}