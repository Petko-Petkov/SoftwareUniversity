namespace CompanyHierarchy
{
    using System.Collections.Generic;

    public interface ISalesEmployee
    {
        IList<Sales> Sales { get; set; } 
    }
}
