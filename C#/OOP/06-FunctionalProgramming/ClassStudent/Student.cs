namespace ClassStudent
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FacultyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }
        public int Age { get; set; }
        public string GroupName { get; set; }

        public Student(string firstName, string lastName, string facultyNum, string phone, string email, List<int> marks, int group, int age, string groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNum;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = group;
            this.Age = age;
            this.GroupName = groupName;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
