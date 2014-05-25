namespace Neurons
{
    using System;

    class NeuronsMain
    {
        static void Main()
        {
            while (true)
            {
                long input = long.Parse(Console.ReadLine());

                if (input == 0)
                {
                    Console.WriteLine(0);
                    continue;
                }

                long lastBit = input & 1;
                string result = string.Empty;

                if (input == -1)
                {
                    return;
                }

                while (input > 0)
                {
                    lastBit = input & 1;

                    if (lastBit == 1)
                    {
                        lastBit ^= 1;

                        while (input > 0)
                        {
                            lastBit = input & 1;
                            lastBit ^= 1;
                            result = lastBit + result;
                            input >>= 1;
                        }
                    }

                    result = lastBit + result;
                    input >>= 1;
                }

                Console.WriteLine(Convert.ToInt64(result, 2));
            }
        }
    }
}
//using System;

//class NeuronMapping
//{

//    static void Main()
//    {

//        const uint BIT = (uint)1;


//        while (true)
//        {
//            string input = Console.ReadLine();
//            if (input == "-1")
//            {
//                break;
//            }

//            uint thisRow = uint.Parse(input);
//            uint output = 0;
//            bool isInside = false;
//            int oneBitSequences = 0;

//            for (int ii = 0; ii < 32; ++ii)
//            {
//                uint mask = (BIT << ii);

//                if ((thisRow & mask) == 0)
//                {
//                    if (isInside)output |= mask;
//                    continue;
//                }
//                else
//                {
//                    oneBitSequences += 1;
//                    isInside = !isInside;
//                    while (ii < 32 && (thisRow & (BIT << ii)) != 0)
//                    {
//                        ii += 1;
//                    }
//                    // back off one step,
//                    // the for loop will increment the counter anyway
//                    ii -= 1;
//                }
//            }

//            if (oneBitSequences != 2)
//            {
//                output = 0;
//            }

//            Console.WriteLine(output);
//        }
//    }
//}

