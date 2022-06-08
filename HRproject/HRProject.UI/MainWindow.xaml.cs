using HRProject.BLL;
using HRProject.BLL.Models;
using System.Windows;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using HRProject.BLL.OutputModels;

namespace HRProject.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ObservableCollection<ProjectOutputModel> Projects = new ObservableCollection<ProjectOutputModel>();
        private Controller _controller;

        public MainWindow()
        {
            this.Initialized += Window_Initialized;
            InitializeComponent();
        }

        public void Window_Initialized(object? sender, EventArgs e)
        {
            ComboBoxProjects.ItemsSource = ProjectTypes.Types;
            ListBoxProjects.ItemsSource = Projects;
            _controller = new Controller();

            LoadProjectList(_controller.GetAllProjects());

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
                _controller.GetAllProjects(ComboBoxProjects.SelectedItem.ToString()!)
            );
        }

        private void ListBoxProjects_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedProject = (ProjectModel)ListBoxProjects.SelectedItem;
            var choosenEmployeeRequests = _controller.GetEmployeeRequestAllInfoByProjectId(selectedProject.Id);
            ListBoxEmployeeRequests.ItemsSource = choosenEmployeeRequests;
        }

        private void DataGrid_EmployeeHistory_Loaded(object sender, RoutedEventArgs e)
        {

            List<EmployeeHistoryModel> historyModels = new List<EmployeeHistoryModel>();
            historyModels = _controller.GetAllEmployeeHistory();
            DataGrid_EmployeeHistory.ItemsSource = historyModels;

        }
    }
}
