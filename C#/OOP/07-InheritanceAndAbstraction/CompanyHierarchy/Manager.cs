namespace CompanyHierarchy
{
    using System.Collections.Generic;

    public class Manager : Employee, IEmployee
    {
        public List<Employee> Employees { get; set; }

        public Manager(int id, string firstName, string lastName, decimal salary, Department department, List<Employee> employees)
            : base(id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }
    }
}
