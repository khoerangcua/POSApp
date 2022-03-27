
namespace POSApplication.HoaDon
{
    partial class HoaDonForm
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
            this.khachhangPannel = new System.Windows.Forms.FlowLayoutPanel();
            this.hoadonitemPannel = new System.Windows.Forms.FlowLayoutPanel();
            this.phuongthucPannel = new System.Windows.Forms.FlowLayoutPanel();
            this.guimailPannel = new System.Windows.Forms.FlowLayoutPanel();
            this.thanhtoanBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // khachhangPannel
            // 
            this.khachhangPannel.Location = new System.Drawing.Point(12, 12);
            this.khachhangPannel.Name = "khachhangPannel";
            this.khachhangPannel.Size = new System.Drawing.Size(1089, 183);
            this.khachhangPannel.TabIndex = 1;
            // 
            // hoadonitemPannel
            // 
            this.hoadonitemPannel.Location = new System.Drawing.Point(12, 228);
            this.hoadonitemPannel.Name = "hoadonitemPannel";
            this.hoadonitemPannel.Size = new System.Drawing.Size(1089, 223);
            this.hoadonitemPannel.TabIndex = 2;
            // 
            // phuongthucPannel
            // 
            this.phuongthucPannel.Location = new System.Drawing.Point(12, 477);
            this.phuongthucPannel.Name = "phuongthucPannel";
            this.phuongthucPannel.Size = new System.Drawing.Size(1089, 93);
            this.phuongthucPannel.TabIndex = 3;
            // 
            // guimailPannel
            // 
            this.guimailPannel.Location = new System.Drawing.Point(12, 589);
            this.guimailPannel.Name = "guimailPannel";
            this.guimailPannel.Size = new System.Drawing.Size(1089, 93);
            this.guimailPannel.TabIndex = 4;
            // 
            // thanhtoanBtn
            // 
            this.thanhtoanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.thanhtoanBtn.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanhtoanBtn.Location = new System.Drawing.Point(420, 697);
            this.thanhtoanBtn.Name = "thanhtoanBtn";
            this.thanhtoanBtn.Size = new System.Drawing.Size(306, 46);
            this.thanhtoanBtn.TabIndex = 5;
            this.thanhtoanBtn.Text = "Thanh toán";
            this.thanhtoanBtn.UseVisualStyleBackColor = false;
            // 
            // HoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 960);
            this.Controls.Add(this.thanhtoanBtn);
            this.Controls.Add(this.guimailPannel);
            this.Controls.Add(this.phuongthucPannel);
            this.Controls.Add(this.hoadonitemPannel);
            this.Controls.Add(this.khachhangPannel);
            this.Name = "HoaDonForm";
            this.Text = "HoaDonForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel khachhangPannel;
        private System.Windows.Forms.FlowLayoutPanel hoadonitemPannel;
        private System.Windows.Forms.FlowLayoutPanel phuongthucPannel;
        private System.Windows.Forms.FlowLayoutPanel guimailPannel;
        private System.Windows.Forms.Button thanhtoanBtn;
    }
}