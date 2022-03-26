
namespace POSApplication.DanhMucSanPham
{
    partial class DanhMucForm
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
            this.danhmucbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // danhmucbtn
            // 
            this.danhmucbtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.danhmucbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.danhmucbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.danhmucbtn.Font = new System.Drawing.Font("Quicksand SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhmucbtn.ForeColor = System.Drawing.Color.CadetBlue;
            this.danhmucbtn.Location = new System.Drawing.Point(0, 0);
            this.danhmucbtn.Name = "danhmucbtn";
            this.danhmucbtn.Size = new System.Drawing.Size(350, 70);
            this.danhmucbtn.TabIndex = 0;
            this.danhmucbtn.Text = "NUOC UONG";
            this.danhmucbtn.UseVisualStyleBackColor = false;
            // 
            // DanhMucForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 70);
            this.Controls.Add(this.danhmucbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhMucForm";
            this.Text = "DanhMucForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button danhmucbtn;
    }
}