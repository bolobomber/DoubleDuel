using System.Collections.Generic;

namespace DoubleDuel.DAL.Entities
{
    public class StaticHero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hp { get; set; }
        public List<Hero> Heroes { get; set; }
        public List<Skill> Skills { get; set; }
       
    }
}