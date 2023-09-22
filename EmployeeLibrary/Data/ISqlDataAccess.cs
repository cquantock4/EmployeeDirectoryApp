﻿namespace EmployeeLibrary.Data
{
    public interface ISqlDataAccess
    {
        Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionStringName = "Default");
    }
}