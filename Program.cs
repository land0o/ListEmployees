using System;

namespace employeesClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company RocinanteINC = new Company("Rocinante INC", new DateTime(2350, 04, 09));

            // Create three employees
            Employee Crew1 = new Employee();
            {
                Crew1.FirstName = "James";
                Crew1.LastName = "Holden";
                Crew1.Title = "Captain";
                Crew1.StartDate = DateTime.Now;
            };
            Employee Crew2 = new Employee();
            {
                Crew2.FirstName = "Naomi";
                Crew2.LastName = "Nagata";
                Crew2.Title = "Executive Officer";
                Crew2.StartDate = DateTime.Now;
            };
            Employee Crew3 = new Employee();
            {
                Crew3.FirstName = "Alex";
                Crew3.LastName = "Kamal";
                Crew3.Title = "Pilot";
                Crew3.StartDate = DateTime.Now;
            };

            // Assign the employees to the company
            RocinanteINC.Employees.Add(Crew1);
            RocinanteINC.Employees.Add(Crew2);
            RocinanteINC.Employees.Add(Crew3);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            RocinanteINC.ListEmployees();
        }
    }
}
