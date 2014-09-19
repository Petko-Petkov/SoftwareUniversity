namespace LaptopShop
{
    using System;

    public class Laptop
    {
        #region Fields
        private string model;
        private string manifacturer;
        private string processor;
        private string graphicsCard;
        private Battery battery;
        private string screen;
        private decimal price;
        #endregion

        #region Constructors

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, decimal price, string manifacturer)
            : this(model, price)
        {
            this.Manifacturer = manifacturer;
        }

        public Laptop(string model, decimal price, string manifacturer, string processor)
            : this(model, price, manifacturer)
        {
            this.Processor = processor;
        }

        public Laptop(string model, decimal price, string manifacturer, string processor, string graphicsCard, Battery battery, string screen) 
            : this(model, price, manifacturer)
        {
            this.Processor = processor;
            this.GraphicsCard = graphicsCard;
            this.Battery = battery;
            this.screen = screen;
        }
        #endregion

        #region Properties
        public string Model
        {
            get { return this.model; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Laptop->Model");
                }
                this.model = value; 
            }
        }

        public string Manifacturer
        {
            get { return this.manifacturer; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Laptop->Manifacturer");
                }
                this.manifacturer = value; 
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Laptop->Processor");
                }
                this.processor = value; 
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Laptop->GraphicsCard");
                }
                this.graphicsCard = value; 
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public string Screen
        {
            get { return this.screen; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Laptop->Screen");
                }
                this.screen = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Laptop->Price");
                }
                this.price = value; 
            }
        }
        #endregion

        public override string ToString()
        {
            string result = string.Format ("Laptop(Model : {0}, Manifacturer: {1}, Processor: {2}, GraphicsCard: {3}, Battery: {4}, Screen: {5}, Price: {6}lv.)",
                this.model, this.manifacturer, this.processor, this.graphicsCard, this.battery, this.screen, this.price);
            return result;
        }
    }
}
