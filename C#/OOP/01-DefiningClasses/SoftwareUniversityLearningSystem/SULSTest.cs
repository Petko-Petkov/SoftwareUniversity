namespace SoftwareUniversityLearningSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SULSTest
    {
        static void Main()
        {
            JuniorTrainer jt1 = new JuniorTrainer("Pesho", "Peshov", 24);
            JuniorTrainer jt2 = new JuniorTrainer("Gosho", "Goshov", 27);
            JuniorTrainer jt3 = new JuniorTrainer("Vladko", "Vladkov", 19);
            SeniorTrainer st1 = new SeniorTrainer("Petko", "Petkov", 33);
            SeniorTrainer st2 = new SeniorTrainer("Stefan", "Stefanov", 38);
            SeniorTrainer st3 = new SeniorTrainer("Martin", "Martinov", 29);
            GraduateStudent gt1 = new GraduateStudent("Ivan", "Novakov", 35, 30020925, 4.45);
            GraduateStudent gt2 = new GraduateStudent("Radoslav", "Simeonov", 28, 30058925, 5.80);
            GraduateStudent gt3 = new GraduateStudent("Teodor", "Stoychev", 33, 300521345, 3.00);
            OnlineStudent ost1 = new OnlineStudent("Emil", "Stefanov", 48, 40018512, 3.33, "OOP");
            OnlineStudent ost2 = new OnlineStudent("Martin", "Todorov", 22, 40065415, 5.45, "OOP");
            OnlineStudent ost3 = new OnlineStudent("Valeri", "Zahariev", 18, 40018525, 4.89, "OOP");
            OnsiteStudent os1 = new OnsiteStudent("Natalya", "Alexandrova", 31, 40089564, 4.00, "OOP", 5);
            OnsiteStudent os2 = new OnsiteStudent("Adriyana", "Alexandrova", 25, 40012188, 5.25, "OOP", 5);
            OnsiteStudent os3 = new OnsiteStudent("Peter", "Simeonov", 30, 40035698, 3.80, "OOP", 3);

            List<Person> softuniInvolved = new List<Person>() { jt1, jt2, jt3, st1, st2, st3, gt1, gt2, gt3, ost1, ost2, ost3, os1, os2, os3};

            var currentStudents = softuniInvolved.Where(st => st is CurrentStudent).OrderBy(st => ((Student)st).AverageGrade);

            foreach (var student in currentStudents)
            {
                Console.WriteLine(student);
            }
         }
    }
}
