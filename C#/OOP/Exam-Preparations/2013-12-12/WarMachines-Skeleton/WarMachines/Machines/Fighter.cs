using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarMachines.Machines
{
    using WarMachines.Interfaces;

    public class Fighter : Machine, IFighter
    {
        private const int InitialHealthPoints = 200;

        public Fighter(string tankName, double attackPoints, double defensePoints, bool initialStealthMode)
            : base(tankName, InitialHealthPoints, attackPoints, defensePoints)
        {
            this.StealthMode = initialStealthMode;
        }

        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            var result = new StringBuilder(base.ToString());

            string stealthModeAsString = this.StealthMode ? ModeOn : ModeOff;

            // TODO Check if I need append or appendline
            result.AppendLine(string.Format(" *Stealth: {0}", stealthModeAsString));

            return result.ToString().TrimEnd();
        }
    }
}
