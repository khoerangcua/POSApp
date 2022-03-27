
namespace POSApplication.HoaDon
{
    partial class HoaDonItemForm
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
            this.hoadonGridview = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ngaytxtbox = new System.Windows.Forms.TextBox();
            this.idhoadonTxtbox = new System.Windows.Forms.TextBox();
            this.khachhangTxtbox = new System.Windows.Forms.TextBox();
            this.thunganTxtbox = new System.Windows.Forms.TextBox();
            this.tongcongTxtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.discountTxtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tongtienTxtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonGridview)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // hoadonGridview
            // 
            this.hoadonGridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hoadonGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoadonGridview.Location = new System.Drawing.Point(3, 3);
            this.hoadonGridview.Name = "hoadonGridview";
            this.hoadonGridview.RowHeadersWidth = 51;
            this.hoadonGridview.RowTemplate.Height = 24;
            this.hoadonGridview.Size = new System.Drawing.Size(885, 264);
            this.hoadonGridview.TabIndex = 1;
            this.hoadonGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.thunganTxtbox);
            this.panel1.Controls.Add(this.khachhangTxtbox);
            this.panel1.Controls.Add(this.idhoadonTxtbox);
            this.panel1.Controls.Add(this.ngaytxtbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(48, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 179);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thu Ngân:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã hóa đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khách hàng:";
            // 
            // ngaytxtbox
            // 
            this.ngaytxtbox.BackColor = System.Drawing.SystemColors.Menu;
            this.ngaytxtbox.Location = new System.Drawing.Point(178, 3);
            this.ngaytxtbox.Name = "ngaytxtbox";
            this.ngaytxtbox.Size = new System.Drawing.Size(220, 36);
            this.ngaytxtbox.TabIndex = 4;
            // 
            // idhoadonTxtbox
            // 
            this.idhoadonTxtbox.BackColor = System.Drawing.SystemColors.Menu;
            this.idhoadonTxtbox.Location = new System.Drawing.Point(178, 59);
            this.idhoadonTxtbox.Name = "idhoadonTxtbox";
            this.idhoadonTxtbox.Size = new System.Drawing.Size(220, 36);
            this.idhoadonTxtbox.TabIndex = 5;
            // 
            // khachhangTxtbox
            // 
            this.khachhangTxtbox.BackColor = System.Drawing.SystemColors.Menu;
            this.khachhangTxtbox.Location = new System.Drawing.Point(178, 110);
            this.khachhangTxtbox.Name = "khachhangTxtbox";
            this.khachhangTxtbox.Size = new System.Drawing.Size(220, 36);
            this.khachhangTxtbox.TabIndex = 6;
            // 
            // thunganTxtbox
            // 
            this.thunganTxtbox.BackColor = System.Drawing.SystemColors.Menu;
            this.thunganTxtbox.Location = new System.Drawing.Point(607, 8);
            this.thunganTxtbox.Name = "thunganTxtbox";
            this.thunganTxtbox.Size = new System.Drawing.Size(238, 36);
            this.thunganTxtbox.TabIndex = 7;
            // 
            // tongcongTxtbox
            // 
            this.tongcongTxtbox.BackColor = System.Drawing.SystemColors.Menu;
            this.tongcongTxtbox.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongcongTxtbox.Location = new System.Drawing.Point(625, 291);
            this.tongcongTxtbox.Name = "tongcongTxtbox";
            this.tongcongTxtbox.Size = new System.Drawing.Size(220, 36);
            this.tongcongTxtbox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 35);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng cộng:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.tongcongTxtbox);
            this.panel2.Controls.Add(this.hoadonGridview);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(48, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 361);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tongtienTxtbox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.discountTxtbox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(48, 609);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 140);
            this.panel3.TabIndex = 10;
            // 
            // discountTxtbox
            // 
            this.discountTxtbox.BackColor = System.Drawing.SystemColors.Menu;
            this.discountTxtbox.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTxtbox.Location = new System.Drawing.Point(625, 25);
            this.discountTxtbox.Name = "discountTxtbox";
            this.discountTxtbox.Size = new System.Drawing.Size(220, 36);
            this.discountTxtbox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 35);
            this.label6.TabIndex = 7;
            this.label6.Text = "Discount:";
            // 
            // tongtienTxtbox
            // 
            this.tongtienTxtbox.BackColor = System.Drawing.SystemColors.Menu;
            this.tongtienTxtbox.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongtienTxtbox.Location = new System.Drawing.Point(625, 77);
            this.tongtienTxtbox.Name = "tongtienTxtbox";
            this.tongtienTxtbox.Size = new System.Drawing.Size(220, 36);
            this.tongtienTxtbox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Quicksand SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 35);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tổng tiền:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Location = new System.Drawing.Point(48, 609);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(891, 10);
            this.panel4.TabIndex = 11;
            // 
            // HoaDonItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 777);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "HoaDonItemForm";
            this.Text = "HoaDonItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.hoadonGridview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView hoadonGridview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox thunganTxtbox;
        private System.Windows.Forms.TextBox khachhangTxtbox;
        private System.Windows.Forms.TextBox idhoadonTxtbox;
        private System.Windows.Forms.TextBox ngaytxtbox;
        private System.Windows.Forms.TextBox tongcongTxtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tongtienTxtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox discountTxtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
    }
}