using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoubleDuel.Entities;


namespace DoubleDuel
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            var context = new DoubleDuelsContext();
            Hero pudge = new Hero()
            {
                Name = "Pudge",
                hp = 2000,
                Skills = new List<Skill>()
                {
                    new Skill()
                    {
                        Name = "rot",
                        Damge = 50,
                    }
                }
            };
            context.Heroes.Add(pudge);
            context.SaveChanges();
            /*User User = new User()
            {
                Login = "AndreyZolo2008",
                Password = "1234",
                Heroes = new List<Hero>() {
                    new Hero(){
                        Name = "Axe",
                        hp = 1000,
                            Skills = new List<Skill>()
                            {
                                new Skill()
                                {
                                    Name = "Axe Ataks!",
                                    Damge = 100

                                }
                            }

                     }
                 }
            };

            context.Users.Add(User);
            context.SaveChanges();
            */
        }
    }
}
