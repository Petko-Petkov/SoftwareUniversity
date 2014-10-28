namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course : ICourse
    {
        private string name;

        private ITeacher teacher;

        protected Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Topics = new List<string>();
        }

        protected IList<string> Topics { get; private set; }
        
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

        public ITeacher Teacher
        {
            get
            {
                return this.teacher;
            }

            set
            {
                this.teacher = value;
            }
        }

        public void AddTopic(string topic)
        {
            this.Topics.Add(topic);
        }

        public override string ToString()
        {
            /*
             * (course type): Name=(course name); Teacher=(teacher name); 
             * Topics=[(course topics – comma separated)]; 
             * Lab=(lab name – when applicable); 
             * Town=(town name – when applicable);
             */
            var type = this.GetType().Name;

            StringBuilder output = new StringBuilder();
            output.AppendFormat("{0}: Name={1}; ",type, this.Name);
            if (teacher != null)
            {
                output.AppendFormat("Teacher={0}; ", this.Teacher.Name);
            }

            if (this.Topics.Count > 0)
            {
                output.AppendFormat("Topics=[{0}]; ", string.Join(", ", this.Topics));    
            }
            
            return output.ToString();
        }
    }
}
