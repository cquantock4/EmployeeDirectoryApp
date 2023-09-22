namespace EmployeeLibrary.Data
{
    public class EmployeeData
    {
        private readonly ISqlDataAccess _db;

        public EmployeeData(ISqlDataAccess db)
        {
            _db = db;
        }
    }
}
