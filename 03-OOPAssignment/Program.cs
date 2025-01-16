namespace _03_OOPAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            employees[0] = new Employee(1, "Islam", Security.Guest, 87452.50m, new HireDate(1, 1, 2025), Gender.Male);
            employees[1] = new Employee(2, "Hamada", Security.DBA, 14852, new HireDate(1, 6, 2025), Gender.Male);
            employees[2] = new Employee(3, "Salma", Security.Secretary, 500.15m, new HireDate(25, 11, 2013), Gender.Female);

            Console.WriteLine("Employees Before Sorting:");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i]);
            }

            Console.WriteLine("-------------------------------------------");
            int Sorting = 0;
            for (int i = 0; i < employees?.Length - 1; i++)
            {
                for (int j = i + 1; j < employees?.Length; j++)
                {
                    if (employees?[i].HireDate?.DateTime() > employees?[j].HireDate?.DateTime())
                    {
                        Employee emp = employees[i];
                        employees[i] = employees[j];
                        employees[j] = emp;
                        Sorting++;
                    }
                }
            }

            Console.WriteLine("Employees After Sorting:");
            for (int i = 0; i < employees?.Length; i++)
            {
                Console.WriteLine(employees[i]);
            }
            Console.WriteLine($"\nCount Of Boxing And UnBoxing: {Sorting}");

        }
    }
}
