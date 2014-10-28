namespace Infestation
{
    using System.Collections.Generic;
    using System.Linq;

    public class Infestor : Unit
    {
        public Infestor(string id, UnitClassification type, int health, int power, int aggression)
            : base(id, type, health, power, aggression)
        {
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            var target = attackableUnits
                .Where(u => u.Id != this.Id)
                .OrderBy(u => u.Health)
                .FirstOrDefault();

            return target;
        }

        public override Interaction DecideInteraction(IEnumerable<UnitInfo> units)
        {
            var candidateUnits = units
                .Where((unit) => unit.Id 
                    != this.Id 
                    && this.UnitClassification 
                    == InfestationRequirements.RequiredClassificationToInfest(unit.UnitClassification));

            UnitInfo optimalAttackableUnit = GetOptimalAttackableUnit(candidateUnits);

            foreach (var unit in candidateUnits)
            {
                if (unit.Health < optimalAttackableUnit.Health)
                {
                    optimalAttackableUnit = unit;
                }
            }

            if (optimalAttackableUnit.Id != null)
            {
                return new Interaction(new UnitInfo(this), optimalAttackableUnit, InteractionType.Infest);
            }

            return Interaction.PassiveInteraction;
        }
    }
}
