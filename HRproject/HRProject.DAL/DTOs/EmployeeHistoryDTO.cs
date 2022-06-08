namespace HRProject.DAL.DTOs
{
    public class EmployeeHistoryDTO
    {
        public int id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public string StatusId { get; set; }
        public bool IsDeleted { get; set; }
        public string StatusName { get; set; }

        public override string ToString()
        {
            return $"id={id} EmployeeId={EmployeeId} Date ={Date} StatusId={StatusId} IsDeleted={IsDeleted}";
        }
    }
}
