/*The gravitational field of the Moon is aproximately 17% of that on the earth.
 Write a program that calculates the weight of a man on the Moon by a given weight on the Earth.*/

namespace MoonGravitation
{
    using System;

    class MoonGravitationMain
    {
        static void Main()
        {
            //Taking a weight from the user
            Console.WriteLine("Enter your weight: ");
            var weightOnEarth = double.Parse(Console.ReadLine());

            //Calculating the moon weight as a percentage from the actual weight
            var weightOnMoon = (weightOnEarth * 17) / 100;

            //Write the calculated weight on the console
            Console.WriteLine("On the Moon you would weight {0}", weightOnMoon);
        }
    }
}
