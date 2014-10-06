namespace CompanyHierarchy
{
    using System.Collections.Generic;

    public interface IManager
    {
        ICollection<Employee> Employees { get; set; }
    }
}
