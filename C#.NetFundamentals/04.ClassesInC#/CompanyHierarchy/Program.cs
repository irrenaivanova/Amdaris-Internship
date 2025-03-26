using CompanyHierarchy.Models;

var intern1 = new Intern("Intern1", 22, "FMI");
var intern2 = new Intern("Intern2", 34, "UASG");
var intern3 = new Intern("Intern3", 19, "FMI");
var developer1 = new Developer("Developer1", 22, "C#", 2);
var developer2 = new Developer("Developer2", 34, "Java", 3);
var developer3 = new Developer("Developer3", 19, "C#", 4);
var manager1 = new Manager("Manager1", 22);
var manager2 = new Manager("Manager2", 34);
var manager3 = new Manager("Manager3", 19);
manager1.AddSubordinates(intern1);
manager2.AddSubordinates(developer1);
manager3.AddSubordinates(intern2);
manager3.AddSubordinates(intern3);

var company = new Company();
company.AddEmployee(new List<Employee>() { intern1, intern2, intern3, manager1, manager2, manager3,developer1, developer2, developer3 });

company.DisplayAllEmployeesInfo();

company.IncreaseSalary(20);
company.DisplayAllEmployeesInfo();

foreach (var employee in company)
{
    employee.Work();
}