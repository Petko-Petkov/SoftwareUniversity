namespace CompanyHierarchy
{
    using System;

    public abstract class Person : IPerson
    {
        #region Fields

        private int id;
        private string firstName;
        private string lastName;

        #endregion

        #region Constructors

        public Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        #endregion

        #region Properties

        public int Id
        {
            get 
            {
                return this.id;
            }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Id", "Id cannot be negative");
                }

                this.id = value; 
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("firstName", "Invalid value for first name");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("firstName", "Invalid value for first name");
                }

                this.lastName = value;
            }
        }

        #endregion

        #region Methods 

        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }

        #endregion
    }
}
