﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            MainScreen main = new MainScreen();
            main.Show();
            this.Hide();
        }
    }
}
