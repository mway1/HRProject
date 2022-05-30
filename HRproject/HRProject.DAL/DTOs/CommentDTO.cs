using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProject.DAL.DTOs
{
    public class CommentDTO
    {
        public int id { get; set; }
        public string Description { get; set; }
        public int EmployeeId { get; set; }
        public bool isDeleted { get; set; }
        public override string ToString()
        {
            return $"id={id} Description={Description} EmployeeId={EmployeeId} isDeleted={isDeleted}";
        }

    }
}
