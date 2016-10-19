using System;

// Task Description:
// A marketing company wants to keep record of its employees. Each record would have the following characteristics:
// First name, Last name, Age(0...100), Gender(m or f), Personal ID number(e.g. 8306112507), Unique employee number(27560000…27569999)
// Declare the variables needed to keep the information for a single employee.Print the data at the console.

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Marko";
            string lastName = "Polo";
            byte age = 35;
            char gender = 'm';
            object numberID = 8306112507;
            object numberEmployee = 27560606;

            Console.WriteLine("First Name: {0} \nLast Name: {1} \nAge: {2} \nGender: {3} \nID Number: {4} \nEmployee Number: {5}", firstName, lastName, age, gender, numberID, numberEmployee);     
        }
    }
}
