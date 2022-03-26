
namespace POSApplication.KhachHang
{
    partial class ChonKhachHangForm
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
            this.timkiemkhachhangLabel = new System.Windows.Forms.Label();
            this.timkiemPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chonButton2 = new System.Windows.Forms.Button();
            this.taomoiButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timkiemkhachhangLabel
            // 
            this.timkiemkhachhangLabel.AutoSize = true;
            this.timkiemkhachhangLabel.Font = new System.Drawing.Font("Quicksand", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.timkiemkhachhangLabel.Location = new System.Drawing.Point(281, 9);
            this.timkiemkhachhangLabel.Name = "timkiemkhachhangLabel";
            this.timkiemkhachhangLabel.Size = new System.Drawing.Size(278, 48);
            this.timkiemkhachhangLabel.TabIndex = 30;
            this.timkiemkhachhangLabel.Text = "Chọn khách hàng";
            this.timkiemkhachhangLabel.Click += new System.EventHandler(this.timkiemkhachhangLabel_Click);
            // 
            // timkiemPanel
            // 
            this.timkiemPanel.Location = new System.Drawing.Point(12, 60);
            this.timkiemPanel.Name = "timkiemPanel";
            this.timkiemPanel.Size = new System.Drawing.Size(800, 150);
            this.timkiemPanel.TabIndex = 31;
            this.timkiemPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.timkiemPanel_Paint);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(13, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 290);
            this.panel2.TabIndex = 32;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // chonButton2
            // 
            this.chonButton2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.chonButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chonButton2.ForeColor = System.Drawing.Color.White;
            this.chonButton2.Location = new System.Drawing.Point(646, 512);
            this.chonButton2.Name = "chonButton2";
            this.chonButton2.Size = new System.Drawing.Size(80, 30);
            this.chonButton2.TabIndex = 37;
            this.chonButton2.Text = "Chọn";
            this.chonButton2.UseVisualStyleBackColor = false;
            // 
            // taomoiButton2
            // 
            this.taomoiButton2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.taomoiButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taomoiButton2.ForeColor = System.Drawing.Color.White;
            this.taomoiButton2.Location = new System.Drawing.Point(732, 512);
            this.taomoiButton2.Name = "taomoiButton2";
            this.taomoiButton2.Size = new System.Drawing.Size(80, 30);
            this.taomoiButton2.TabIndex = 38;
            this.taomoiButton2.Text = "Tạo mới";
            this.taomoiButton2.UseVisualStyleBackColor = false;
            // 
            // ChonKhachHangForm
            // 
            this.ClientSize = new System.Drawing.Size(834, 581);
            this.Controls.Add(this.chonButton2);
            this.Controls.Add(this.taomoiButton2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.timkiemPanel);
            this.Controls.Add(this.timkiemkhachhangLabel);
            this.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChonKhachHangForm";
            this.Load += new System.EventHandler(this.ChonKhachHangForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button chonButton;
        private System.Windows.Forms.Button taomoiButton;
        private System.Windows.Forms.Label timkiemkhachhangLabel;
        private System.Windows.Forms.Panel timkiemPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button chonButton2;
        private System.Windows.Forms.Button taomoiButton2;
    }
}