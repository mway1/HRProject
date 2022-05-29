namespace HRProject.BLL.InputModels
{
    public class DeleteEmployeeRequestByIdInputModel
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int Quantity { get; set; }

        public DeleteEmployeeRequestByIdInputModel(int id, int projectId, int quantity)
        {
            Id = id;
            ProjectId = projectId;
            Quantity = quantity;
        }
    }
}