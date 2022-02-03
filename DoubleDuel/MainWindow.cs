using System;
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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
 
        private void FightBtn_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            var startForm = new StartForm();
            this.Hide();
            startForm.Show();
        }

        private void ArmBtn_Click(object sender, EventArgs e)
        {
            var armyManadgement = new ArmyManagement();
            this.Hide();
            armyManadgement.Show();
        }
    }
}
