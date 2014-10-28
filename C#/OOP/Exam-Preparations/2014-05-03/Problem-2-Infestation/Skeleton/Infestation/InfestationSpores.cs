namespace Infestation
{
    public class InfestationSpores : BaseSupplement
    {
        public InfestationSpores()
            : base(aggressionAffect: 20, powerEffect: -1)
        {
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is InfestationSpores)
            {
                this.AggressionEffect = 0;
                this.PowerEffect = 0;
            }
        }
    }
}
