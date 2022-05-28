using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using HRProject.DAL.DTOs;

namespace HRProject.DAL.Managers
{
    public class EmployeeManager
    {
        public List<EmployeeDTO> GetAllEmployee()
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                return connection.Query<EmployeeDTO>(
                    StoredProcedures.Employee_GetAll,
                    commandType: System.Data.CommandType.StoredProcedure)
                    .ToList();
                )
            }
        }
    }
}
