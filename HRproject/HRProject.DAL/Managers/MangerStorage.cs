

namespace HRProject.DAL.Managers
{
    public class ManagerStorage
    {
        public DepartmentManager DepartmentManager { get; private set; }
        public EmployeeHistoryManager EmployeeHistoryManager { get; private set; }
        public EmployeeManager EmployeeManager { get; private set; }
        public EmployeeRequestManager EmployeeRequestManager { get; private set; }
        public ProjectManager ProjectManager { get; private set; }
        public LevelOfPositionManager LevelOfPositionManager { get; private set; }
        public PositionManager PositionManager { get; private set;}
        public CommentManager CommentManager { get; private set; }
        public StatusManager StatusManager { get; private set; }
        public Employee_PositionManager Employee_PositionManager { get; private set; }
        public Employee_SkillManager Employee_SkillManager { get; private set; }
        public SkillManager SkillManager { get; private set; }

        public ManagerStorage()
        {
            DepartmentManager = new DepartmentManager();
            EmployeeHistoryManager = new EmployeeHistoryManager();
            EmployeeRequestManager = new EmployeeRequestManager();
            EmployeeManager = new EmployeeManager();
            ProjectManager = new ProjectManager();
            PositionManager = new PositionManager();
            CommentManager = new CommentManager();
            LevelOfPositionManager = new LevelOfPositionManager();
            StatusManager = new StatusManager();
            Employee_PositionManager = new Employee_PositionManager();
            Employee_SkillManager= new Employee_SkillManager();
            SkillManager = new SkillManager();
        }
    }
}
