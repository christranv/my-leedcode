namespace LeedCode;

public class Company
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public List<Cofounder>? Cofounders { get; set; }
    public List<Employee>? Employees { get; set; }
}

public class Cofounder
{
    public string? Id { get; set; }
    public string? Name { get; set; }
}

public class Employee
{
    public string? Id { get; set; }
    public string? FullName { get; set; }
    public int AnualSalary { get; set; }
    public Position? Position { get; set; }
    public List<Benefit>? Benefits { get; set; }
}

public class Position
{
    public string? Id { get; set; }
    public string? Description { get; set; }
}

public class Benefit
{
    public string? Id { get; set; }
    public int Additional { get; set; }
    public string? Description { get; set; }
}