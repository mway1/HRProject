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
        private Controller _controller = new Controller();

        private int _employeeId = 2;

        public MainWindow()
        {
            this.Initialized += Window_Initialized;
            InitializeComponent();

            Button_ChangeNameOfDepartment.IsEnabled = false;

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
        private void Button_ChangeNameOfDepartment_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void TreeView_Department_Initialized(object sender, RoutedEventArgs e)
        //{
        //    var departments = _controller.GetAllDepartment();
        //    TreeView_Department.ItemsSource = departments;
        //}

        private void DataGrid_EmployeeHistory_Loaded(object sender, RoutedEventArgs e)
        {
            var historyModels = _controller.GetAllEmployeeHistory(_employeeId);
            DataGrid_EmployeeHistory.ItemsSource = historyModels;

        }

        private void Employees_General_TabIItem_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void Employees_General_TabIItem_Initialized(object sender, EventArgs e)
        {
            

        }

        private void ComboBox_Departments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var department = (DepartmentModel)ComboBox_Departments.SelectedItem;
            var chooseEmployeeByDepartments = _controller.GetEmployeeByDepartmentId(department.id);
            ListBox_Employees.ItemsSource=chooseEmployeeByDepartments;
        }

        private void ComboBox_Departments_Initialazed(object sender, EventArgs e)
        {
            var departmentModels = _controller.GetAllDepartment();
            ComboBox_Departments.ItemsSource = departmentModels;

        }

        private void ListBox_Employees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedEmployee = (EmployeeModel)ListBox_Employees.SelectedItem;
            if(selectedEmployee != null)
            {
            var chooseEmployeeAllInfo = _controller.GetEmployeeById(selectedEmployee.id);
            TextBox_FirstName.Text = chooseEmployeeAllInfo.FirstName;
            TextBox_LastName.Text = chooseEmployeeAllInfo.LastName;
            TextBox_SecondName.Text = chooseEmployeeAllInfo.SecondName;
            TextBox_BirthDate.Text = chooseEmployeeAllInfo.BirthDate.ToString();
            TextBox_Email.Text = chooseEmployeeAllInfo.Email;
            TextBox_PhoneNumber.Text = chooseEmployeeAllInfo.PhoneNumber.ToString();
            ComboBox_Status_Tab1.SelectedIndex = chooseEmployeeAllInfo.StatusId;
            }
        }
    }
}
