using System;

// A marketing company wants to keep record of its employees. Each record would have the following characteristics:
// First name
// Last name
// Age (0...100)
// Gender (m or f)
// Personal ID number (e.g. 8306112507)
// Unique employee number (27560000…27569999)
// Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
// Use descriptive names. Print the data at the console.

    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Ivan";
            Console.WriteLine("First name: " + firstName);

            string lastName = "Vyagov";
            Console.WriteLine("Last  name: " + lastName);

            byte age = 31;
            Console.WriteLine("       Age: " + age);

            char gender = 'm';
            Console.WriteLine("    Gender: " + gender);

            ulong idNumber = 8501210000;
            Console.WriteLine(" Personal  ID  number : " + idNumber);

            int uniqueEmpNumber = 27565555;
            Console.WriteLine("Unique employee number: " + uniqueEmpNumber);
        }
    }
