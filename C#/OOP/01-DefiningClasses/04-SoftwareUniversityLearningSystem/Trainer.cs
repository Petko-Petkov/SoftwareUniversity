namespace SoftwareUniversityLearningSystem
{
    using System;

    public abstract class Trainer : Person, IPerson
    {
        public Trainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {

        }
        protected void CreateCourse(string courseName)
        {
            Console.WriteLine("Course {0} created!", courseName);
        }
    }
}
