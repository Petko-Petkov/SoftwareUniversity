namespace StudentClass
{
    using System;

    public class Student 
    {
        public event EventHandler<PropertyChangedEventArgs> PropertyChanged;

        #region Fields

        private string name;
        private int age;

        #endregion

        #region Constructors

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        #endregion

        public string Name 
        {
            get
            {
                return this.name;
            }

            set
            {
                if (this.name != value)
                {
                    NotifyPropertyChanged(new PropertyChangedEventArgs("Name", this.Name, value));
                    this.name = value;
                }
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
                if (this.age != value)
                {
                    NotifyPropertyChanged(new PropertyChangedEventArgs("Age", this.Age.ToString(), value.ToString()));
                    this.age = value;
                }
            }
        }

        private void NotifyPropertyChanged(PropertyChangedEventArgs e)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, e);
            }
        }
    }
}
