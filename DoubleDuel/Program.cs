using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoubleDuel.DAL;
using DoubleDuel.DAL.Helpers;

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
            Application.Run(new StartForm());
            var context = new DoubleDuelsContext();
            //DatabaseHelper.AddStaticHero();
            /* var Pudge = new StaticHero()
             {
                 Name = "Pudge",
                 Hp = 2000,
                 Skills = new List<Skill>()
                 {
                     new Skill()
                     {
                         Name = "Hook",
                         Damge = 140,
                     },
                     new Skill()
                     {
                         Name = "Rot",
                         Damge = 20
                     }
                 }
             };
             context.Add(Pudge);
             context.SaveChanges();
             */
            /* var user = new User()
             {   
                 Login = "AndreyYevrey",
                 Password = "123vladsosi",
                 Heroes = new List<Hero>()
                 {
                    new Hero()
                    {
                      StaticHeroId = context.StaticHeroes.Where(hero => hero.Name == "Pudge" )
                                                         .Select(hero => hero.Id)
                                                         .FirstOrDefault()
                    }
                 }
             };
             context.Add(user);
             context.SaveChanges();
             */

           
        }
    }
}
