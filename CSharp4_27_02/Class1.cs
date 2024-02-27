namespace CSharp4_27_02
{
     public class Employee
    {

        
        private string name;
        private double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double amount)
        {
            Salary += amount;
        }

        public void DecreaseSalary(double amount)
        {
            if (Salary - amount >= 0)
                Salary -= amount;
            else
                Console.WriteLine("Зменшення зарплати на цю кількість не можливе, бо зарплата стане від'ємною.");
        }

        public bool Equals(Employee otherEmployee)
        {
            return this.Name == otherEmployee.Name && this.Salary == otherEmployee.Salary;
        }

        public bool NotEquals(Employee otherEmployee)
        {
            return !this.Equals(otherEmployee);
        }

        public bool IsGreaterThan(Employee otherEmployee)
        {
            return this.Salary > otherEmployee.Salary;
        }

        public bool IsLessThan(Employee otherEmployee)
        {
            return this.Salary < otherEmployee.Salary;
        }

        public override string ToString()
        {
            return $"Співробітник: {Name}, Зарплата: {Salary}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Іван", 3000);
            Employee emp2 = new Employee("Петро", 3500);

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);

            
            emp1.IncreaseSalary(500);
            Console.WriteLine($"Після збільшення зарплати: {emp1}");

            emp2.DecreaseSalary(200);
            Console.WriteLine($"Після зменшення зарплати: {emp2}");

            
            Console.WriteLine($"Зарплати рівні: {emp1.Equals(emp2)}");

            
            Console.WriteLine($"Зарплати не рівні: {emp1.NotEquals(emp2)}");

            
            Console.WriteLine($"Зарплата співробітника 1 більша: {emp1.IsGreaterThan(emp2)}");

           
            Console.WriteLine($"Зарплата співробітника 1 менша: {emp1.IsLessThan(emp2)}");
        }
    }
}
