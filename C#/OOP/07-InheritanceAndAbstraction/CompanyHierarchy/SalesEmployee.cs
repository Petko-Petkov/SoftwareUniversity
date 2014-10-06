namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;

    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        public IList<Sales> Sales { get; set; }

        public SalesEmployee(int id, string firstName, string lastName, decimal salary, Department department, IList<Sales> sales)
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
            department = Department.Sales;
        }
    }
}
