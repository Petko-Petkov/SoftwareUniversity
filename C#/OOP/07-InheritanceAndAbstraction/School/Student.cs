namespace School
{
    using System;
    
    public class Student : Person
    {
        private int classNumber;

        public Student(string name, int classNum) : base(name)
        {
            this.ClassNumber = classNum;
        }

        public int ClassNumber
        {
            get 
            {
                return this.classNumber; 
            }

            set 
            {
                this.classNumber = value; 
            }
        }        
    }
}
