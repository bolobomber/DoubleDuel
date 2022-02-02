namespace DoubleDuel.Entities
{
    public class Skill
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damge { get; set; }
        public int HeroId { get; set; }
        public Hero Hero { get; set; }
    }
}