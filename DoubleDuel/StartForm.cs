using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoubleDuel.DAL;
using DoubleDuel.Services;

namespace DoubleDuel
{
    public partial class StartForm : Form
    {
        public AuthService authService;
        public StartForm()
        {
            InitializeComponent();
            authService = new AuthService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var authSetvice = new AuthService();
            var user = authSetvice.Authorization(textBox1.Text.Trim(), textBox2.Text.Trim());
            if (user != null){
                var mainWindow = new MainWindow(user);
                mainWindow.Show();
                
                this.Hide();
                
            }
            else
            {   
                MessageBox.Show("Неверный логин или пароль");
            }
           
        }
        private void regBtn3_Click(object sender, EventArgs e)
        {   
            
            if(authService.Regestration(textBox1.Text.Trim(), textBox2.Text.Trim()))
            {   

                MessageBox.Show($"Пользователь{textBox1.Text.Trim()} успешно зарегестрирован");
            }
            else
            {
                MessageBox.Show("Прости но пользователь с таким логином уже существует");
            }
        }

       
    }
}
