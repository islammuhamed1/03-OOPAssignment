using System.Globalization;

namespace _03_OOPAssignment
{
     class Employee
     {
        public int ID { get; set; }
        public string? Name { get; set; }
        public Security Security { get; set; }
        public decimal Salary { get; set; }
        public HireDate? HireDate { get; set; }
        public Gender Gender { get; set; }
        public Employee(int id, string name, Security _security, decimal salary, HireDate hireDate, Gender gender)
        {
            ID = id;
            Name = name;
            Security = _security;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, \nSecurity: {Security}, Salary: {Salary.ToString("C", CultureInfo.CurrentCulture)}, \nHire Date: {HireDate}, Gender: {Gender}";
        }
    }
}
