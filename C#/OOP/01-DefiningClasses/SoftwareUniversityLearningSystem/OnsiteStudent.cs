namespace SoftwareUniversityLearningSystem
{
    using System;
    
    public class OnsiteStudent : CurrentStudent, IPerson
    {
        public int NumberOfVisits { get; set; }

        public OnsiteStudent(string firstName, string lastName, int age, int studenNumber, double avrgGrade, string currentCourse, int numberOfVisits)
            : base(firstName, lastName, age, studenNumber, avrgGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }
    }
}
