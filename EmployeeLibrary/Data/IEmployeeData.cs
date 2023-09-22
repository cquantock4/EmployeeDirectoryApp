using EmployeeLibrary.Models;

namespace EmployeeLibrary.Data
{
    public interface IEmployeeData
    {
        Task<List<EmployeeModel>> GetEmployees();
    }
}