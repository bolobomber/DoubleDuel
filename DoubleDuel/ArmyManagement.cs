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
using DoubleDuel.DAL.Entities;
using DoubleDuel.Services;

namespace DoubleDuel
{
    public partial class ArmyManagement : Form
    {
        public User user;
        public HeroService heroService;
        public ArmyManagement(User user)
        {
            InitializeComponent();
            this.user = user;
            heroService = new HeroService();
           
            foreach (var item in heroService.GetAllStaticHeroes())
            {   
                comboBox1.Items.Add(item.Name);
                comboBox2.Items.Add(item.Name);
            }
            
           
        }

    private void InMainBtn_Click(object sender, EventArgs e)
        {
            var mainWondow = new MainWindow(user);
            this.Hide();
            mainWondow.Show();
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Remove(comboBox1.SelectedItem);
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            HeroService changeArmy = new HeroService();
            changeArmy.UpdateHeroes(user, comboBox1.SelectedItem.ToString(), comboBox1.SelectedItem.ToString());

            MessageBox.Show($" ваша армия состоит из {comboBox1.SelectedItem} and {comboBox2.SelectedItem}");
        }
    }
}
