namespace Infestation
{
    using System;

    public abstract class BaseSupplement : ISupplement
    {
        public BaseSupplement(int healthEffect = 0, int powerEffect = 0, int aggressionAffect = 0)
        {
            this.PowerEffect = powerEffect;
            this.HealthEffect = healthEffect;
            this.AggressionEffect = aggressionAffect;
        }

        public int PowerEffect { get; protected set; }

        public int HealthEffect { get; protected set; }

        public int AggressionEffect { get; protected set; }

        public virtual void ReactTo(ISupplement otherSupplement)
        {
        }
    }
}
