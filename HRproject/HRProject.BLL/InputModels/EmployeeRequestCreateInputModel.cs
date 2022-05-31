using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProject.BLL.InputModels
{
    public class EmployeeRequestCreateInputModel
    {
        public int ProjectId { get; set; }
        public int Quantity { get; set; }

        public EmployeeRequestCreateInputModel(int projectId, int quantity)
        {
            ProjectId = projectId;
            Quantity = quantity;
        }
    }
}
