
namespace POSApplication.HoaDon
{
    partial class DaCoKhachHangForm
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
            this.khachhangPicture = new System.Windows.Forms.PictureBox();
            this.khachhangTxtbox = new System.Windows.Forms.TextBox();
            this.idTxtbox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.giamgiaLabel = new System.Windows.Forms.Label();
            this.sdtLable = new System.Windows.Forms.Label();
            this.khachhangLabel = new System.Windows.Forms.Label();
            this.sdtTxtbox = new System.Windows.Forms.TextBox();
            this.giamgiaCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // khachhangPicture
            // 
            this.khachhangPicture.Location = new System.Drawing.Point(45, 105);
            this.khachhangPicture.Name = "khachhangPicture";
            this.khachhangPicture.Size = new System.Drawing.Size(224, 215);
            this.khachhangPicture.TabIndex = 0;
            this.khachhangPicture.TabStop = false;
            this.khachhangPicture.Click += new System.EventHandler(this.khachhangPicture_Click);
            // 
            // khachhangTxtbox
            // 
            this.khachhangTxtbox.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khachhangTxtbox.Location = new System.Drawing.Point(530, 105);
            this.khachhangTxtbox.Name = "khachhangTxtbox";
            this.khachhangTxtbox.Size = new System.Drawing.Size(290, 36);
            this.khachhangTxtbox.TabIndex = 4;
            this.khachhangTxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // idTxtbox
            // 
            this.idTxtbox.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxtbox.Location = new System.Drawing.Point(530, 162);
            this.idTxtbox.Name = "idTxtbox";
            this.idTxtbox.Size = new System.Drawing.Size(290, 36);
            this.idTxtbox.TabIndex = 5;
            this.idTxtbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(327, 165);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(187, 35);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID khách hàng:";
            this.idLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // giamgiaLabel
            // 
            this.giamgiaLabel.AutoSize = true;
            this.giamgiaLabel.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giamgiaLabel.Location = new System.Drawing.Point(327, 281);
            this.giamgiaLabel.Name = "giamgiaLabel";
            this.giamgiaLabel.Size = new System.Drawing.Size(165, 35);
            this.giamgiaLabel.TabIndex = 3;
            this.giamgiaLabel.Text = "Mã giảm giá:";
            // 
            // sdtLable
            // 
            this.sdtLable.AutoSize = true;
            this.sdtLable.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdtLable.Location = new System.Drawing.Point(327, 224);
            this.sdtLable.Name = "sdtLable";
            this.sdtLable.Size = new System.Drawing.Size(174, 35);
            this.sdtLable.TabIndex = 2;
            this.sdtLable.Text = "Số điện thoại:";
            // 
            // khachhangLabel
            // 
            this.khachhangLabel.AutoSize = true;
            this.khachhangLabel.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khachhangLabel.Location = new System.Drawing.Point(327, 108);
            this.khachhangLabel.Name = "khachhangLabel";
            this.khachhangLabel.Size = new System.Drawing.Size(203, 35);
            this.khachhangLabel.TabIndex = 0;
            this.khachhangLabel.Text = "Tên khách hàng:";
            // 
            // sdtTxtbox
            // 
            this.sdtTxtbox.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdtTxtbox.Location = new System.Drawing.Point(530, 221);
            this.sdtTxtbox.Name = "sdtTxtbox";
            this.sdtTxtbox.Size = new System.Drawing.Size(290, 36);
            this.sdtTxtbox.TabIndex = 6;
            // 
            // giamgiaCombobox
            // 
            this.giamgiaCombobox.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giamgiaCombobox.FormattingEnabled = true;
            this.giamgiaCombobox.Location = new System.Drawing.Point(530, 278);
            this.giamgiaCombobox.Name = "giamgiaCombobox";
            this.giamgiaCombobox.Size = new System.Drawing.Size(290, 42);
            this.giamgiaCombobox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 59);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thông tin khách hàng:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DaCoKhachHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giamgiaCombobox);
            this.Controls.Add(this.sdtTxtbox);
            this.Controls.Add(this.khachhangLabel);
            this.Controls.Add(this.idTxtbox);
            this.Controls.Add(this.khachhangPicture);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.sdtLable);
            this.Controls.Add(this.khachhangTxtbox);
            this.Controls.Add(this.giamgiaLabel);
            this.Name = "DaCoKhachHangForm";
            this.Text = "DaCoKhachHangForm";
            this.Load += new System.EventHandler(this.DaCoKhachHangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khachhangPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox khachhangPicture;
        private System.Windows.Forms.TextBox khachhangTxtbox;
        private System.Windows.Forms.TextBox idTxtbox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label giamgiaLabel;
        private System.Windows.Forms.Label sdtLable;
        private System.Windows.Forms.Label khachhangLabel;
        private System.Windows.Forms.TextBox sdtTxtbox;
        private System.Windows.Forms.ComboBox giamgiaCombobox;
        private System.Windows.Forms.Label label1;
    }
}