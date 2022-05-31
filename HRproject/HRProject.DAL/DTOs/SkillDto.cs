using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProject.DAL.DTOs
{
    public class SkillDto
    { 
        public int  Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
