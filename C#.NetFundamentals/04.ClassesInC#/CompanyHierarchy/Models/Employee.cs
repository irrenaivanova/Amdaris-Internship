using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Models
{
    internal abstract class Employee : IEmployee
    {
        private string name;
        private int age;

        protected Employee(string name, int age, int workingHours = 8)
        {
            this.name = name;
            this.age = age;
            WorkingHours = workingHours;
        }

        public virtual double Salary { get; }
        public int WorkingHours { get; set; }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }
                name = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (age < 18)
                {
                    throw new ArgumentException("Employee must be at least 18 years old to work.");
                }
                age = value;
            }
        }
        public abstract void DisplayInfo();
        public virtual void Work()
        {
            Console.WriteLine($"{this.Name} is working {this.WorkingHours} a day.");
        }
    }
}
