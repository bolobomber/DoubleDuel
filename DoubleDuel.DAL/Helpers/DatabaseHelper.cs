using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoubleDuel.DAL.Entities;

namespace DoubleDuel.DAL.Helpers
{   
    public static class DatabaseHelper
    {
        

        public static void AddStaticHero()
        {
            DoubleDuelsContext context = new DoubleDuelsContext();
            var axe = new StaticHero()
            {
                Name = "Axe",
                Hp = 1500,
                Skills = new List<Skill>()
                 {
                     new Skill()
                     {
                         Name = "AxeAttack!",
                         Damge = 100,
                     },
                     new Skill()
                     {
                         Name = "ConterFelix",
                         Damge = 70
                     }
                 }
            };
            context.Add(axe);
            var antiMage = new StaticHero()
            {
                Name = "Anti-Mage",
                Hp = 1000,
                Skills = new List<Skill>()
                 {
                     new Skill()
                     {
                         Name = "Mana Bern",
                         Damge = 200,
                     },
                     new Skill()
                     {
                         Name = "Conter Spell",
                         Damge = 100
                     }
                 }
            };
            context.Add(antiMage);
            var zeus = new StaticHero()
            {
                Name = "Zeus",
                Hp = 700,
                Skills = new List<Skill>()
                 {
                     new Skill()
                     {
                         Name = "Light",
                         Damge = 250,
                     },
                     new Skill()
                     {
                         Name = "zip-zap!",
                         Damge = 50
                     }
                 }
            };
            context.Add(zeus);
            var ogrMage = new StaticHero()
            {
                Name = "Ogr Mag",
                Hp = 2500,
                Skills = new List<Skill>()
                 {
                     new Skill()
                     {
                         Name = "2head",
                         Damge = 50,
                     },
                     new Skill()
                     {
                         Name = "ignite",
                         Damge = 30
                     }
                 }
            };
            context.Add(ogrMage);
            var io = new StaticHero()
            {
                Name = "io",
                Hp = 1200,
                Skills = new List<Skill>()
                 {
                     new Skill()
                     {
                         Name = "ball",
                         Damge = 50,
                     },
                     new Skill()
                     {
                         Name = "BALL",
                         Damge = 100
                     }
                 }
            };
            context.Add(io);
            var lina = new StaticHero()
            {
                Name = "Lina",
                Hp = 800,
                Skills = new List<Skill>()
                 {
                     new Skill()
                     {
                         Name = "Fire Dragon",
                         Damge = 120,
                     },
                     new Skill()
                     {
                         Name = "LagunaBlade",
                         Damge = 300
                     }
                 }
            };
            context.Add(lina);
            var Void = new StaticHero()
            {
                Name = "Faceless Void",
                Hp = 1300,
                Skills = new List<Skill>()
                 {
                     new Skill()
                     {
                         Name = "Bash",
                         Damge = 70,
                     },
                     new Skill()
                     {
                         Name = "Sphere",
                         Damge = 225
                     }
                 }
            };
            context.Add(Void);
            context.SaveChanges();
        }
    }
}
