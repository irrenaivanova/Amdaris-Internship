using System.Collections;

namespace CompanyHierarchy.Models
{
    internal class EmployeeEnumerator : IEnumerator<Employee>
    {
        private int currentIndex;
        public EmployeeEnumerator(List<Employee> employee)
        {
            Employee = employee;
            currentIndex = -1;
        }

        public List<Employee> Employee { get; private set; }
        public Employee Current
        {
            get
            {
                if(currentIndex < 0  || currentIndex >= Employee.Count)
                {
                    throw new InvalidOperationException();
                }
                return Employee[currentIndex];
            }
        }
        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (currentIndex < Employee.Count - 1)
            {
                currentIndex++;
                return true;
            }

            return false;
        }

        public void Reset() => currentIndex = -1;
    }
}
