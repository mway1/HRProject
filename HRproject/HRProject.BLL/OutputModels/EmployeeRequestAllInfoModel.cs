namespace HRProject.BLL.OutputModels
{
    public class EmployeeRequestAllInfoModel
    {
        public int Id { get; set; }
        public int? Quantity { get; set; }
        public ProjectModel? Project { get; set; }
        public List<PositionModel> Positions { get; set; }
        public List<SkillModel> Skills { get; set; }

        public void DelleteAllSkills()
        {
            Skills.Clear();
        }

        public void DelleteAllPositions()
        {
            Positions.Clear();  
        }

        public void DeleteProject()
        {
            Project = null;
        }

        public void DeleteSkillById(int id)
        {
            for (int i = 0; i < Skills.Count; i++)
            {
                var skill = Skills[i];

                if (skill.Id == id)
                {
                    Skills.RemoveAt(id);
                }            
            }
        }

        public void DeletePositionById(int id)
        {
            for (int i = 0; i < Positions.Count; i++)
            {
                var position = Positions[i];

                if (position.Id == id)
                {
                    Positions.RemoveAt(id);
                }
            }
        }
    }
}
