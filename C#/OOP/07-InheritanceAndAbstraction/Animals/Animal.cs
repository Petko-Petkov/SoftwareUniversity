namespace Animals
{
    using System;
    
    public abstract class Animal
    {
        #region Fields

        private string name;
        private int age;
        private string gender;

        #endregion

        #region Constructors

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender.ToLower();
        }

        #endregion

        #region Properties

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
                    throw new ArgumentNullException("Enter valid value for name");    
                }

                this.name = value; 
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The age cannot be negative");
                }

                this.age = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }

            set
            {
                if (value != "male".ToLower() && value != "female".ToLower())
                {
                    throw new ArgumentException("Gender can only be MALE or FEMALE");
                }

                this.gender = value;
            }
        }

        #endregion
    }
}
