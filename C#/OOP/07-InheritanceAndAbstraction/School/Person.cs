namespace School
{
    using System;

    public abstract class Person
    {
        private string name;

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Please enter valid value for name.");
                }

                this.name = value;
            }
        }
    }
}
