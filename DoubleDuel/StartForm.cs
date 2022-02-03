using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoubleDuel.Services;

namespace DoubleDuel
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var auth = new AuthService();
            var user = auth.Authorization(textBox1.Text.Trim(), textBox2.Text.Trim());
            if (user != null){
                var mainWindow = new MainWindow();
                mainWindow.Show();
                this.Hide();
                
            }
            else
            {   
                MessageBox.Show("Неверный логин или пароль");
            }
           
        }


       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void regBtn3_Click(object sender, EventArgs e)
        {   
            var registration = new AuthService();
            registration.Regestration(textBox1.Text.Trim(), textBox2.Text.Trim());
        }

       
    }
}
