﻿/** Write a program to read your age from the 
 * console and print how old you will be after 10 years.*/

namespace AgeAfterTenYears
{
    using System;

    class AgeInTenYearsMain
    {
        static void Main()
        {
            Console.WriteLine("Enter your age in the format yyyy.MM.dd: ");

            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;
            
            int age = today.Year - birthDay.Year;

            if (birthDay.Month > today.Month || ((birthDay.Month == today.Month) && (birthDay.Day > today.Day)))
            {
                age--;
            }

            Console.WriteLine("Your age is {0}. After ten years you will be {1} .", age, age + 10);
        }
    }
}
