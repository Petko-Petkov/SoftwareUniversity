namespace CompanyHierarchy
{
    using System;

    public interface ISales
    {
        string ProductName { get; set; }

        DateTime Date { get; set; }

        decimal Price { get; set; }
    }
}
