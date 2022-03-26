
namespace POSApplication
{
    partial class MainForm
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
            this.menupanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hoadonpanel = new System.Windows.Forms.Panel();
            this.contentpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menupanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menupanel
            // 
            this.menupanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menupanel.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menupanel.Controls.Add(this.flowLayoutPanel1);
            this.menupanel.Location = new System.Drawing.Point(0, 1);
            this.menupanel.Name = "menupanel";
            this.menupanel.Size = new System.Drawing.Size(350, 1033);
            this.menupanel.TabIndex = 0;
            this.menupanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menupanel_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(347, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1100, 1033);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // hoadonpanel
            // 
            this.hoadonpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.hoadonpanel.Location = new System.Drawing.Point(1452, 0);
            this.hoadonpanel.Name = "hoadonpanel";
            this.hoadonpanel.Size = new System.Drawing.Size(450, 1033);
            this.hoadonpanel.TabIndex = 1;
            // 
            // contentpanel
            // 
            this.contentpanel.Location = new System.Drawing.Point(351, 0);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(1100, 1033);
            this.contentpanel.TabIndex = 2;
            this.contentpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.hoadonpanel);
            this.Controls.Add(this.menupanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menupanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menupanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel hoadonpanel;
        private System.Windows.Forms.FlowLayoutPanel contentpanel;
    }
}

