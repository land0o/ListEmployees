using System;
using System.Collections.Generic;

namespace employeesClasses
{
    // Create a custom type for Company. A company has the following properties.
    // Date founded (DateTime)
    // Company name (string)
    // Employees (List<Employee>)
    public class Company
    {
        //public Properties
        public DateTime DateFounded { get; set; }
        public string CompanyName { get; set; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees = new List<Employee>();

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string Name, DateTime Founded)
        {
            CompanyName = Name;
            DateFounded = Founded;
        }

        public void ListEmployees()
        {
            foreach (Employee Employee in Employees)
            {
                Console.WriteLine("Roci Crew Member");
                Console.WriteLine("");
                Console.WriteLine($"Employee: {Employee.FirstName} {Employee.LastName}");
                Console.WriteLine($"Postion: {Employee.Title}");
                Console.WriteLine("-----------");
            }

        }
    }
}