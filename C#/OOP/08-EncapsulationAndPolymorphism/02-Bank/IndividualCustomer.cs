﻿namespace Bank
{
    public class IndividualCustomer : Customer, ICustomer
    {
        public IndividualCustomer(string name)
            : base(name)
        {
            this.Name = name;
        }
    }
}
