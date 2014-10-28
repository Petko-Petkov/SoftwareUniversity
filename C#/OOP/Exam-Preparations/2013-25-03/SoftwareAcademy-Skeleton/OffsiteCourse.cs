namespace SoftwareAcademy
{
    using System;
    using System.Text;

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("town", "Town cannot be null or empty.");
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.ToString());

            output.AppendFormat("Town={0}", this.Town);

            return output.ToString();
            /*
             * Topics=[(course topics – comma separated)]; 
             * Lab=(lab name – when applicable); 
             * Town=(town name – when applicable);
             */
        }
    }
}
