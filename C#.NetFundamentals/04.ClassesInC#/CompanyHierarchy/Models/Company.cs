using CompanyHierarchy.Interfaces;
using System.Collections;

namespace CompanyHierarchy.Models
{
    internal class Company : ICompany, IEnumerable<Employee>
    {
        public Company()
        {
           this.Employees = new List<Employee>();
        }

        public List<Employee> Employees { get; set; }
        public void IncreaseSalary(double percentage)
        {
            if (percentage < 0)
            {
                throw new ArgumentException("The raise percentage value must be a positive number.");
            }
            foreach (var employee in this.Employees)
            {
               employee.IncreaseSalary(percentage);
               Console.WriteLine($"{employee.Name} now has a new salary of {employee.Salary}.");
            }
        }

        public void AddEmployee(Employee employee)
        {
            this.Employees.Add(employee);
        }

        public void AddEmployee(List<Employee> employees)
        {
            this.Employees.AddRange(employees);
        }

        public void DisplayAllEmployeesInfo()
        {
            this.Employees.Sort();
            Console.WriteLine("Our company: ");
            foreach (var employee in this.Employees)
            {
                employee.DisplayInfo();
                Console.WriteLine(new string('-', 10));
            }
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            return new EmployeeEnumerator(this.Employees);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
