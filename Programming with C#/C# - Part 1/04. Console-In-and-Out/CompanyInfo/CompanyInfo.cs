﻿using System;

// Task Description:
// A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age
// and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.
// You will input each piece of information about the company on a separate line, in the same order as in the example:
//    Company name
//    Company address
//    Phone number
//    Fax number
//    Web site
//    Manager first name
//    Manager last name
//    Manager age
//    Manager phone


namespace CompanyInfo
{
    class CompanyInfo
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string webSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            int managerAge = int.Parse(Console.ReadLine());
            string managerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAddress);
            Console.WriteLine("Tel. " + phoneNumber);
            
            if (faxNumber == String.Empty)
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: " + faxNumber);
            }

            Console.WriteLine("Web site: " + webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName,
              managerLastName, managerAge, managerPhone);
        }
    }
}
