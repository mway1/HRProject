namespace HRProject.BLL.InputModels
{
    public class EmployeeRequestCreateInputModel
    {
        public int ProjectId { get; set; }
        public int Quantity { get; set; }

        public EmployeeRequestCreateInputModel(int projectId, int quantity)
        {
            ProjectId = projectId;
            Quantity = quantity;
        }
    }
}
