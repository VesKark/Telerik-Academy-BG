using System;
using System.Globalization;

// Task Description:
// Write a program that reads your birthday (in the format MM.DD.YYYY) from the console and prints
// on the console how old are you now and how old will you be after 10 years.

class AgeNowAndFuture
{
    static void Main()
    {
        string date = Console.ReadLine();
        string format = "MM.dd.yyyy";
        int afterTenYears;
        int ageNow;

        DateTime birthdate = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);

        ageNow = DateTime.Today.Year - birthdate.Year;
        afterTenYears = ageNow + 10;
        
        if (birthdate.Month < DateTime.Today.Month || 
            birthdate.Month == DateTime.Today.Month && birthdate.Day <= DateTime.Today.Day)
        {
            Console.WriteLine(ageNow);
            Console.WriteLine(afterTenYears);
        }

        if (birthdate.Month > DateTime.Today.Month || 
            birthdate.Month == DateTime.Today.Month && birthdate.Day > DateTime.Today.Day)
        {
            Console.WriteLine(ageNow - 1);
            Console.WriteLine(afterTenYears - 1);
        }                      
    }
}