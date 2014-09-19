
using System.Collections.Generic;

namespace Persons
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", 22, "pesho@abv.bg");
            Person gosho = new Person("Gosho", 19);
            Person misho = new Person("Misho", 25, "misho@gmail.com");

            System.Console.WriteLine(pesho);
            System.Console.WriteLine(gosho);
            System.Console.WriteLine(misho);
        }
    }
}
