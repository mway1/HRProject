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
        public decimal PhoneNumber { get; set; }
        public int StatusId { get; set; }
        public int DepartmentId { get; set; }
        public bool isDeleted { get; set; }

        public override string ToString()
        {
            return $"id={id} FirstName={FirstName} SecondName={FirstName} BirthDate={BirthDate} Email={Email}" +
                   $"PhonrNumber={PhoneNumber} StatusId={StatusId} DepartmentId={DepartmentId} isDeleted={isDeleted}";
        }

    }
}
