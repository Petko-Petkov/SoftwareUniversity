namespace Customer
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Customer : ICloneable, IComparable<Customer>
    {
        #region Properties

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string EGN { get; set; }

        public string PermanentAddress { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public List<Payment> Payments { get; set; }

        public CustomerType CustomerType { get; set; }

        #endregion

        #region Consructors

        public Customer(string firstName, string lastName, string egn)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EGN = egn;
        }

        public Customer(string firstName, string lastName, string middleName, string egn, string mobilePhone, string email, CustomerType customerType)
            : this(firstName, lastName, egn)
        {
            this.MiddleName = middleName;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.CustomerType = customerType;
        }

        #endregion

        #region Methods

        public override bool Equals(object param)
        {
            Customer customer = param as Customer;

            if (customer == null)
            {
                return false;
            }

            if ((customer.FirstName != this.FirstName) && 
                (customer.LastName != this.LastName))
            {
                return false;
            }

            if (customer.EGN != this.EGN)
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(Customer firstCustomer, Customer secondCustomer)
        {
            return Equals(firstCustomer, secondCustomer);
        }

        public static bool operator !=(Customer firstCustomer, Customer secondCustomer)
        {
            return Equals(firstCustomer, secondCustomer);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("{0} {1} - {2}", this.FirstName, this.LastName, this.EGN);
            return output.ToString();
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.EGN.GetHashCode();
        }

        public object Clone()
        {
            return new Customer(
                FirstName = this.FirstName,
                LastName = this.LastName, 
                EGN = this.EGN);
        }
        
        public int CompareTo(Customer other)
        {
            string thisFullName = String.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
            string otherFullName = String.Format("{0} {1} {2}", other.FirstName, other.MiddleName, other.LastName);
            if (thisFullName.CompareTo(otherFullName) != 0)
            {
                return thisFullName.CompareTo(otherFullName);
            }
            else
            {
                return this.EGN.CompareTo(other.EGN);
            }
        }

        #endregion
    }
}
