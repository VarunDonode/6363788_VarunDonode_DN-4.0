using System;

namespace w4__employee_management
{
    public class EmployeeManager
    {
        private Employee[] employees;
        private int count = 0;

        public EmployeeManager(int size)
        {
            employees = new Employee[size];
        }

        public void AddEmployee(Employee e)
        {
            if (count < employees.Length)
            {
                employees[count++] = e;
                Console.WriteLine("Employee added successfully.");
            }
            else
            {
                Console.WriteLine("Employee array is full.");
            }
        }

        public Employee SearchEmployee(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].EmployeeId == id)
                {
                    return employees[i];
                }
            }
            return null;
        }

        public void TraverseEmployees()
        {
            if (count == 0)
            {
                Console.WriteLine("No employees found.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"ID: {employees[i].EmployeeId}, Name: {employees[i].Name}, Position: {employees[i].Position}, Salary: {employees[i].Salary}");
            }
        }

        public void DeleteEmployee(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].EmployeeId == id)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        employees[j] = employees[j + 1];
                    }
                    employees[count - 1] = null;
                    count--;
                    Console.WriteLine("Employee deleted.");
                    return;
                }
            }
            Console.WriteLine("Employee not found.");
        }
    }
}
