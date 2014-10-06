namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;

    public class Developer : RegularEmployee, IDeveloper
    {
        public IList<Project> Projects { get; set; }

        public Developer(int id, string firstName, string lastName, decimal salary, Department department, IList<Project> projects)
            : base(id, firstName, lastName, salary, department)
        {
            department = Department.Production;
            this.Projects = projects;
        }
    }
}
