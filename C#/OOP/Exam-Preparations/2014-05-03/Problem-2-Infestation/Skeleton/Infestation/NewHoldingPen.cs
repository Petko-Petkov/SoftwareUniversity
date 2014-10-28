namespace Infestation
{
    public class NewHoldingPen : HoldingPen
    {
        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            string supplementName = commandWords[1];
            string target = commandWords[2];
            var unit = GetUnit(target);

            switch (supplementName)
            {
                case "PowerCatalyst":
                    unit.AddSupplement(new PowerCatalyst());
                    break;
                case "HealthCatalyst":
                    unit.AddSupplement(new HealthCatalyst());
                    break;
                case "AggressionCatalyst":
                    unit.AddSupplement(new AggressionCatalyst());
                    break;
                case "Weapon":
                    unit.AddSupplement(new Weapon());
                    break;
            }
        }

        protected override void ProcessSingleInteraction(Interaction interaction)
        {
            switch (interaction.InteractionType)
            {
                case InteractionType.Infest:
                    Unit targetUnit = this.GetUnit(interaction.TargetUnit);
                    targetUnit.AddSupplement(new InfestationSpores());    
                    break;
                default:
                    base.ProcessSingleInteraction(interaction);
                    break;
            }
        }

        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            string unitType = commandWords[1];
            string unitId = commandWords[2];

            switch (unitType)
            {
                case "Marine":
                    var marine = new Marine(unitId);
                    this.InsertUnit(marine);
                    break;
                case "Tank":
                    var tank = new Tank(unitId);
                    this.InsertUnit(tank);
                    break;
                case "Queen":
                    var queen = new Queen(unitId);
                    this.InsertUnit(queen);
                    break;
                case "Parasite":
                    var parasite = new Parasite(unitId);
                    this.InsertUnit(parasite);
                    break;
                default:
                    base.ExecuteInsertUnitCommand(commandWords);
                    break;
            }
        }
    }
}
