namespace SOLID_1
{
    public class Employee
    {
        public string Name { get; set; }
        public Role Position { get; set; }

        public Employee(string name, Role position = Role.NISHIY_BOT)
        {
            Name = name;
            Position = position;
        }
    }

    public enum Role
    {
        NISHIY_BOT = 0,
        JUNIOR = 2,
        MIDDLE = 7,
        SENIOR = 14,
        ARCHITECTOR = 20
    }

    public class SalaryCalculator
    {
        private const int MIN_SALARY = 19242;

        public int CalculateSalary(Employee employee)
        {
            return MIN_SALARY * (int)employee.Position;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Denis");
            SalaryCalculator calculator = new SalaryCalculator();
            int salary = calculator.CalculateSalary(employee);
            Console.WriteLine($"Зпшка {employee.Name}: {salary}.");

            Employee employee1 = new Employee("Сын маминой подруги", Role.ARCHITECTOR);
            int salary1 = calculator.CalculateSalary(employee1);
            Console.WriteLine($"Зпшка {employee1.Name}: {salary1}.");
        }
    }

}
