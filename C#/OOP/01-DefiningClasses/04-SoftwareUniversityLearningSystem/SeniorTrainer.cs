namespace SoftwareUniversityLearningSystem
{
    using System;

    public class SeniorTrainer : Trainer, IPerson
    {
        public SeniorTrainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {

        }

        public void DeleteCourse(string courseName)
        {
            Console.WriteLine("Course {0} deleted!", courseName );
        }
    }
}
