using CompanyHierarchy.Models;

namespace CompanyHierarchy.Interfaces
{
    internal interface ICompany
    {
        void AddEmployee(Employee employee);
        void DisplayAllEmployeesInfo();
        void IncreaseSalary(double percentage);

    }
}
