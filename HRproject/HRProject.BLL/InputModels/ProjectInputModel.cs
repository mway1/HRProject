namespace HRProject.BLL.InputModels
{
    public class ProjectInputModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public decimal PhoneNumber { get; set; }
        public int StatusId { get; set; }
        public int DepartmentId { get; set; }
        public bool isDeleted { get; set; }
    }
}
