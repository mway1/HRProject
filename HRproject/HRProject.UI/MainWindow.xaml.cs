using HRProject.BLL;
using HRProject.BLL.Models;
using System.Windows;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using HRProject.BLL.InputModels;
using System.Windows.Controls;

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
            ComboBox_Project_Tab1Create.ItemsSource = Projects;

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

        private void ComboBoxProjects_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            LoadProjectList(
                _controller.GetAllProjects(ComboBoxProjects.SelectedItem.ToString()!)
            );
        }

        private void ListBoxProjects_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

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

        private void ComboBox_Departments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var i = ComboBox_Departments.SelectedItem;
        }

        private void ComboBox_Departments_Initialazed(object sender, EventArgs e)
        {
            var departmentModels = _controller.GetAllDepartment();
            ComboBox_Departments.ItemsSource = departmentModels;

        }

        private void TextBox_FirstNameCreate_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBox_FirstNameCreate.Clear();
        }

        private void TextBox_FamiliayCreate_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBox_FamiliayCreate.Clear();
        }

        private void TextBox_EmailCreate_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBox_EmailCreate.Clear();
        }

        private void TextBox_PhoneNumberCreate_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBox_PhoneNumberCreate.Clear();
        }

        private void TextBox_SecondNameCreate_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBox_SecondNameCreate.Clear();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            // todo: retrieve valid StatusId
            // todo: retireve valid DepartmentId

            EmployeeInputModel employee = new EmployeeInputModel
            {
                FirstName = TextBox_FirstNameCreate.Text,
                SecondName = TextBox_SecondNameCreate.Text,
                BirthDate = DatePicker_BirthDateCreate.DisplayDate,
                Email = TextBox_EmailCreate.Text,
                PhoneNumber = TextBox_PhoneNumberCreate.Text,
                StatusId = ComboBox_Status_Tab1Create.SelectedIndex,
            };

            _controller.AddEmployee(employee);
        }

        private void ComboBox_Project_Tab1Create_TextChanged(object sender, TextChangedEventArgs e)
        {
            (sender as ComboBox).ItemsSource = _controller.SearchProjects(name: ComboBox_Project_Tab1Create.Text, limit: 5);
            (sender as ComboBox).IsDropDownOpen = true;
        }

        private void ComboBox_PositionCreate_TextChanged(object sender, TextChangedEventArgs e)
        {
            (sender as ComboBox).ItemsSource = _controller.SearchPosition(name: ComboBox_PositionCreate.Text, limit: 5);
            (sender as ComboBox).IsDropDownOpen = true;
        }

        private void ComboBox_Project_Tab1Create_GotFocus(object sender, RoutedEventArgs e)
        {
            (sender as ComboBox).IsDropDownOpen = true;
        }

        private void ComboBox_PositionCreate_GotFocus(object sender, RoutedEventArgs e)
        {
            (sender as ComboBox).IsDropDownOpen = true;
        }

        private void ComboBox_LevelCreate_GotFocus(object sender, RoutedEventArgs e)
        {
            (sender as ComboBox).IsDropDownOpen = true;
        }

        private void ComboBox_LevelCreate_TextChanged(object sender, TextChangedEventArgs e)
        {
            (sender as ComboBox).ItemsSource = _controller.LevelOfPositionSearch(name: ComboBox_LevelCreate.Text, limit: 5);
            (sender as ComboBox).IsDropDownOpen = true;
        }
    }
}
