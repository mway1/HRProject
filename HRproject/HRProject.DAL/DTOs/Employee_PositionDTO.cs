using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProject.DAL.DTOs
{
    public class Employee_PositionDTO
    {
        public int id { get; set; }
        public int EmployeeId { get; set; }
        public int PositionId { get; set; }
        public int LevelOfPositionID { get; set; }
    }
}
