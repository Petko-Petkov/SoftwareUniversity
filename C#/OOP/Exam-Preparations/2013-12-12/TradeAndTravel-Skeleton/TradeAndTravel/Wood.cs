namespace TradeAndTravel
{
    public class Wood : Item
    {
        private const int WoodValue = 2;

        public Wood(string name, Location location = null)
            : base(name, WoodValue, ItemType.Weapon, location)
        {
        }

        public override void UpdateWithInteraction(string interaction)
        {
            if (interaction == "drop")
            {
                if (this.Value > 0)
                {
                    this.Value--;   
                }
            }

            base.UpdateWithInteraction(interaction);
        }
    }
}
