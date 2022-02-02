using System.Collections.Generic;

namespace DoubleDuel.Entities
{
    public class Hero
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public int hp { get; set; }
        public List<Skill> Skills { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

       
    }
}