namespace CompanyHierarchy
{
    using System;

    public abstract class Employee : Person, IEmployee
    {
        #region Fields

        private decimal salary;
        private Department department;

        #endregion

        #region Constructor

        public Employee(int id, string firstName, string lastname, decimal salary, Department dep)
            : base(id, firstName, lastname)
        {
            this.Salary = salary;
            this.Department = dep;
        }

        #endregion

        #region Properties

        public decimal Salary
        {
            get 
            { 
                return this.salary; 
            }

            set 
            {
                if (value  < 0)
                {
                    throw new ArgumentOutOfRangeException("salary", "Salary cannot be negative!");
                }

                this.salary = value;
            }
        }

        public Department Department
        {
            get 
            {
                return this.department; 
            }

            set 
            {
                this.Department = value; 
            }
        }

        #endregion
    }
}
