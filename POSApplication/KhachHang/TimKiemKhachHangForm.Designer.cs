
namespace POSApplication.KhachHang
{
    partial class TimKiemKhachHangForm
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
            this.timkiemButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sdtLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timkiemButton
            // 
            this.timkiemButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.timkiemButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.timkiemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timkiemButton.Location = new System.Drawing.Point(635, 58);
            this.timkiemButton.Name = "timkiemButton";
            this.timkiemButton.Size = new System.Drawing.Size(80, 30);
            this.timkiemButton.TabIndex = 36;
            this.timkiemButton.Text = "Tìm kiếm";
            this.timkiemButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 30);
            this.textBox1.TabIndex = 35;
            // 
            // sdtLabel
            // 
            this.sdtLabel.AutoSize = true;
            this.sdtLabel.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sdtLabel.Location = new System.Drawing.Point(61, 65);
            this.sdtLabel.Name = "sdtLabel";
            this.sdtLabel.Size = new System.Drawing.Size(90, 19);
            this.sdtLabel.TabIndex = 34;
            this.sdtLabel.Text = "Số điện thoại:";
            // 
            // TimKiemKhachHangForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 150);
            this.Controls.Add(this.timkiemButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sdtLabel);
            this.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimKiemKhachHangForm";
            this.Load += new System.EventHandler(this.TimKiemKhachHangForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button timkiemButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label sdtLabel;
    }
}