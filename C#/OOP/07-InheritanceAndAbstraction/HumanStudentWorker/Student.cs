namespace HumanStudentWorker
{
    using System;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string faultyNumber) 
            : base(firstName, lastName)
        {
            this.FacultyNumber = faultyNumber;
        }

        public string FacultyNumber
        {
            get 
            {
                return this.facultyNumber;
            }

            set 
            {
                if (value.Length < 5 || value .Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Please enter a value in the range [5...10]");
                }

                this.facultyNumber = value; 
            }
        }        
    }
}
