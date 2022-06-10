namespace HRProject.BLL.OutputModels
{
    public class Employee_PostionModel
    {
        public int id { get; set; }
        public int EmployeeId { get; set; }
        public int PositionId { get; set; }
        public string Name { get; set; }
        public int LevelOfPositionID { get; set; }
        public string LevelOfPositionName { get; set; }
    }
}
