namespace StringBuilderExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ExtensionsMain
    {
        static void Main()
        {
            StringBuilder str = new StringBuilder("shushumiga shushu shu");

            Console.WriteLine(str);
            Console.WriteLine(str.Substring(2, 8));
            str.RemoveText("shu");
            Console.WriteLine(str);

            str.AppendAll(new List<string>() {"Pesho", " ", "Gosho", "?"} );
            str.AppendAll(new List<int>() { 1, 2, 3, 4, 5 });

            Console.WriteLine(str);
        }
    }
}
