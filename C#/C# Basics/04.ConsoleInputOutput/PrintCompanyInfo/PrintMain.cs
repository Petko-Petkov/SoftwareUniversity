/*A company has name, address, phone number, fax number, web site and manager. 
 * The manager has first name, last name, age and a phone number. 
 * Write a program that reads the information about a company and its manager and prints it back on the console.*/

namespace PrintCompanyInfo
{
    using System;

    class PrintMain
    {
        static void Main()
        {
            Console.WriteLine("Input company name: ");
            var companyName = Console.ReadLine();
            Console.WriteLine("Input company address: ");
            var companyAddress = Console.ReadLine();
            Console.WriteLine("Company phone number: ");
            var companyPhoneNumber = Console.ReadLine();
            Console.WriteLine("Input company fax number: ");
            var companyFaxNumber = Console.ReadLine();
            Console.WriteLine("Input company web site: ");
            var companyWebSite = Console.ReadLine();
            Console.WriteLine("Input company manager: ");
            var companyManager = Console.ReadLine();

            Console.WriteLine("Input manager's first name: ");
            var managerFirstName = Console.ReadLine();
            Console.WriteLine("Input manager's last name: ");
            var managerLastName = Console.ReadLine();
            Console.WriteLine("Input manager's age: ");
            var managerAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Input manager's phone number: ");
            var managerPhoneNumber = Console.ReadLine();

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", companyName, companyAddress, companyPhoneNumber, companyFaxNumber, companyWebSite, companyManager);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhoneNumber);
        }
    }
}
