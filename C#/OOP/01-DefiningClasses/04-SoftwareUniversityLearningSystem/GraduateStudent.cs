namespace SoftwareUniversityLearningSystem
{
    using System;

    public class GraduateStudent : Student, IPerson
    {
        public GraduateStudent(string firstName, string lastName, int age, int studenNumber, double avrgGrade)
            : base(firstName, lastName, age, studenNumber, avrgGrade)
        {

        }
    }
}
