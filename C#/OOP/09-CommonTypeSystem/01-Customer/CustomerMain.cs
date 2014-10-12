namespace Customer
{
    using System;
    using System.Collections.Generic;

    public class CustomerMain
    {
        static void Main()
        {
            Customer firstCustomer = new Customer(
                "Peter",
                "Petrov", 
                "Petrov",
                "8002044445", 
                "0885885885", 
                "pesho@gmail.com", 
                CustomerType.Regular);

            Customer secondCustomer = new Customer(
                "Ivan",
                "Ivanov",
                "Ivanov",
                "9002042225",
                "0887885884",
                "vankata@gmail.com",
                CustomerType.Regular);

            Customer thirdCustomer = (Customer)secondCustomer.Clone();
            thirdCustomer.FirstName = "Gosho";
            thirdCustomer.EGN = "8212122246";

            List<Customer> customers = new List<Customer>() { firstCustomer, secondCustomer, thirdCustomer };
            customers.Sort();

            foreach (var c in customers)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(secondCustomer);
            Console.WriteLine(thirdCustomer);
            Console.WriteLine(firstCustomer.Equals(secondCustomer));
        }
    }
}
