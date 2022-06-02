using AutoMapper;
using HRProject.BLL;
using HRProject.BLL.Models;
using HRProject.BLL.Services;
using HRProject.DAL;
using System.Collections.ObjectModel;
using System.Windows;

namespace HRProject.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProjectService projectService;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            Mapper mapper = MapperConfigStorage.GetInstance();
            ProjectManager projectManager = new ProjectManager();

            projectService = new ProjectService(mapper, projectManager);
            projects = new ObservableCollection<ProjectOutputModel>(
                projectService.GetAllProjects()
            );
        }


        private ObservableCollection<ProjectOutputModel> projects;
        public ObservableCollection<ProjectOutputModel> Projects
        {
            get
            {
                if (projects == null)
                {
                    return new ObservableCollection<ProjectOutputModel>();
                }
                return projects;
            }
        }
    }
}
