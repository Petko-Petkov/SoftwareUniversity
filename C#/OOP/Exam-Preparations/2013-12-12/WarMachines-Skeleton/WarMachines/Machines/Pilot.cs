namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;

        private List<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value", "Name cannot null, empty or whitespaces.");
                }
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            this.machines.Add(machine);
        }

        public string Report()
        {
            var report = new StringBuilder();
            string pilotName = this.Name;
            string machinesNumber = this.machines.Count == 0 ? "no" : this.machines.Count.ToString();
            string machineWord = this.machines.Count == 1 ? "machine" : "machines";

            report.AppendLine(string.Format("{0} - {1} {2}", pilotName, machinesNumber, machineWord).TrimEnd());

            var sortedMachines = this.machines
                                    .OrderBy(m => m.HealthPoints)
                                    .ThenBy(m => m.Name);

            foreach (var machine in sortedMachines)
            {
                report.AppendLine(machine.ToString());
            }

            return report.ToString().TrimEnd();
        }
    }
}
