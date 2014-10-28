namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        #region Fields

        protected const string ModeOn = "ON";
        protected const string ModeOff = "OFF";

        private string name;

        private IPilot pilot;

        private IList<string> targets;

        #endregion

        #region Constructors

        protected Machine(string machineName, double machineHealth, double machineAttack, double machineDefense)
        {
            this.Name = machineName;
            this.HealthPoints = machineHealth;
            this.AttackPoints = machineAttack;
            this.DefensePoints = machineDefense;
            this.targets = new List<string>();
        }

        #endregion

        #region Properties

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value", "Name cannot be null or whitespaces.");
                }

                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "Machine cannot be engaged without pilot");
                }

                this.pilot = value;
            }
        }

        public double HealthPoints { get; set; }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public IList<string> Targets
        {
            get
            {
                return new List<string>(this.targets);
            }
        }

        #endregion

        #region Methods

        public void Attack(string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                throw new ArgumentNullException("target", "Target cannot be null, empty or whitespaces string.");
            }

            this.targets.Add(target);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            string targetsStr = this.targets.Count == 0 ? "None" : string.Join(", ", this.targets);

            result.AppendLine(string.Format("- {0}", this.Name));
            result.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            result.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            result.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            result.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));
            result.AppendLine(string.Format(" *Targets: {0}", targetsStr));

            return result.ToString();
        }

        #endregion
    }
}
