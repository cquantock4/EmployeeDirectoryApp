using EmployeeLibrary.Models;

namespace EmployeeLibrary.Data
{
    public class EmployeeData : IEmployeeData
    {
        private readonly ISqlDataAccess _db;

        public EmployeeData(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task<List<EmployeeModel>> GetEmployees()
        {
            var output = await _db.LoadDataAsync<EmployeeModel, dynamic>("dbo.spEmployee_GetAll", new { });

            return output;
        }
    }
}
