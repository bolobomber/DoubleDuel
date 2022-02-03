namespace DoubleDuel.DAL.Entities
{
    public class Skill
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damge { get; set; }
        public int StaticHeroId { get; set; }
        public StaticHero StaticHero { get; set; }
    }
}