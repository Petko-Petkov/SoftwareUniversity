namespace CompanyHierarchy
{
    using System;

    public class Sales : ISales
    {
        #region Fields

        private string productName;
        private DateTime date;
        private decimal price;

        #endregion

        #region Properties

        public string ProductName
        {
            get 
            { 
                return this.productName; 
            }

            set 
            {
                this.productName = value; 
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.date = value;
            }
        }
        
        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.price = value;
            }
        }

        #endregion
    }
}
