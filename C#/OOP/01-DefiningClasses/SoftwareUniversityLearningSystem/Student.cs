namespace SoftwareUniversityLearningSystem
{
    using System;

    public abstract class Student : Person, IPerson
    {
        public int StudentNumber { get; set; }
        public double AverageGrade { get; set; }

        public Student(string firstName, string lastName, int age, int studentNumer, double avrgGrade)
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumer;
            this.AverageGrade = avrgGrade;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " average grade = " + this.AverageGrade;
        }
    }
}
