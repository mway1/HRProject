using HRProject.BLL;
using HRProject.BLL.Models;
using HRProject.BLL.Services;
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
        ProjectService projectService;
        public MainWindow()
        {
            projectService = ProjectService.GetInstance();

            this.Initialized += Window_Initialized;
            InitializeComponent();
        }

        private ObservableCollection<ProjectOutputModel> Projects = new ObservableCollection<ProjectOutputModel>();

        public void Window_Initialized(object? sender, EventArgs e)
        {
            ComboBoxProject.ItemsSource = ProjectTypes.Types;
            ListBoxProjects.ItemsSource = Projects;

            LoadProjectList(projectService.GetAllProjects());
        }

        private void LoadProjectList(List<ProjectOutputModel> projects)
        {
            Projects.Clear();
            foreach (ProjectOutputModel project in projects)
            {
                Projects.Add(project);
            }
        }

        private void ComboBoxProject_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            LoadProjectList(
                projectService.GetAllProjects(ComboBoxProject.SelectedItem.ToString()!)
            );
        }

        private void ListBoxProjects_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
