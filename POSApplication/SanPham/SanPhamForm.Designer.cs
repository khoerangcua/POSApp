
namespace POSApplication.SanPham
{
    partial class SanPhamForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tensplabel = new System.Windows.Forms.Label();
            this.giasplabel = new System.Windows.Forms.Label();
            this.soluongtbx = new System.Windows.Forms.TextBox();
            this.congbtn = new System.Windows.Forms.Button();
            this.trubtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.spptr = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spptr)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tensplabel);
            this.panel1.Controls.Add(this.giasplabel);
            this.panel1.Controls.Add(this.soluongtbx);
            this.panel1.Controls.Add(this.congbtn);
            this.panel1.Controls.Add(this.trubtn);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Controls.Add(this.spptr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 320);
            this.panel1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tensplabel
            // 
            this.tensplabel.AutoSize = true;
            this.tensplabel.Location = new System.Drawing.Point(101, 145);
            this.tensplabel.Name = "tensplabel";
            this.tensplabel.Size = new System.Drawing.Size(69, 30);
            this.tensplabel.TabIndex = 13;
            this.tensplabel.Text = "Name";
            this.tensplabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // giasplabel
            // 
            this.giasplabel.AutoSize = true;
            this.giasplabel.Location = new System.Drawing.Point(118, 238);
            this.giasplabel.Name = "giasplabel";
            this.giasplabel.Size = new System.Drawing.Size(35, 30);
            this.giasplabel.TabIndex = 12;
            this.giasplabel.Text = "4$";
            this.giasplabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soluongtbx
            // 
            this.soluongtbx.Font = new System.Drawing.Font("Quicksand", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluongtbx.Location = new System.Drawing.Point(91, 184);
            this.soluongtbx.Name = "soluongtbx";
            this.soluongtbx.Size = new System.Drawing.Size(88, 24);
            this.soluongtbx.TabIndex = 11;
            // 
            // congbtn
            // 
            this.congbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.congbtn.Font = new System.Drawing.Font("Quicksand", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congbtn.Location = new System.Drawing.Point(181, 180);
            this.congbtn.Name = "congbtn";
            this.congbtn.Size = new System.Drawing.Size(43, 32);
            this.congbtn.TabIndex = 10;
            this.congbtn.Text = "+";
            this.congbtn.UseVisualStyleBackColor = true;
            // 
            // trubtn
            // 
            this.trubtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.trubtn.Font = new System.Drawing.Font("Quicksand", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trubtn.Location = new System.Drawing.Point(49, 182);
            this.trubtn.Name = "trubtn";
            this.trubtn.Size = new System.Drawing.Size(38, 29);
            this.trubtn.TabIndex = 9;
            this.trubtn.Text = "-";
            this.trubtn.UseVisualStyleBackColor = true;
            // 
            // addbtn
            // 
            this.addbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.Transparent;
            this.addbtn.Location = new System.Drawing.Point(78, 270);
            this.addbtn.Margin = new System.Windows.Forms.Padding(2);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(115, 34);
            this.addbtn.TabIndex = 8;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = false;
            // 
            // spptr
            // 
            this.spptr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spptr.BackColor = System.Drawing.Color.BlueViolet;
            this.spptr.Location = new System.Drawing.Point(22, 17);
            this.spptr.Margin = new System.Windows.Forms.Padding(2);
            this.spptr.Name = "spptr";
            this.spptr.Size = new System.Drawing.Size(227, 122);
            this.spptr.TabIndex = 7;
            this.spptr.TabStop = false;
            // 
            // SanPhamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 320);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "SanPhamForm";
            this.Text = "SanPhamForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spptr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tensplabel;
        private System.Windows.Forms.Label giasplabel;
        private System.Windows.Forms.TextBox soluongtbx;
        private System.Windows.Forms.Button congbtn;
        public System.Windows.Forms.Button trubtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.PictureBox spptr;
        private System.Windows.Forms.ImageList imageList1;
    }
}