﻿namespace CompanyHierarchy
{
    using System.Collections.Generic;

    public interface IDeveloper
    {
        IList<Project> Projects { get; set; } 
    }
}
