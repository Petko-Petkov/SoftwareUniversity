/*Declare a Boolean variable called isFemale and assign an appropriate
 * value corresponding to your gender. Print it on the console.*/

namespace BooleanVariable
{
    using System;

    class BooleanVariableMain
    {
        static void Main()
        {
            bool isFemale = false;

            Console.WriteLine("What is your gender M or F");

            string gender = Console.ReadLine().ToUpper();

            if (gender == "M")
            {
                Console.WriteLine("You are female - {0}", isFemale);
            }
            else if(gender == "F")
            {
                isFemale = true;
                Console.WriteLine("You are female - {0}", isFemale);
            }
            else
            {
                Console.WriteLine("Enter a correct value for gender - M or F");
            }
        }
    }
}
