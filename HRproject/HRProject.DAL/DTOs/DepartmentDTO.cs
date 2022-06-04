﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProject.DAL.DTOs
{
    public class DepartmentDTO
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public bool IsDeleted { get; set; }

        public override string ToString()
        {
            return $"id={id} Name={Name} Description={Description} IsDeleted={IsDeleted}";
        }
    }

}