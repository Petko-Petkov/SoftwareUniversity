namespace School
{
    using System;
    using System.Collections.Generic;

    public class Discipline
    {
        #region Fields 

        private string name;
        private int lecturesCount;

        #endregion

        #region Constructors

        public Discipline(string name, int lecturesCount, List<Student> studentList)
        {
            this.Name = name;
            this.LecturesCount = lecturesCount;
            this.Students = studentList;
        }

        #endregion

        #region Properties

        public IList<Student> Students { get; set; }
         
        public string Name
        {
            get 
            {
                return this.name;
            }

            set 
            {
                this.name = value; 
            }
        }

        public int LecturesCount
        {
            get
            {
                return this.lecturesCount;
            }

            set
            {
                this.lecturesCount = value;
            }
        }

        #endregion
    }
}
