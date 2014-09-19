namespace Persons
{
    using System;
    using System.Text;

    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
            : this(name, age, null)
        {

        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Person -> Name");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new IndexOutOfRangeException("The range of allowed values is between 1 and 100");
                }
                this.age = value;
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                if (value != null)
                {
                    if (!(value.Contains("@")))
                    {
                        throw new ArgumentException("Enter valid email!");
                    }
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            return this.name + " " + this.age;
        }
    }
}
