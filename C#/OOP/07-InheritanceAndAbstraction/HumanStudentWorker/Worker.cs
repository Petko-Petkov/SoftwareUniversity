namespace HumanStudentWorker
{
    using System;
    
    public class Worker : Human
    {
        #region Fields

        private decimal weekSalary;
        private double workHoursPerDay;

        #endregion

        #region Constructors

        public Worker(string firstName, string lastName, decimal weekSalary, double workHours)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHours;
        }

        #endregion

        #region Properties

        public decimal WeekSalary
        {
            get 
            {
                return this.weekSalary; 
            }

            set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("The salary cannot be a negative value");
                }

                this.weekSalary = value; 
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The work hours per day cannot be a negative value");
                }
                this.workHoursPerDay = value;
            }
        }

        #endregion

        #region Methods

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / ((decimal)WorkHoursPerDay * 5);
        }

        #endregion
    }
}
