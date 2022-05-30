﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProject.DAL.DTOs
{
    public class EmployeeDTO
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public decimal PhonrNumber { get; set; }
        public int StatusId { get; set; }
        public int DepartmentId { get; set; }
        public bool isDeleted { get; set; }

        public override string ToString()
        {
            return $"id={id} FirstName={FirstName} SecondName={FirstName} LastName={LastName} BirthDate={BirthDate} Email={Email}" +
                   $"PhonrNumber={PhonrNumber} StatusId={StatusId} DepartmentId={DepartmentId} isDeleted={isDeleted}";
        }

    }
}