using System.Net.Http.Json;
using WinForms.Models;

namespace WinForms;

public partial class EmployeeDirectory : Form
{
    public EmployeeDirectory()
    {
        InitializeComponent();
    }

    private async void EmployeeDirectory_Load(object sender, EventArgs e)
    {
        using var client = new HttpClient();
        var results = await client.GetFromJsonAsync<List<EmployeeModel>>("https://localhost:7002/employees");

        employeeList.DataSource = results;
    }
}