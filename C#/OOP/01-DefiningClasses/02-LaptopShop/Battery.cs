namespace LaptopShop
{
    using System;

    public class Battery
    {
        #region Fields

        private string description;
        private double lifeInHours;

        #endregion

        #region Constructors

        public Battery(string description, double life = 0)
        {
            this.Description = description;
            this.LifeInHours = life;
        }

        #endregion

        #region Properties
        public string Description
        {
            get { return this.description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Battery->Description");
                }
                this.description = value; 
            }
        }

        public double LifeInHours
        {
            get { return this.lifeInHours;} 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Battery->LifeInHours");
                }
                this.lifeInHours = value;
            }
        }
        #endregion

        public override string ToString()
        {
            return this.Description + ", battery life - " + this.LifeInHours + " hours";
        }
    }
}
