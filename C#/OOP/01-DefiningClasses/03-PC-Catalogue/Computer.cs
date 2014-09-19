namespace PC_Catalogue
{
    using System;
    using System.Collections.Generic;

    public class Computer
    {
        #region Fields

        private string name;
        private List<Component> components;
        private decimal price;

        #endregion

        #region Constructor

        public Computer(string pcName, List<Component> pcComponents)
        {
            this.Name = pcName;
            this.Components = pcComponents;
            this.Price = PCPrice(pcComponents);
        }

        #endregion

        #region Properties

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }        

        public List<Component> Components
        {
            get { return this.components; }
            set { this.components = value; }
        }
        
        public decimal Price
        {
            get { return this.price; }
            set { this.price = PCPrice(this.components); }
        }
        #endregion

        #region Methods

        private static decimal PCPrice(List<Component> components)
        {
            decimal price = 0m;

            foreach (var component in components)
            {
                price += component.Price;    
            }

            return price;
        }

        public override string ToString()
        {
            string result = string.Empty;

            foreach (var comp in Components)
            {
                result += comp;
            }

            return "PC name = " + this.name + "\n\r" + result + " ";
        }

        #endregion
    }
}
