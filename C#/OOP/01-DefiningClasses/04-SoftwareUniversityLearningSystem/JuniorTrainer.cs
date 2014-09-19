namespace SoftwareUniversityLearningSystem
{
    using System;

    public class JuniorTrainer : Trainer, IPerson
    {
        public JuniorTrainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {

        }
    }
}
