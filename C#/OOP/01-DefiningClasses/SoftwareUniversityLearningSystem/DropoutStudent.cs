namespace SoftwareUniversityLearningSystem
{
    using System;

    public class DropoutStudent : Student, IPerson
    {
        public string DropoutReason { get; private set; }
              
        public DropoutStudent(string firstName, string lastName, int age, int studentNumber, double avrgGrade, string reason)
            : base(firstName, lastName, age, studentNumber, avrgGrade)
        {
            this.DropoutReason = reason;
        }
    }
}
