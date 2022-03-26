
namespace POSApplication.DanhMucSanPham
{
    partial class DanhMucsForm
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
            this.dmpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // dmpanel
            // 
            this.dmpanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.dmpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dmpanel.Location = new System.Drawing.Point(0, 0);
            this.dmpanel.Name = "dmpanel";
            this.dmpanel.Size = new System.Drawing.Size(350, 1033);
            this.dmpanel.TabIndex = 0;
            this.dmpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // DanhMucsForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(350, 1033);
            this.Controls.Add(this.dmpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhMucsForm";
            this.Text = "DanhMucsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel dmpanel;
    }
}