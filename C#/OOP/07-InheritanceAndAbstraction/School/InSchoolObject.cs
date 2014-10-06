namespace School
{
    using System;

    abstract class InSchoolObject
    {
        private string details;

        public virtual string Details
        {   
            get { return this.Details; }
            set { this.Details = value; }
        }
        
    }
}
