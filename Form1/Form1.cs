﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Success";
            MessageBox.Show("Successfully added the message");
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press on the click button");
            MessageBox.Show("Hi Tested in Visual Studio code");
            MessageBox.Show("Not commited");
        }
    }
}
