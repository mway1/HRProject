using HRProject.BLL;
using HRProject.BLL.Models;
using System.Windows;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;

namespace HRProject.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Controller controller = new Controller();
        private ObservableCollection<ProjectOutputModel> Projects = new ObservableCollection<ProjectOutputModel>();

        public MainWindow()
        {
            this.Initialized += Window_Initialized;
            InitializeComponent();
        }

        public void Window_Initialized(object? sender, EventArgs e)
        {
            ComboBoxProject.ItemsSource = ProjectTypes.Types;
            ListBoxProjects.ItemsSource = Projects;

            LoadProjectList(controller.GetAllProjects());
        }

        private void LoadProjectList(List<ProjectOutputModel> projects)
        {
            Projects.Clear();
            foreach (ProjectOutputModel project in projects)
            {
                Projects.Add(project);
            }
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            _controller = new Controller();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedProject = (ProjectModel)ListBoxProjects.SelectedItem;
            var choosenEmployeeRequests = _controller.GetEmployeeRequestAllInfoByProjectId(selectedProject.Id);
            ListBoxEmployeeRequests.ItemsSource = choosenEmployeeRequests;
        }
    }
}
        private void ComboBoxProject_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            LoadProjectList(
                controller.GetAllProjects(ComboBoxProject.SelectedItem.ToString()!)
            );
        }

        private void ListBoxProjects_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
