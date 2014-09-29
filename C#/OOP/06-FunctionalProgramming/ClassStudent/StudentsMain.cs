namespace ClassStudent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentsMain
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Petko", "Petkov", "321614", "0887-PECATA", "pecata@mail.com", new List<int>() { 2, 3, 4, 5, 5 }, 2, 24, "first"),
                new Student("Martin", "Todorov", "876215", "02 956 54 35", "martin@gmail.com", new List<int>() { 6, 4, 4, 6, 5 }, 3, 35, "first"),
                new Student("Adriyana", "Alexandrova", "845617", "0885-121223", "adi@mail.com", new List<int>() { 2, 3, 2, 4, 3 }, 2, 22, "third"),
                new Student("Emil", "Stefanov", "982514", "0898-654832", "emilio@abv.bg", new List<int>() { 5, 6, 6, 5, 6 }, 1, 40, "third"),
                new Student("Kliment", "Gerganov", "872315", "0887-710214", "kokala@mail.bg", new List<int>() { 4, 3, 4, 5, 4 }, 3, 19, "second"),
                new Student("Todor", "Petkov", "521654", "0878-292929", "toko@mail.toko.com", new List<int>() { 3, 2, 4, 3, 5 }, 2, 33, "first"),
                new Student("Vasil", "Georgiev", "752654", "+35928557474", "vaseto_bg@gmail.com", new List<int>() { 6, 5, 6, 6, 5 }, 3, 22, "second"),
                new Student("Stefan", "Stefanov", "989878", "0885-STEFAN", "stef@yahoo.com", new List<int>() { 2, 3, 4, 5, 2 }, 1, 35, "third")
            };

            List<StudentSpeacialty> studentSpeacialties = new List<StudentSpeacialty>() 
            {
                new StudentSpeacialty("Web Developer", "321614"),
                new StudentSpeacialty("Web Developer", "876215"),
                new StudentSpeacialty("PHP Developer", "845617"),
                new StudentSpeacialty("PHP Developer", "982514"),
                new StudentSpeacialty("C# Developer", "872315"),
                new StudentSpeacialty("JS Developer", "521654"),
                new StudentSpeacialty("C# Developer", "752654"),
                new StudentSpeacialty("JS Developer", "989878")
            };

            #region Problem 04

            Console.WriteLine("Problem 04");

            var groupTwo = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);

            foreach (var st in groupTwo)
            {
                Console.WriteLine("Students from group 2 sorted by name - {0}", st);
            }

            Console.WriteLine("\r\n");

            #endregion

            #region Problem 05

            Console.WriteLine("Problem 05");

            var firstBeforeLast = students.Where(st => st.FirstName.CompareTo(st.LastName) <= 0);

            foreach (var st in firstBeforeLast)
            {
                Console.WriteLine("Student whose first name is before his las name - {0}", st);
            }

            Console.WriteLine("\r\n");

            #endregion

            #region Problem 06

            Console.WriteLine("Problem 06");

            var ageBetween = students.Where(st => (st.Age <= 24 && st.Age >= 18));

            foreach (var st in ageBetween)
            {
                Console.WriteLine("Student aged [18 ... 24] - {0}", st);
            }

            Console.WriteLine("\r\n");

            #endregion

            #region Problem 07

            Console.WriteLine("Problem 07");

            var sortedStudentsLambda = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);
            var sortedStudentsLINQ =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var st in sortedStudentsLambda)
            {
                Console.WriteLine("Students sorted with lambda - {0}", st);
            }

            Console.WriteLine();

            foreach (var st in sortedStudentsLINQ)
            {
                Console.WriteLine("Students sorted with LINQ - {0}", st);
            }

            Console.WriteLine("\r\n");

            #endregion

            #region Problem 08

            Console.WriteLine("Problem 08");

            var sortedBeEmail =
                from student in students
                where student.Email.EndsWith("@abv.bg")
                select student;

            foreach (var st in sortedBeEmail)
            {
                Console.WriteLine("Student with email in abv - {0}, mail: {1}", st, st.Email);
            }

            Console.WriteLine("\r\n");

            #endregion

            #region Problem 09

            Console.WriteLine("Problem 09");

            var filteredByPhone =
                from student in students
                where student.Phone.StartsWith("02")
                || student.Phone.StartsWith("+3592")
                || student.Phone.StartsWith("+359 2")
                select student;

            foreach (var st in filteredByPhone)
            {
                Console.WriteLine("Student with phone in Sofia - {0}, phone: {1}", st, st.Phone);
            }

            Console.WriteLine("\r\n");

            #endregion

            #region Problem 10

            Console.WriteLine("Problem 10");

            var excellentSt =
                from student in students
                where student.Marks.Contains(6)
                select new { fullname = student.FirstName + " " + student.LastName, marks = student.Marks };

            foreach (var st in excellentSt)
            {
                string marks = string.Join(" ", st.marks);

                Console.WriteLine("Student with at least one mark 6 - {0}, marks: {1}", st.fullname, marks);
            }

            Console.WriteLine("\r\n");

            #endregion

            #region Problem 11

            Console.WriteLine("Problem 11");

            var weakStudents =
                from student in students
                where student.Marks.Where(st => st == 2).Count() == 2
                select student;

            foreach (var st in weakStudents)
            {
                Console.WriteLine("Student with exactly two marks [2] - {0}", st);
            }

            Console.WriteLine("\r\n");

            #endregion

            #region Problem 12

            Console.WriteLine("Problem 12");

            var enrolledAfter = students.Where(st => int.Parse(st.FacultyNumber.Substring(4, 2)) == 14);

            foreach (var st in enrolledAfter)
            {
                string marks = string.Join(" ", st.Marks);

                Console.WriteLine("Student enrolled in 2014 - {0} marks: {1}", st, marks);
            }

            Console.WriteLine("\r\n");

            #endregion

            #region Problem 13

            Console.WriteLine("Problem 13");

            var groupName = students.GroupBy(st => st.GroupName, st => st.ToString(), (key, value) => new { GroupName = key, st = value.ToList() });

            foreach (var gr in groupName)
            {
                Console.WriteLine("Group name - {0}", gr.GroupName);

                for (int i = 0; i < gr.st.Count; i++)
                {
                    Console.WriteLine("Students in group {0} - {1}", gr.GroupName, gr.st[i]);
                }
            }

            Console.WriteLine("\r\n");

            #endregion

            #region Problem 14

            Console.WriteLine("Problem 14");

            var stSpecialties =
                from st in students
                join spec in studentSpeacialties on st.FacultyNumber equals spec.FacultyNumber
                select new { SpecialtyName = spec.SpecialtyName, FacNumber = spec.FacultyNumber, Studento = st.FirstName + " " + st.LastName };

            stSpecialties = stSpecialties.OrderBy(st => st.Studento);

            foreach (var item in stSpecialties)
            {
                Console.WriteLine("{0, -25} {1, -10} {2}", item.Studento, item.FacNumber, item.SpecialtyName);
            }
            #endregion
        }
    }
}