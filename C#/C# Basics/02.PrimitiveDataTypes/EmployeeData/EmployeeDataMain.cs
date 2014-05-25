/*A marketing company wants to keep record of its employees. Each record would have the following characteristics:
•	First name
•	Last name
•	Age (0...100)
•	Gender (m or f)
•	Personal ID number (e.g. 8306112507)
•	Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.*/

namespace EmployeeData
{
    using System;

    class EmployeeDataMain
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int personlIdNumber = int.Parse(Console.ReadLine());
            int employeeIdNumber = int.Parse(Console.ReadLine());

            if (age < 0 || age > 100)
            {
                Console.WriteLine("Enter a valid age in the range of 0 - 100.");
            }

            if (employeeIdNumber < 27560000 || employeeIdNumber > 27569999)
            {
                Console.WriteLine("Invalid empployee number ID! Enter a valid one in the range of 27560000 and 27569999.");
            }

            if (personlIdNumber.ToString().Length != 10)
            {
                Console.WriteLine("Invalid personal ID number");
            }
        }
    }
}
