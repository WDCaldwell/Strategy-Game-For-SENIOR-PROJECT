namespace Strategy_game_for_SENIOR_PROJECT.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Movement { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }

        public Unit(int id, string name, int movement, int health, int attack)
        {
            Id = id;
            Name = name;
            Movement = movement;
            Health = health;
            Attack = attack;

        }

        public static List<Unit> GetUnits() => new List<Unit>
        {
            new Unit(0,"Spear Man",1,6,2),
            new Unit(1,"Ax Man",3,2,6),
            new Unit(2,"Sword Man",2,4,3)
        };
    }
}
