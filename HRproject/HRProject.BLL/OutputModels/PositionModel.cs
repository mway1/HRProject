namespace HRProject.BLL.OutputModels
{
    public class PositionModel
    {
        public int Id { get; set; }
        public int PositionLevelId { get; set; }
        public string Name { get; set; }
        public string PositionLevel { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
