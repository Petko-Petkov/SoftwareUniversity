namespace GenericList
{
    using System;

    [AttributeUsage(AttributeTargets.Class | 
        AttributeTargets.Struct |
        AttributeTargets.Interface | 
        AttributeTargets.Enum | 
        AttributeTargets.Method)]

    public class VersionAttribute : Attribute
    {
        #region Fields

        private int major ;
        private int minor;

        #endregion 

        #region Construsctors

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        #endregion

        #region Properties

        public int Minor
        {
            get 
            {
                return this.minor;
            }

            set
            {
                ValidateInput(value);

                this.minor = value; 
            }
        }
                
        public int Major
        {
            get 
            {
                return this.major; 
            }

            set
            {
                ValidateInput(value);
                
                this.major = value; 
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return this.major + "." + this.minor;
        }

        private void ValidateInput(dynamic value) // seems a proper usage of dynamic because I am checking its type and throw exception if not Int32
        {
            if (!(value is int))
            {
                throw new FormatException("You must enter a valid integer");
            }

            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Enter a positive number.");
            }
        }

        #endregion
    }
}
