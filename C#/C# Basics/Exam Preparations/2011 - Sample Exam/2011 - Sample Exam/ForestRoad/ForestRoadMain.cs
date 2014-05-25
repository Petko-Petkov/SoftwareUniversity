namespace ForestRoad
{
    using System;

    class ForestRoadMain
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int index = 0;

            for (int i = 0; i < 2 * input - 1; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    if (i == input)
                    {
                        index = input - 2;
                    }

                    if (i < input)
                    {
                        if (i == j)
                        {
                            Console.Write('*');
                        }
                        else
                        { 
                            Console.Write('.'); 
                        }                        
                    }
                    else
                    {
                        if (j == index)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }
                }

                if (i >= input)
                {
                    index--;
                }

                Console.WriteLine();
            }
        }
    }
}
