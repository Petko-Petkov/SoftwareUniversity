namespace SoftwareUniversityLearningSystem
{
    using System;

    public abstract class CurrentStudent : Student, IPerson
    {
        public string CurrentCourse { get; private set; }

        public CurrentStudent(string firstName, string lasstName, int age, int studentNumber, double avrgGrade, string currentCourse)
            : base(firstName, lasstName, age, studentNumber, avrgGrade)
        {
            this.CurrentCourse = currentCourse;
        }
    }
}
