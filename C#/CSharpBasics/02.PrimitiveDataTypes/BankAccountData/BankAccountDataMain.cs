/*A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
 * bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the 
 * information for a single bank account using the appropriate data types and descriptive names.*/

namespace BankAccountData
{
    using System;

    class BankAccountDataMain
    {
        static void Main()
        {
            string firstname = Console.ReadLine();
            string middleName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string holderName = firstname + " " + middleName + " " + lastName;
            decimal balance = decimal.Parse(Console.ReadLine());
            string bankName = Console.ReadLine();
            string IBAN = Console.ReadLine();
            long firstCCNumber = long.Parse(Console.ReadLine());
            long secondCCNumber = long.Parse(Console.ReadLine());
            long thiedCCNumber = long.Parse(Console.ReadLine());
        }
    }
}
