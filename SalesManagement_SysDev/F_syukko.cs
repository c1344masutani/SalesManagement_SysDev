﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_syukko : Form
    {
        public F_syukko()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form frm = new F_menu();

            Opacity = 0;

            frm.ShowDialog();

            this.Close();
        }

        private void SyStateFlag_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
