﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleDuel
{
    public partial class ArmyManagement : Form
    {
        public ArmyManagement()
        {
            InitializeComponent();
        }

        private void InMainBtn_Click(object sender, EventArgs e)
        {
            var mainWondow = new MainWindow();
            this.Hide();
            mainWondow.Show();
        }
    }
}
