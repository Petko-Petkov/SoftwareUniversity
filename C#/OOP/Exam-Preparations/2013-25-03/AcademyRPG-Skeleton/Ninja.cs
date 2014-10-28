using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    using System.Runtime.InteropServices;

    public class Ninja : Character, IFighter, IGatherer
    {
        private const int InitialAttackPoints = 0;

        private int attackPoints;

        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 1;
        }

        public int AttackPoints
        {
            get { return this.attackPoints; }
            private set
            {
                this.attackPoints = value;
            }
        }

        public int DefensePoints
        {
            get { return int.MaxValue; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var target =
                availableTargets
                    .Where(t => t.Owner != 0 && t.Owner != this.Owner)
                    .OrderBy(t => t.HitPoints)
                    .FirstOrDefault();

            return availableTargets.IndexOf(target);
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints += resource.Quantity;
                return true;
            }

            if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints += resource.Quantity * 2;
                return true;
            }

            return false;
        }
    }
}
