﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //modified from github and now from my pcs
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hello_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new Form1()).ShowDialog();
        }
    }
}
