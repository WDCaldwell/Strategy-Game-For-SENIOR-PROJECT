namespace Strategy_game_for_SENIOR_PROJECT.Models
{
    public class UnitAbility
    {
        public int UnitId { get; set; }
        public int AbilityId { get; set; }

        public UnitAbility(int unitId, int abilityId)
        {
            UnitId = unitId;
            AbilityId = abilityId;
        }

        public static List<UnitAbility> GetAbilities() => new List<UnitAbility>
        {
            //Unit ID first Ability ID second. Please check those tables for refrence.
            new UnitAbility(0,1),
            new UnitAbility(0,4),
            new UnitAbility(1,3)

        };
    }
}
