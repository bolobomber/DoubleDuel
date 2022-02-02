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
          /*  
           *  андрей гей 
           *  var Pudge = new Hero()
            {
                StaticHeroId = 123
            };
          
           */
        }
    }
}
