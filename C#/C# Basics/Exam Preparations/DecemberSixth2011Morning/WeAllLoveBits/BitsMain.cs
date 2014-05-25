namespace WeAllLoveBits
{
    using System;

    class BitsMain
    {
        static void Main()
        {
            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var number = int.Parse(Console.ReadLine());
                var output = 0;

                while (number != 0)
                {
                    output <<= 1; 
                    output += number & 1;
                    number >>= 1;
                }

                Console.WriteLine(output);
            }
        }
    }
}
