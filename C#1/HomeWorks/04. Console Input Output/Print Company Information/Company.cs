//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class Company
{
    static void Main()
    {
        string companyName;
        string companyAddress;
        string phoneNumber;
        string faxNumber;
        string webSite;
        string managerFirstName;
        string managerLastName;
        string managerAge;
        string managerPhone;

        //input from console
        Console.Write("Company name: ");
        companyName = Console.ReadLine();

        Console.Write("Company address: ");
        companyAddress = Console.ReadLine();

        Console.Write("Phone number: ");
        phoneNumber = Console.ReadLine();

        Console.Write("Fax number: ");
        faxNumber = Console.ReadLine();

        Console.Write("Web site: ");
        webSite = Console.ReadLine();

        Console.Write("Manager first name: ");
        managerFirstName = Console.ReadLine();

        Console.Write("Manager last name: ");
        managerLastName = Console.ReadLine();

        Console.Write("Manager age: ");
        managerAge = Console.ReadLine();

        Console.Write("Manager phone: ");
        managerPhone = Console.ReadLine();

        //output the data in the console
        if (string.IsNullOrEmpty(faxNumber) == true || faxNumber.Length < 6)
        {
            faxNumber = "(no fax)";
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', 20));
        Console.WriteLine("\n{0} \nAddress: {1} \nTel. {2} \nFax: {3} \nWeb site: {4} \nManager: {5} {6} (age: {7}, tel. {8})",
            companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerAge, managerPhone);
    }
}