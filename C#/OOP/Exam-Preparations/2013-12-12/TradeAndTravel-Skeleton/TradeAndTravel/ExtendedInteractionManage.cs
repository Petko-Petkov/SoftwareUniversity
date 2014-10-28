namespace TradeAndTravel
{
    using System.Linq;

    public class ExtendedInteractionManage : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    return new Weapon(itemNameString, itemLocation);
                case "wood":
                    return new Wood(itemNameString, itemLocation);
                case "iron":
                    return new Iron(itemNameString, itemLocation);
                default:
                    return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            }
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "forest":
                    location = new Forest(locationName);
                    break;
                case "mine":
                    location = new Mine(locationName);
                    break;
                default:
                    return base.CreateLocation(locationTypeString, locationName);
            }

            return location;
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    HandleGatherInteraction(commandWords, actor);
                    break;
                case "craft":
                    HandleCraftInteraction(commandWords, actor);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        private void HandleCraftInteraction(string[] commandWords, Person actor)
        {
            var craftedItemType = commandWords[2];
            var actorInventory = actor.ListInventory();
            var requiredWood = actorInventory
                .Any(i => i.ItemType == ItemType.Wood);
            var requiredIron = actorInventory
                .Any(i => i.ItemType == ItemType.Iron);

            switch (craftedItemType)
            {
                case "armor":
                    if (requiredIron)
                    {
                        var armor = new Armor(commandWords[3]);
                        this.AddToPerson(actor, armor);
                    }

                    break;
                case "weapon":
                    if (requiredIron && requiredWood)
                    {
                        var weapon = new Weapon(commandWords[3]);
                        this.AddToPerson(actor, weapon);
                    }

                    break;
            }
        }

        private void HandleGatherInteraction(string[] commandWords, Person actor)
        {
            var gatheringLocation = actor.Location as IGatheringLocation;
            if (gatheringLocation != null)
            {
                var actorInventory = actor.ListInventory();
                var requiredItem = actorInventory.Any(i => i.ItemType == ItemType.Weapon);

                if (requiredItem)
                {
                    var gatheredItem = gatheringLocation.ProduceItem(commandWords[2]);
                    this.AddToPerson(actor, gatheredItem);
                }
            }
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;

            switch (personTypeString)
            {
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }

            return person;
        }
    }
}
