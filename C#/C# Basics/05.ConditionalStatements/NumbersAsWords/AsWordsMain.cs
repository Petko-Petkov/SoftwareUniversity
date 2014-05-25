using System;

class ConverNumberToText
{
    static void Main()
    {
        int number = -1;
        bool checkInput = true;
        string inputNumber = "";
        string result = "";
        int modifier = 0;
        while (checkInput && number < 0 || number > 999)
        {
            Console.Clear();
            Console.Write("Please input number between 0 - 999: ");
            inputNumber = Console.ReadLine();
            checkInput = int.TryParse(inputNumber, out number);
        }

        if (inputNumber.Length > 2)
        {
            switch (inputNumber[modifier])
            {
                case '1': result = result + "a"; break;
                case '2': result = result + "two"; break;
                case '3': result = result + "three"; break;
                case '4': result = result + "four"; break;
                case '5': result = result + "five"; break;
                case '6': result = result + "six"; break;
                case '7': result = result + "seven"; break;
                case '8': result = result + "eight"; break;
                case '9': result = result + "nine"; break;
            }
            if (!(inputNumber[1] == '0' && inputNumber[2] == '0'))
            {
                result = result + " hundred and ";
            }
            else
            {
                if (inputNumber == "100")
                {
                    result = "one";
                }
                result = result + " hundred";
            }
            modifier = 1;

        }
        if (inputNumber.Length > 1)
        {
            switch (inputNumber[modifier])
            {
                case '1':
                    {
                        switch (inputNumber[modifier + 1])
                        {
                            case '0': result = result + "ten"; break;
                            case '1': result = result + "eleven"; break;
                            case '2': result = result + "twelve"; break;
                            case '3': result = result + "thirteen"; break;
                            case '4': result = result + "fourteen"; break;
                            case '5': result = result + "fifteen"; break;
                            case '6': result = result + "sixteen"; break;
                            case '7': result = result + "seventeen"; break;
                            case '8': result = result + "eighteen"; break;
                            case '9': result = result + "nineteen"; break;
                        }
                        Console.WriteLine("English pronunciation of {0} is: {1}", inputNumber, result);
                        return;
                    }
                    break;
                case '2': result = result + "twenty"; break;
                case '3': result = result + "thirty"; break;
                case '4': result = result + "forty"; break;
                case '5': result = result + "fifty"; break;
                case '6': result = result + "sixty"; break;
                case '7': result = result + "seventy"; break;
                case '8': result = result + "eighty"; break;
                case '9': result = result + "ninety"; break;
            }
            if (inputNumber[modifier] != '0' && inputNumber[modifier + 1] != '0')
            {
                result = result + "  ";
            }
            modifier = 1;
        }
        if (inputNumber.Length > 0)
        {
            switch (inputNumber[modifier])
            {
                case '1': result = result + "one"; break;
                case '2': result = result + "two"; break;
                case '3': result = result + "three"; break;
                case '4': result = result + "four"; break;
                case '5': result = result + "five"; break;
                case '6': result = result + "six"; break;
                case '7': result = result + "seven"; break;
                case '8': result = result + "eight"; break;
                case '9': result = result + "nine"; break;
            }
        }
        if (inputNumber == "0")
        {
            result = "zero";
        }
        Console.WriteLine("\n\nEnglish pronunciation of {0} is: {1}\n\n\n", inputNumber, result);
    }
}