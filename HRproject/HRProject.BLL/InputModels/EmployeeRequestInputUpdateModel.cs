using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProject.BLL.InputModels
{
    public class EmployeeRequestInputUpdateModel
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int Quantity { get; set; }
        public bool IsDeleted { get; set; }

        public EmployeeRequestInputUpdateModel(int id, int projectId, int quantity, bool isDeleted)
        {
            Id = id;
            ProjectId = projectId;
            Quantity = quantity;
            IsDeleted = isDeleted;
        }
    }    
}