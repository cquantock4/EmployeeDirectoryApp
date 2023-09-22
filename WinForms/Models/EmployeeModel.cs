namespace WinForms.Models;

public class EmployeeModel
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Title { get; set; }

    public override string ToString()
    {
       return $"{Id}: {FirstName} {LastName} ({Title})";
    }
}
