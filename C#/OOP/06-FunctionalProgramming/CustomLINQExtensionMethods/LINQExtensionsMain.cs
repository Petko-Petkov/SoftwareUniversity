namespace CustomLINQExtensionMethods
{
    using System;
    using System.Collections.Generic;

    class LINQExtensionsMain
    {
        static void Main()
        {
            List<int> nums = new List<int>() { 12, 1234, 1235, 15, 524, 0, 230 };
            var selectedNums = nums.WhereNot(x => x % 5 == 0);

            foreach (var num in selectedNums.Repeat(2))
            {
                Console.WriteLine(num);
            }

            List<string> names = new List<string>() { "Pesho", "Gosho", "Tosho", "Misho", "Petko", "Martin" };
            List<string> suffixes = new List<string>() { "sho" };

            var sortedNames = names.WhereEndsWith(suffixes);

            foreach (var name in sortedNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
