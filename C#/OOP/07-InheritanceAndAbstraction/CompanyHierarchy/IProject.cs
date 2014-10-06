namespace CompanyHierarchy
{
    using System;

    public interface IProject
    {
        string Name { get; set; }

        DateTime StartDate { get; set; }

        string Details { get; set; }

        void CloseProject();
    }
}
