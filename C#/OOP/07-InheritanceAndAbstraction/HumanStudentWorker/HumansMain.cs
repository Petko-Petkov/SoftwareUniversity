namespace HumanStudentWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class HumansMain
    {
        static void Main()
        {
            var students = new List<Student>() 
            {
                new Student("Petko", "Petkov", "301214"),
                new Student("Emil", "Stefanov", "302213"),
                new Student("Martin", "Todorov", "301514"),
                new Student("Kliment", "Gerganov", "311014"),
                new Student("Todor", "Petkov", "301113"),
                new Student("Martin", "Atanassov", "312514"),
                new Student("Adriyana", "Alexandrova", "301615"),
                new Student("Denitsa", "Yotova", "300513"),
                new Student("Georgi", "Petkov", "311115"),
                new Student("Ivan", "Ivanov", "300214")
            };

            Console.WriteLine("List of students ordered by faculty number\r\n");

            var sortedStudents = students.OrderBy(st => st.FacultyNumber);

            foreach (var st in sortedStudents)
            {
                Console.WriteLine(st + " " + st.FacultyNumber);
            }

            var workers = new List<Worker>() 
            {
                new Worker("Peter", "Minchev", 1200m, 7),
                new Worker("Venelin", "Lesov", 600m, 8),
                new Worker("Kamen", "Petkov", 850, 7.5),
                new Worker("Kliment", "Petrov", 1300m, 8),
                new Worker("Maria", "Ivanova", 960m, 6),
                new Worker("Kamelia", "Doncheva", 900, 7.5),
                new Worker("Yana", "Angelova", 850, 8),
                new Worker("Dobromir", "Dobrev", 500, 7),
                new Worker("Momchil", "Stefanov", 750, 8),
                new Worker("Stefan", "Ignatov", 500, 8)
            };
            
            var orderedWorkers = workers.OrderByDescending(w => w.MoneyPerHour());

            Console.WriteLine("\r\nList of workers sorted by money per hour. \r\n");

            foreach (var w in workers)
            {
                Console.WriteLine("{0} -> per hour - {1:0.00}", w, w.MoneyPerHour());
            }
            
            var mergedList = new List<Human>();

            mergedList.AddRange(students);
            mergedList.AddRange(workers);
            
            var sorted = mergedList.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);

            Console.WriteLine("\r\nThe two lists merged and ordered by name: \r\n");

            foreach (var h in sorted)
            {
                Console.WriteLine(h);
            }
        }
    }
}
