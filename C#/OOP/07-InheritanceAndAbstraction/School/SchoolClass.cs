namespace School
{
    using System;
    using System.Collections.Generic;

    public class SchoolClass
    {
        private string uniqueID;

        public string UniqueID
        {
            get { return uniqueID; }
            set { uniqueID = value; }
        }
        

        public List<Student> classStudents { get; set; }
    }
}
