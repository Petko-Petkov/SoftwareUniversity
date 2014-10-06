namespace School
{
    using System;
    using System.Collections.Generic;

    public class Teacher : Person
    {
        public Teacher(string name, List<Discipline> disciplines) 
            : base(name)
        {
            this.Disciplines = disciplines;
        }

        public IList<Discipline> Disciplines { get; set; }
    }
}
