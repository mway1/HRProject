using HRProject.BLL;
using HRProject.BLL.Models;
using System.Windows;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using HRProject.BLL.InputModels;
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

            Button_AddNewDepartment.IsEnabled = false;
            TextBox_NameOfNewDepartment.IsEnabled = false;

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

        private void DataGrid_EmployeeHistory_Loaded(object sender, RoutedEventArgs e)
        {

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
            ListBox_Employees.ItemsSource = chooseEmployeeByDepartments;
            TextBox_DepartmentDescription.Text = department.Description;
        }

        private void ComboBox_Departments_Initialazed(object sender, EventArgs e)
        {
            var departmentModels = _controller.GetAllDepartment();
            ComboBox_Departments.ItemsSource = departmentModels;

        }
        private void Button_AddDepartment_Click(object sender, RoutedEventArgs e)
        {
            Button_AddNewDepartment.IsEnabled = true;
            TextBox_NameOfNewDepartment.IsEnabled = true;
        }
        private void Button_AddNewDepartment_Click(object sender, RoutedEventArgs e)
        {
            DepartmentModel department = new DepartmentModel();
            department.Name = TextBox_NameOfNewDepartment.Text;
            department.Description = TextBox_DepartmentDescription.Text;
            department.IsDeleted = false;
            _controller.AddDepartment(department);
        }


        private void ListBox_Employees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedEmployee = (EmployeeModel)ListBox_Employees.SelectedItem;
            if (selectedEmployee != null)
            {
            var chooseEmployeeAllInfo = _controller.GetEmployeeById(selectedEmployee.id);
            TextBox_FirstName.Text = chooseEmployeeAllInfo.FirstName;
            TextBox_LastName.Text = chooseEmployeeAllInfo.SecondName;
            TextBox_SecondName.Text = chooseEmployeeAllInfo.LastName;
            TextBox_BirthDate.Text = chooseEmployeeAllInfo.BirthDate.ToString();
            TextBox_Email.Text = chooseEmployeeAllInfo.Email;
            TextBox_PhoneNumber.Text = chooseEmployeeAllInfo.PhoneNumber.ToString();
            ComboBox_Status_Tab1.SelectedIndex = chooseEmployeeAllInfo.StatusId;
            var historyModels = _controller.GetAllEmployeeHistory(selectedEmployee.id);
            DataGrid_EmployeeHistory.ItemsSource = historyModels;
            }
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
            EmployeeInputModel employee = new EmployeeInputModel
            {
                FirstName = TextBox_FirstNameCreate.Text,
                SecondName = TextBox_SecondNameCreate.Text,
                BirthDate = DatePicker_BirthDateCreate.DisplayDate,
                Email = TextBox_EmailCreate.Text,
                PhoneNumber = TextBox_PhoneNumberCreate.Text,
                //StatusId = 
                //DepartmentId = 
            };
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

        
    }
}
