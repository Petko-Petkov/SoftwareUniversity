namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : ITeacher
    {
        private string name;

        private IList<ICourse> courses; 

        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
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
                    throw new ArgumentNullException("name", "Name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Teacher: Name={0}", this.Name);
            if (this.courses.Count > 0)
            {
                output.AppendFormat("; Courses=[{0}]", string.Join(", ", this.courses));
            }

            return output.ToString();
        }
    }
}
