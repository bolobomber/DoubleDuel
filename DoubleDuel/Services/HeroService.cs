using System.Collections.Generic;
using System.Linq;
using DoubleDuel.DAL;
using DoubleDuel.DAL.Entities;

namespace DoubleDuel.Services
{
    public class HeroService
    {
        public DoubleDuelsContext context;
        public HeroService()
        {
            context = new DoubleDuelsContext();
        }

        public List<StaticHero> GetAllStaticHeroes() =>
            context.StaticHeroes.Select(h => h).ToList();
        

        private List<Hero> GetHeroesByTwoNames (string hero1, string hero2)
        {
            List<Hero> heroes = new List<Hero>() {
                    new Hero()
                    {
                        StaticHeroId = context.StaticHeroes.Where(hero => hero.Name == hero1).Select(hero => hero.Id).FirstOrDefault()
                    },
                    new Hero()
                    {
                        StaticHeroId = context.StaticHeroes.Where(hero => hero.Name == hero2).Select(hero => hero.Id).FirstOrDefault()
                    }
                };

            return heroes;
        }
        public void UpdateHeroes(User user, string hero1, string hero2)
        {
            var heroes = GetHeroesByTwoNames(hero1, hero2);
            if (user.Heroes != null)
            {
                user.Heroes.Clear();  
            }
            else
            {
                user.Heroes = new List<Hero>();
            }
            user.Heroes.AddRange(heroes);
            context.Users.Update(user);
            context.SaveChanges();
        }
    }
}
