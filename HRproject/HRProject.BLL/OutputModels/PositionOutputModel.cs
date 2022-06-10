namespace HRProject.BLL.OutputModels
{
    public class PositionOutputModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}