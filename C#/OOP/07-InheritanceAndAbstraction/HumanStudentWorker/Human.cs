namespace HumanStudentWorker
{
    using System;

    public abstract class Human
    {
        #region Fields

        private string firstName;
        private string lastName;

        #endregion

        #region Constructor

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        #endregion

        #region Properties

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
                    throw new ArgumentNullException("Enter valid first name");
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
                    throw new ArgumentNullException("Enter valid last name");
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
