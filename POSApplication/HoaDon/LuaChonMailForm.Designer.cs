
namespace POSApplication.HoaDon
{
    partial class LuaChonMailForm
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
            this.emailTxtbox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.hoadonCheckbox = new System.Windows.Forms.CheckBox();
            this.uudaiCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // emailTxtbox
            // 
            this.emailTxtbox.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxtbox.Location = new System.Drawing.Point(41, 88);
            this.emailTxtbox.Name = "emailTxtbox";
            this.emailTxtbox.Size = new System.Drawing.Size(487, 36);
            this.emailTxtbox.TabIndex = 0;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(38, 46);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(85, 35);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email:";
            // 
            // hoadonCheckbox
            // 
            this.hoadonCheckbox.AutoSize = true;
            this.hoadonCheckbox.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoadonCheckbox.Location = new System.Drawing.Point(41, 145);
            this.hoadonCheckbox.Name = "hoadonCheckbox";
            this.hoadonCheckbox.Size = new System.Drawing.Size(410, 39);
            this.hoadonCheckbox.TabIndex = 2;
            this.hoadonCheckbox.Text = "Gửi hóa đơn cho tôi qua mail này";
            this.hoadonCheckbox.UseVisualStyleBackColor = true;
            // 
            // uudaiCheckbox
            // 
            this.uudaiCheckbox.AutoSize = true;
            this.uudaiCheckbox.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uudaiCheckbox.Location = new System.Drawing.Point(41, 194);
            this.uudaiCheckbox.Name = "uudaiCheckbox";
            this.uudaiCheckbox.Size = new System.Drawing.Size(418, 39);
            this.uudaiCheckbox.TabIndex = 3;
            this.uudaiCheckbox.Text = "Gửi tôi những ưu đãi qua mail này";
            this.uudaiCheckbox.UseVisualStyleBackColor = true;
            // 
            // LuaChonMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 288);
            this.Controls.Add(this.uudaiCheckbox);
            this.Controls.Add(this.hoadonCheckbox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTxtbox);
            this.Name = "LuaChonMailForm";
            this.Text = "LuaChonMailForm";
            this.Load += new System.EventHandler(this.LuaChonMailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTxtbox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.CheckBox hoadonCheckbox;
        private System.Windows.Forms.CheckBox uudaiCheckbox;
    }
}