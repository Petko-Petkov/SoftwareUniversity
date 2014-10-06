namespace Animals
{
    using System;
    using System.Linq;

    class AnimalsMain
    {
        static void Main()
        {
            Animal[] animals = new Animal[] 
            {
                new Kitten("maca", 14),
                new Tomcat("Tom", 6),
                new Kitten("Name", 11),
                new Frog("Kermit", 15, "male"),
                new Dog("Sharo", 7, "Male"),
                new Dog("Balkan", 4, "Male"), 
                new Kitten("Maci", 7),
                new Tomcat("Tomas", 9),
                new Dog("Mailo", 11, "Male"),
                new Frog("Princess", 15, "female"),
                new Dog("Chara", 7, "female")
            };
            
            var animalsGroups =
                from animal in animals
                group animal by animal.GetType().Name into gr
                select new { GroupName = gr.Key, AverageAge = gr.ToList().Average(an => an.Age) };

            foreach (var a in animalsGroups)
            {
                Console.WriteLine("{0} - average age {1:N2}", a.GroupName, a.AverageAge);
            }
        }
    }
}
