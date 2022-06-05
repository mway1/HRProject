using HRProject.BLL;
using HRProject.BLL.Models;
using HRProject.BLL.Services;
using System.Windows;
using System.Collections.ObjectModel;


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
            projectService = ProjectService.GetInstance();
            ComboBoxProject.ItemsSource = ProjectTypes.Types;

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

        private void ComboBoxProject_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var projects = projectService.GetAllProjects(ComboBoxProject.SelectedItem.ToString()!);
            ListBoxProjects.ItemsSource = projects;
        }       

        private void ListBoxProjects_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
           
        }
    }
}
