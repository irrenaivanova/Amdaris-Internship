namespace CompanyHierarchy.Models
{
    internal class Developer : Employee
    {
        private const double BaseSalary = 4000;

        public Developer(string name, int age, string ProgrammingLanguage, int ExperienceLevel, int workingHours = 8) 
            : base(name, age, workingHours)
        {
            this.ProgrammingLanguage = ProgrammingLanguage;
            this.ExperienceLevel = ExperienceLevel;
        }

        public override double Salary => base.Salary + ExperienceLevel * 50;
        public string ProgrammingLanguage { get; set; }
        public int ExperienceLevel { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"{this.GetType().Name}: {this.Name}, Age: {this.Age}, Salary: {this.Salary}");
            Console.WriteLine($"Programing language: {this.ProgrammingLanguage}");
            Console.WriteLine($"Experience level: {this.ExperienceLevel} years");
        }
    }
}
