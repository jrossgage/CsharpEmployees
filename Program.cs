using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company NSS = new Company("NSS", DateTime.Now);
            // Create three employees
            Employee Andy = new Employee("Andy", "Collins", "Teacher", DateTime.Now);
            Employee Joe = new Employee("Joe", "Shepherd", "Lead Instructor", DateTime.Now);
            Employee Bryan = new Employee("Good", "Bryan", "Abandonist", DateTime.Now);
            // Assign the employees to the company
            NSS.Employees.Add(Andy);
            NSS.Employees.Add(Joe);
            NSS.Employees.Add(Bryan);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            NSS.ListEmployee();
        }
    }
}
