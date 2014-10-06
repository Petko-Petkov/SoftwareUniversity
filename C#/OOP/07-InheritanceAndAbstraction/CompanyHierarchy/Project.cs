namespace CompanyHierarchy
{
    using System;
    using System.Security.AccessControl;

    public class Project : IProject
    {
        #region Fields

        private string name;
        private DateTime startDate;
        private string details;
        private State state;

        #endregion

        #region Constructor

        public Project(string projectName, DateTime projectStartDate, string projectDetails, State projectState)
        {
            this.Name = projectName;
            this.StartDate = projectStartDate;
            this.Details = projectDetails;

            if ((projectState != State.Closed) || (projectState != State.Open))
            {
                throw new ArgumentOutOfRangeException("projectState", "The project state can only be [Open] or [Closed]");
            }
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
                    throw new ArgumentNullException("name", "Enter valid value for name");
                }

                this.name = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return this.startDate;
            }

            set
            {
                this.startDate = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }

            set
            {
                this.details = value;
            }
        }

        #endregion

        #region Methods

        public void CloseProject()
        {
            if (this.state == State.Closed)
            {
                throw new ArgumentException("state", "The project has already been closed.");
            }

            this.state = State.Closed;
        }

        public override string ToString()
        {
            string output = string.Format("Project {0} with start date: {1} is {2}", this.name, this.startDate, this.state);
            return output;
        }

        #endregion
    }
}
