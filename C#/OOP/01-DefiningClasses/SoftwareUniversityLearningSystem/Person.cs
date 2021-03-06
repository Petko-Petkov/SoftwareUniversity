﻿namespace SoftwareUniversityLearningSystem
{
    using System;

    public abstract class Person : IPerson
    {
        public string FirstName { get; private set; }
              
        public string LastName { get; private set; }
              
        public int Age { get; private set; }

        protected Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
}
