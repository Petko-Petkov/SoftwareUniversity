namespace WeAllLoveBits
{
    using System;

    class Program
    {
        static void Main()
        {
            var inputCount = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < inputCount; i++)
            {
                result = 0;

                var input = int.Parse(Console.ReadLine());

                while (input > 0)
                {
                    var lastBit = input & 1;
                    input = input >> 1;
                    result = result << 1;
                    result = result | lastBit;
                }

                Console.WriteLine(result);
            }
        }
    }
}
