namespace WinFormUI.Forms
{
    partial class frmRapor
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
            this.frmRaporElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.frmRaporDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PnlRapor = new Guna.UI2.WinForms.Guna2Panel();
            this.PctrBxCReturn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PctrBxClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PnlRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxCReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // frmRaporDragControl
            // 
            this.frmRaporDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.frmRaporDragControl.UseTransparentDrag = true;
            // 
            // PnlRapor
            // 
            this.PnlRapor.Controls.Add(this.PctrBxCReturn);
            this.PnlRapor.Controls.Add(this.PctrBxClose);
            this.PnlRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlRapor.Location = new System.Drawing.Point(0, 0);
            this.PnlRapor.Name = "PnlRapor";
            this.PnlRapor.Size = new System.Drawing.Size(1182, 560);
            this.PnlRapor.TabIndex = 0;
            // 
            // PctrBxCReturn
            // 
            this.PctrBxCReturn.Image = global::WinFormUI.Properties.Resources._return;
            this.PctrBxCReturn.ImageRotate = 0F;
            this.PctrBxCReturn.Location = new System.Drawing.Point(1075, 3);
            this.PctrBxCReturn.Name = "PctrBxCReturn";
            this.PctrBxCReturn.Size = new System.Drawing.Size(45, 45);
            this.PctrBxCReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctrBxCReturn.TabIndex = 26;
            this.PctrBxCReturn.TabStop = false;
            this.PctrBxCReturn.Click += new System.EventHandler(this.PctrBxCReturn_Click);
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
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 560);
            this.Controls.Add(this.PnlRapor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRapor";
            this.PnlRapor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxCReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse frmRaporElipse;
        private Guna.UI2.WinForms.Guna2DragControl frmRaporDragControl;
        private Guna.UI2.WinForms.Guna2Panel PnlRapor;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxClose;
        private Guna.UI2.WinForms.Guna2PictureBox PctrBxCReturn;
    }
}