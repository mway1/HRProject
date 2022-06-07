namespace HRProject.BLL.OutputModels
{
    public class EmployeeHistoryModel
    {
        public int id { get; set; }
        public int EmployeeId { get; set; }
        public string Date { get; set; }
        public string StatusId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
