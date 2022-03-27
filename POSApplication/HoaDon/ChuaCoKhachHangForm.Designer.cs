
namespace POSApplication.HoaDon
{
    partial class ChuaCoKhachHangForm
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
            this.themkhachhangBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // themkhachhangBtn
            // 
            this.themkhachhangBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(197)))));
            this.themkhachhangBtn.Location = new System.Drawing.Point(166, 50);
            this.themkhachhangBtn.Name = "themkhachhangBtn";
            this.themkhachhangBtn.Size = new System.Drawing.Size(270, 148);
            this.themkhachhangBtn.TabIndex = 0;
            this.themkhachhangBtn.UseVisualStyleBackColor = false;
            // 
            // ChuaCoKhachHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 281);
            this.Controls.Add(this.themkhachhangBtn);
            this.Name = "ChuaCoKhachHangForm";
            this.Text = "ChuaCoKhachHangForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button themkhachhangBtn;
    }
}