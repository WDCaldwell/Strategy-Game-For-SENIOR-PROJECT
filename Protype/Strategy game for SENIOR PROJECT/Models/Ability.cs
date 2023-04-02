namespace Strategy_game_for_SENIOR_PROJECT.Models
{
    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public Ability(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static List<Ability> GetAbilities() => new List<Ability>
        {
            new Ability(0,"Reach"),
            new Ability(1,"First Strike"),
            new Ability(2,"Slow Strike"),
            new Ability(3,"Bloodied"),
            new Ability(4,"flawless")
        };

    }
}
