namespace Carpets
{
    using System;

    class CarpetsMain
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int dotsCount = input / 2;
            string slash = "/";
            string backSlash = "\\";

            for (int i = 0; i < input / 2 ; i++)
            {
                dotsCount--;
                string dots = new string('.', dotsCount);

                Console.Write(dots);
                Console.Write(slash);
                Console.Write(backSlash);
                Console.Write(dots);
                Console.WriteLine();

                if (i == (input / 2) - 1)
                {
                    slash = " " + slash;
                    break;
                }

                if (slash.Length % 2 == 0)
                {
                    slash += "/";
                }
                else
                {
                    slash += " ";
                }

                if (backSlash.Length % 2 == 0)
                {
                    backSlash = "\\" + backSlash;
                }
                else
                {
                    backSlash = " " + backSlash;
                }
            }


            slash = slash.TrimEnd();
            backSlash = backSlash.TrimStart();

            if (((input / 2) & 1) == 1)
            {
                slash = slash.TrimStart();
                //backSlash = backSlash + " ";
            }
            else
            {
                backSlash = backSlash + " ";
            }

            for (int i = 0; i < input / 2; i++)
            {
                string dots = new string('.', dotsCount);
                dotsCount++;


                Console.Write(dots);
                Console.Write(backSlash);
                Console.Write(slash);
                Console.Write(dots);
                Console.WriteLine();

                slash = slash.Remove(0, 1);
                backSlash = backSlash.Remove(backSlash.Length - 1);
            }
        }
    }
}
