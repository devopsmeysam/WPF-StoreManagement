using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EmployeeDataAccess
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public EmployeeDataAccess()
        {
            ReadEmployees();
        }

        private void ReadEmployees()
        {
            Employee emp1 = new Employee()
            {
                Id = 1,
                FirstName = "Meysam",
                LastName = "Mahdavikhansari",
                PhoneNumber = 6476748899,
                Address = "ABC Bayview Ave, Toronto, A0A 0A0",
                Department = Department.Management,
                BaseSalary = 75000
            };
            Employee emp2 = new Employee()
            {
                Id = 2,
                FirstName = "Zara",
                LastName = "NSRBZGRD",
                PhoneNumber = 6476471100,
                Address = "XYZ Yonge St, Toronto, Z9Z 9Z9",
                Department = Department.Production,
                BaseSalary = 85000
            };
            Employees.Add(emp1);
            Employees.Add(emp2);
        }

        public void CreateEmployee(Employee emp)
        {
            Employees.Add(emp);
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = Employees.First(x => x.Id == id);
            Employees.Remove(employee);
        }

        public void UpdateEmployee(Employee emp)
        {
            Employee employee = Employees.First(x => x.Id == emp.Id);
            int index = Employees.IndexOf(employee);
            Employees[index] = emp;
        }

        public int GetNextId()
        {
            int index = Employees.Any() ? Employees.Max(x => x.Id) + 1 : 1;

            return index;
        }
    }
}
