using System;

// A company has name, address, phone number, fax number, web site and manager. 
// The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints it back on the console.

class CompanyInfo
{
    static void Main()
    {
        string compName = Console.ReadLine();
        string compAddress = Console.ReadLine();
        string phoneNum = Console.ReadLine();
        string faxNum = Console.ReadLine();
        string webSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        string managerAge = Console.ReadLine();
        string managerPhone = Console.ReadLine();

        Console.WriteLine(compName);
        Console.WriteLine("Address: {0}", compAddress);
        Console.WriteLine("Tel. {0}", phoneNum);
        Console.WriteLine(faxNum == string.Empty ? "Fax: (no fax)" : "Fax: {0}", faxNum);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}
