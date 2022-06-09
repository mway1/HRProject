using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProject.BLL.InputModels
{
    public class EmployeeInputModel
    {
        public string FirstName { get; init; }
        public string SecondName { get; init; }
        public string LastName { get; init; }
        public DateTime BirthDate { get; init; }
        public string Email { get; init; }
        public Decimal PhoneNumber { get; init; }
        public int StatusId { get; init; }
        public int DepartmentId { get; init; }
    }
}
