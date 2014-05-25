namespace Task02
{
    using System;

    class IlluminatiMain
    {
        static void Main()
        {
            string input = Console.ReadLine();
            long result = 0;
            int count = 0;

            foreach (var character in input)
            {
                switch (character)
                {
                    case 'A' :
                    case 'a':
                        {
                            result += 65;
                            count++;
                        }
                        break;
                    case 'E':
                    case 'e':
                        {
                            result += 69;
                            count++;
                        }
                        break;
                    case 'I':
                    case 'i':
                        {
                            result += 73;
                            count++;
                        }
                        break;
                    case 'O':
                    case 'o':
                        {
                            result += 79;
                            count++;
                        }
                        break;
                    case 'U':
                    case 'u':
                        {
                            result += 85;
                            count++;
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(count);
            Console.WriteLine(result);
        }
    }
}
