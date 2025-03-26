namespace CompanyHierarchy.Models
{
    internal class Intern : Employee
    {
        private const int TemporaryWorkingHours = 6;
        public Intern(string name, int age, string university) 
            : base(name, age, TemporaryWorkingHours)
        {
            this.University = university;
        }

        public string University { get; set; }

        public override double Salary => base.Salary * 0.6;
        public override void Work()
        {
            base.Work();
            Console.WriteLine($"{this.Name} has study commitments at the university.");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"{this.GetType().Name}: {this.Name}, Age: {this.Age}, Salary: {this.Salary}");
            Console.WriteLine($"University: {this.University}");
        }
    }
}
