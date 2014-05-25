namespace BullsAndCows
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var secretNumber = int.Parse(Console.ReadLine());
            var bulls = int.Parse(Console.ReadLine());
            var cows = int.Parse(Console.ReadLine());

            for (int guessNumber = 1111; guessNumber < 10000; guessNumber++)
            {
                int bullsFound = GetBulls(secretNumber, guessNumber);
                int cowsFound = GetCows(secretNumber, guessNumber);

                if (bulls == bullsFound && cows == cowsFound)
                {
                    Console.Write(guessNumber);
                    Console.Write(" ");
                }
            }
        }

        private static int GetCows(int secretNumber, int guessNumber)
        {
            List<char> secChars = new List<char>();
            List<char> guessChars = new List<char>();
            int cowsCount = 0;
            
            for (int i = 0; i < 4; i++)
            {
                int digit = secretNumber % 10;
                string digitStr = "" + digit;
                char digitCh = digitStr[0];
                if (digitCh == '0')
                {
                    secChars.Insert(0, '*');
                }
                else
                {
                    secChars.Insert(0, digitCh);
                }
                
                secretNumber /= 10;

            }

            for (int i = 0; i < 4; i++)
            {
                int digit = guessNumber % 10;
                string digitStr = "" + digit;
                char digitCh = digitStr[0];
                if (digitCh == '0')
                {
                    guessChars.Insert(0, '*');
                }
                else
                {
                    guessChars.Insert(0, digitCh);
                }
                guessNumber /= 10;

            }

            for (int i = 0; i < 4; i++)
            {
                if (guessChars[i] == secChars[i])
                {
                    guessChars[i] = '*';
                    secChars[i] = '*';
                }
            }

            for (int secIndex  = 0; secIndex  < 4; secIndex ++)
            {
                for (int guessIndec = 0; guessIndec < 4; guessIndec++)
                {
                    if (secChars[secIndex] == guessChars[guessIndec] && secChars[secIndex] != '*')
                    {
                        cowsCount++;
                        secChars[secIndex] = '*';
                        guessChars[guessIndec] = '*';
                    }
                }
            }

            return cowsCount;

            //char[] secretNum = secretNumber.ToString().PadLeft(4, '0').ToCharArray();
            //char[] guessNum = guessNumber.ToString().PadLeft(4, '0').ToCharArray();
            //int cowsCount = 0;

            //for (int i = 0; i < 4; i++)
            //{
            //    if (secretNum[i] == guessNum[i])
            //    {
            //        cowlsCount++;
            //    }
            //}

            //return bullsCount;
        }
        private static int GetBulls(int secretNumber, int guessNumber)
        {
            string secretNum = secretNumber.ToString().PadLeft(4, '0');
            string guessNum = guessNumber.ToString().PadLeft(4, '0');
            int bullsCount = 0;

            for (int i = 0; i < 4; i++)
            {
                if (secretNum[i] == guessNum[i])
                {
                    bullsCount++;
                }
            }

            return bullsCount;

            //int d1 = (secretNumber / 1000) % 10;
            //int d2 = (secretNumber / 100) % 10;
            //int d3 = (secretNumber / 10) % 10;
            //int d4 = (secretNumber / 1) % 10;
            ////char sec0 = secretNumber.ToString()[0];
            ////char sec1 = secretNumber.ToString()[1];
            ////char sec2 = secretNumber.ToString()[2];
            ////char sec3 = secretNumber.ToString()[3];

            ////char guess0 = guessNumber.ToString()[0];
            ////char guess1 = guessNumber.ToString()[1];
            ////char guess2 = guessNumber.ToString()[2];
            ////char guess3 = guessNumber.ToString()[3];

            ////int bullsCount = 0;
            ////if (sec0 == guess0)
            ////{
            ////    bullsCount++;
            ////}
            ////if (sec1 == guess1)
            ////{
            ////    bullsCount++;
            ////}
            ////if (sec2 == guess2)
            ////{
            ////    bullsCount++;
            ////}
            ////if (sec3 == guess3)
            ////{
            ////    bullsCount++;
            ////}
        }
    }
}
