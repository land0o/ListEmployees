using System;

namespace employeesClasses
{
    // Create a custom type for Employee. An employee has the following properties.
    // First name (string)
    // Last name (string)
    // Title (string)
    // Start date (DateTime)
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate = DateTime.Now;
    }
}