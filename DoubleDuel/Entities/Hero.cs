using System.Collections.Generic;

namespace DoubleDuel.Entities
{
    public class Hero
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int StaticHeroId { get; set; }
        public StaticHero StaticHero { get; set; }
       
    }
}