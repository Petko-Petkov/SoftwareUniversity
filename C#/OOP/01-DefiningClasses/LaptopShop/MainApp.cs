namespace LaptopShop
{
    using System;

    class MainApp
    {
        static void Main()
        {
            Laptop lenovoYoga2Pro = new Laptop("Lenovo Yoga 2 Pro", 2259.0m, "Lenovo", "Intel Core i3", "Intel HD  Graphics 4400", new Battery("4 cell", 4.5), "13.3");
            
            Console.WriteLine(lenovoYoga2Pro);
        }
    }
}
