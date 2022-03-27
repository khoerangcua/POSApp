
namespace POSApplication.HoaDon
{
    partial class PhuongThucThanhToanForm
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
            this.phuongthucLable = new System.Windows.Forms.Label();
            this.tienmatRadiobtn = new System.Windows.Forms.RadioButton();
            this.tindungRadiobtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // phuongthucLable
            // 
            this.phuongthucLable.AutoSize = true;
            this.phuongthucLable.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phuongthucLable.Location = new System.Drawing.Point(29, 34);
            this.phuongthucLable.Name = "phuongthucLable";
            this.phuongthucLable.Size = new System.Drawing.Size(366, 35);
            this.phuongthucLable.TabIndex = 0;
            this.phuongthucLable.Text = "Chọn phương thức thanh toán:";
            this.phuongthucLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // tienmatRadiobtn
            // 
            this.tienmatRadiobtn.AutoSize = true;
            this.tienmatRadiobtn.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienmatRadiobtn.Location = new System.Drawing.Point(35, 92);
            this.tienmatRadiobtn.Name = "tienmatRadiobtn";
            this.tienmatRadiobtn.Size = new System.Drawing.Size(136, 39);
            this.tienmatRadiobtn.TabIndex = 1;
            this.tienmatRadiobtn.TabStop = true;
            this.tienmatRadiobtn.Text = "TIền mặt";
            this.tienmatRadiobtn.UseVisualStyleBackColor = true;
            this.tienmatRadiobtn.CheckedChanged += new System.EventHandler(this.tienmatRadiobtn_CheckedChanged);
            // 
            // tindungRadiobtn
            // 
            this.tindungRadiobtn.AutoSize = true;
            this.tindungRadiobtn.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tindungRadiobtn.Location = new System.Drawing.Point(35, 152);
            this.tindungRadiobtn.Name = "tindungRadiobtn";
            this.tindungRadiobtn.Size = new System.Drawing.Size(177, 39);
            this.tindungRadiobtn.TabIndex = 2;
            this.tindungRadiobtn.TabStop = true;
            this.tindungRadiobtn.Text = "Thẻ tín dụng";
            this.tindungRadiobtn.UseVisualStyleBackColor = true;
            this.tindungRadiobtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // PhuongThucThanhToanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 239);
            this.Controls.Add(this.tindungRadiobtn);
            this.Controls.Add(this.tienmatRadiobtn);
            this.Controls.Add(this.phuongthucLable);
            this.Name = "PhuongThucThanhToanForm";
            this.Text = "PhuongThucThanhToanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label phuongthucLable;
        private System.Windows.Forms.RadioButton tienmatRadiobtn;
        private System.Windows.Forms.RadioButton tindungRadiobtn;
    }
}