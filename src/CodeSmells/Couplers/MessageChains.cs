// A.K.A the Law of Demeter
// Its about the encapsulation, reduces coupling.
// Refactor is "hide delegate", inverse is "remove middle-man"

public class Department
{
    public string Name { get; }
    public string Manager { get; set; }
    public Department(string name, string manager)
    {
        Name = name;
        Manager = manager;
    }
}

public class Employee
{
    public string Name { get; }
    public Department Department { get; }
    public Employee(string name, Department department)
    {
        Name = name;
        Department = department;
    }
}

public class BetterEmployee : Employee
{
    public BetterEmployee(string name, Department department) : base(name, department) {}
    public string Manager
    {
        get
        {
            if (Department.Manager is null)
            {
                return "Dogbert"; //aka ceo
            }
            return Department.Manager;
        }
    }
}