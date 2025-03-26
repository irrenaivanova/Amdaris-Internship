using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Models
{
    internal abstract class Employee : IEmployee, IComparable<Employee>
    {
        private const double BaseSalary = 3000;
        private string name;
        private int age;
        private double salary;

        protected Employee(string name, int age, int workingHours = 8)
        {
            this.name = name;
            this.age = age;
            WorkingHours = workingHours;
            this.salary = BaseSalary;
        }

        public virtual double Salary => salary;
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
        public void IncreaseSalary(double percentage)
        {
            if (percentage < 0)
            {
                throw new ArgumentException("The raise percentage value must be a positive number.");
            }
            salary *= (1 + percentage / 100);
        }
        public abstract void DisplayInfo();
        public virtual void Work()
        {
            Console.WriteLine($"{this.Name} is working {this.WorkingHours} hours a day.");
        }

        public int CompareTo(Employee? other)
        {
            if (other is null)
            {
                return 1;
            }       
            int thisPriority  = GetPositionPriority(this.GetType().Name);
            int otherPriority = GetPositionPriority(other.GetType().Name);
            return thisPriority.CompareTo(otherPriority);
        }

        private int GetPositionPriority(string position)
        {
            switch (position)
            {
                case "Manager":
                    return 1;
                case "Developer":
                    return 2;
                case "Intern":
                    return 3;
                default:
                    return int.MaxValue;
            }
        }
    }
}
