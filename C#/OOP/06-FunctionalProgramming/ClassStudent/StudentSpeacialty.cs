namespace ClassStudent
{
    using System;

    public class StudentSpeacialty
    {
        public string SpecialtyName { get; set; }
        public string FacultyNumber { get; set; }

        public StudentSpeacialty(string name, string facNumber)
        {
            this.SpecialtyName = name;
            this.FacultyNumber = facNumber;
        }
    }
}
