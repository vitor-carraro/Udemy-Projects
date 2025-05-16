namespace ExercicioFixacaoList
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += percentage * Salary / 100.0;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2:F2}", Id, Name, Salary);
        }
    }
}
