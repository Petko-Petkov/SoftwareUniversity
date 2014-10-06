namespace CompanyHierarchy
{
    using System;

    public class Customer : Person, ICustomer
    {
        private decimal purchasedAmount;

        public Customer(int id, string firstName, string lastName, decimal amountSpent) 
            :base(id, firstName, lastName)
        {
            this.PurchasedAmount = amountSpent;
        }

        public decimal PurchasedAmount
        {
            get
            {
                return this.purchasedAmount;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("purchasedMount", "The spent amount cannot be negative!");
                }

                this.purchasedAmount = value;
            }
        }
        
    }
}
