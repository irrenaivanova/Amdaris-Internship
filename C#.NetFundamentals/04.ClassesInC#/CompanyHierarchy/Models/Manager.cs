namespace CompanyHierarchy.Models
{
    internal class Manager : Employee
    {
        private const int TemporaryWorkingHours = 10;
        private const double BaseSalary = 7000;
        public Manager(string name, int age) 
            : base(name, age, TemporaryWorkingHours)
        {
            this.Subordinates = new List<Employee>();
        }

        public List<Employee> Subordinates { get; set; }

        public override double Salary => base.Salary + this.Subordinates.Count * 200;
        public void AddSubordinates(Employee employee)
        {
            this.Subordinates.Add(employee);
        }
        public override void Work()
        {
            base.Work();
            Console.WriteLine("This is an emergency project");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"{this.GetType().Name}: {this.Name}, Age: {this.Age}, Salary: {this.Salary}");
            Console.WriteLine("Subordinates:");
            foreach (var sub in this.Subordinates)
            {
                sub.DisplayInfo();
            }
        }
    }
}
