using System;

namespace w4__employee_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager manager = new EmployeeManager(5); 

            manager.AddEmployee(new Employee { EmployeeId = 1, Name = "Varun", Position = "Developer", Salary = 60000 });
            manager.AddEmployee(new Employee { EmployeeId = 2, Name = "Riya", Position = "Manager", Salary = 90000 });
            manager.AddEmployee(new Employee { EmployeeId = 3, Name = "Amit", Position = "Designer", Salary = 50000 });

            Console.WriteLine("\nAll Employees:");
            manager.TraverseEmployees();

            Console.WriteLine("\nSearching for Employee with ID 2:");
            var emp = manager.SearchEmployee(2);
            if (emp != null)
                Console.WriteLine($"Found: {emp.Name}, {emp.Position}, ₹{emp.Salary}");
            else
                Console.WriteLine("Employee not found.");

            Console.WriteLine("\nDeleting Employee with ID 1:");
            manager.DeleteEmployee(1);

            Console.WriteLine("\nAll Employees after deletion:");
            manager.TraverseEmployees();
        }
    }
}
