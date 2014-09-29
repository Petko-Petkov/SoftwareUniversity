using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Catalogue
{
    class CatalogueMain
    {
        static void Main()
        {
            //defining some components
            Component processor1 = new Component("Intel i3", 450.56m, "stava");
            Component processor2 = new Component("Intel i5", 520.97m);
            Component processor3 = new Component("Intel i7", 650m, "много як");
            Component motherBoard1 = new Component("Asrock", 100.59m);
            Component motherBoard2 = new Component("ASUS", 150m, "some description");
            Component motherBoard3 = new Component("GigaByte", 180.66m, "more description");
            Component video1 = new Component("Radeon", 190.25m, "some description");
            Component video2 = new Component("Nvidia", 290.35m);
            Component video3 = new Component("Digger", 650.25m, "some description");
            Component memory1 = new Component("2gb", 25.89m, "some description");
            Component memory2 = new Component("4gb", 45.12m, "some description");
            Component memory3 = new Component("8gb", 70.59m);
            Component hdd1 = new Component("HDD 500Gb", 80.23m, "middle");
            Component hdd2 = new Component("HDD 2TB", 180.56m, "huge");
            Component ssd = new Component("SSD 240GB", 300m, "fast");

            //creating pc
            Computer pc1 = new Computer("First", new List<Component>() { processor1, motherBoard3, video2, memory1, hdd2 });
            Computer pc2 = new Computer("Second", new List<Component>() { processor2, motherBoard2, video1, memory2, hdd1 });
            Computer pc3 = new Computer("Third", new List<Component>() { processor3, motherBoard1, video3, memory3, ssd });

            List<Computer> pcCtalogue = new List<Computer>(){pc1, pc2, pc3};

            var sortedByPrice = pcCtalogue.OrderBy(pc => pc.Price);

            foreach (var pc in sortedByPrice)
            {
                Console.WriteLine("{0} -> price = {1}lv.",pc.Name, pc.Price);
                Console.WriteLine(pc);
            }
        }
    }
}
