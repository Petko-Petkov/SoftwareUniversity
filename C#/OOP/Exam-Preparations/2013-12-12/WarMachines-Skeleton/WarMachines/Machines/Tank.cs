namespace WarMachines.Machines
{
    using System.Text;

    using WarMachines.Interfaces;
     
    public class Tank : Machine, ITank
    {
        private const double InitialHealthPoints = 100;

        private const double AttackPointsModifieR = 40;

        private const double DefensePointsModifier = 30;

        public Tank(string tankName, double attackPoints, double defensePoints)
            : base(tankName, InitialHealthPoints, attackPoints, defensePoints)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.AttackPoints += AttackPointsModifieR;
                this.DefensePoints -= DefensePointsModifier;
            }
            else
            {
                this.AttackPoints -= AttackPointsModifieR;
                this.DefensePoints += DefensePointsModifier;
            }

            this.DefenseMode = !this.DefenseMode;
        }

        public override string ToString()
        {
            var result = new StringBuilder(base.ToString());

            string defenseModeAsString = this.DefenseMode ? ModeOn : ModeOff;

            result.AppendLine(string.Format(" *Defense: {0}", defenseModeAsString));

            return result.ToString().TrimEnd();
        }
    }
}
