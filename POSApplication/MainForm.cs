﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSService;
using POSDataModel;


namespace POSApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            System_Layer system_Layer = new System_Layer();
            system_Layer.TaoHoaDonMoi();
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
