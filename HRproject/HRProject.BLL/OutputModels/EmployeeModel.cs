namespace HRProject.BLL.OutputModels
{
    public class EmployeeModel
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
    }
}
