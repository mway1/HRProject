namespace HRProject.DAL.DTOs
{
    public class EmployeeRequestDTO
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? Quantity { get; set; }
        public bool IsDeleted { get; set; }
    }
}
