namespace SoftwareUniversityLearningSystem
{
    using System;

    public class OnlineStudent : CurrentStudent, IPerson
    {
        public OnlineStudent(string firstName, string lastName, int age, int studentNumber, double avrgGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber, avrgGrade, currentCourse)
        {

        }
    }
}
