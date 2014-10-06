﻿namespace CompanyHierarchy
{
    using System;

    public abstract class RegularEmployee : Employee, IRegularEmployee
    { 
        public RegularEmployee(int id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
