namespace PC_Catalogue
{
    using System;

    public class Component
    {
        #region Fields

        private string name;
        private string description;
        private decimal price;

        #endregion

        #region Constructors

        public Component(string componentName, decimal componentPrice, string componentDescription = null)
        {
            this.Name = componentName;
            this.Description = componentDescription;
            this.Price = componentPrice;
        }

        #endregion

        #region Properties

        public string Name
        {
            get { return this.name; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Component Name");
                }
                this.name = value; 
            }
        }

        public string Description
        {
            get { return this.description; }
            set 
            {
                this.description = value; 
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Component price - price cannot be negative.");
                }
                this.price = value; 
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return "Component = " + this.name + " Price = " + this.Price + "\n\r";
        }

        #endregion
    }
}
