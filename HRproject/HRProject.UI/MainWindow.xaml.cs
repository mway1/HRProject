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
        private ObservableCollection<StatusOutputModel> Statuses = new ObservableCollection<StatusOutputModel>();
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
            ComboBox_Status_Tab1Create.ItemsSource = Statuses;
            ComboBox_Project_Tab1Create.ItemsSource = Projects;

            LoadProjectList(_controller.GetAllProjects());
            LoadStatusList(_controller.GetAllStatus());
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

        private void LoadStatusList(List<StatusOutputModel> statuses)
        {
            Statuses.Clear();
            foreach (StatusOutputModel status in statuses)
            {
                Statuses.Add(status);
            }
        }

        private void ComboBoxProjects_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            LoadProjectList(
                _controller.GetAllProjects(ComboBoxProjects.SelectedItem.ToString()!)
            );
        }

        private void ComboBox_Status_Tab1Create_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
            if (ComboBox_Departments.SelectedItem != null)
            {
            var department = (DepartmentModel)ComboBox_Departments.SelectedItem;
            var chooseEmployeeByDepartments = _controller.GetEmployeeByDepartmentId(department.id);
            ListBox_Employees.ItemsSource = chooseEmployeeByDepartments;
            TextBox_DepartmentDescription.Text = department.Description;
            }
            
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
            Button_AddDepartment.IsEnabled = false;
        }
        private void Button_AddNewDepartment_Click(object sender, RoutedEventArgs e)
        {
            Button_AddDepartment.IsEnabled = true;
            TextBox_NameOfNewDepartment.IsEnabled = false;
            DepartmentInputModel department = new DepartmentInputModel();
            department.Name = TextBox_NameOfNewDepartment.Text;
            department.Description = TextBox_DepartmentDescription.Text;
            department.isDeleted = false;
            _controller.AddDepartment(department);
            TextBox_NameOfNewDepartment.Clear();
            TextBox_DepartmentDescription.Clear();
            DepartmentRefresh();
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
            TextBox_Position.Text = _controller.GetEmployee_PostionById(selectedEmployee.id).Name;
            TextBox_Level.Text = _controller.GetEmployee_PostionById(selectedEmployee.id).LevelOfPositionName;
            ListBox_Skills.ItemsSource = _controller.GetEmployee_SkillById(selectedEmployee.id);
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
            DepartmentModel department = (DepartmentModel)ComboBox_Departments.SelectedItem;
            StatusOutputModel status = (StatusOutputModel)ComboBox_Status_Tab1Create.SelectedItem;

            string cleanPhoneNumber = TextBox_PhoneNumberCreate.Text.Replace(" ", "").Replace("+", "").Replace("-", "");
            Decimal PhoneNumber;


            if (!Decimal.TryParse(cleanPhoneNumber, out PhoneNumber))
            {
                MessageBox.Show("Phone number format is invalid");
                return;
            }
            if (status == null)
            {
                MessageBox.Show("Choose status first");
                return;
            }
            if (department == null)
            {
                MessageBox.Show("Choose department first");
                return;
            }
            if (DatePicker_BirthDateCreate.SelectedDate == null)
            {
                MessageBox.Show("Choose birthdate first");
            }

            EmployeeInputModel employee = new EmployeeInputModel
            {
                FirstName = TextBox_FirstNameCreate.Text,
                SecondName = TextBox_SecondNameCreate.Text,
                LastName = TextBox_FamiliayCreate.Text,
                BirthDate = DatePicker_BirthDateCreate.DisplayDate,
                Email = TextBox_EmailCreate.Text,
                PhoneNumber = PhoneNumber,
                StatusId = status.Id,
                DepartmentId = department.id,
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
            if (ComboBox_PositionCreate.Text != "")
            {
                (sender as ComboBox).ItemsSource = _controller.SearchPosition(name: ComboBox_PositionCreate.Text, limit: 5);
            }
            else
            {
                (sender as ComboBox).ItemsSource = _controller.GetAllPosition();
            }
            (sender as ComboBox).IsDropDownOpen = true;
        }

        private void ComboBox_Project_Tab1Create_GotFocus(object sender, RoutedEventArgs e)
        {
            (sender as ComboBox).IsDropDownOpen = true;
        }

        private void ComboBox_PositionCreate_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ComboBox_PositionCreate.Text != "")
            {
                (sender as ComboBox).ItemsSource = _controller.SearchPosition(name: ComboBox_PositionCreate.Text, limit: 5);
            }
            else
            {
                (sender as ComboBox).ItemsSource = _controller.GetAllPosition();
            }
            (sender as ComboBox).IsDropDownOpen = true;
        }

        private void ComboBox_LevelCreate_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ComboBox_LevelCreate.Text != "")
            {
                (sender as ComboBox).IsDropDownOpen = true;
            }
            else
            {
                (sender as ComboBox).ItemsSource = _controller.LevelOfPositions_GetAll();
            }
            (sender as ComboBox).IsDropDownOpen = true;
        }

        private void ComboBox_LevelCreate_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ComboBox_LevelCreate.Text != "")
            {
                (sender as ComboBox).IsDropDownOpen = true;
            }
            else
            {
                (sender as ComboBox).ItemsSource = _controller.LevelOfPositions_GetAll();
            }
            (sender as ComboBox).IsDropDownOpen = true;
        }

        private void Button_DeleteDepartment_Click(object sender, RoutedEventArgs e)
        {
            DepartmentModel department = (DepartmentModel)ComboBox_Departments.SelectedItem;
            _controller.DeleteDepartment(department.id);
            ComboBox_Departments.SelectedIndex=-1;
            TextBox_DepartmentDescription.Clear();
            DepartmentRefresh();
        }

        private void DepartmentRefresh()
        {
            List<DepartmentModel> departmentList = _controller.GetAllDepartment();
            ComboBox_Departments.ItemsSource = departmentList;
        }

        private void Button_DeleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            EmployeeModel employee = (EmployeeModel)ListBox_Employees.SelectedItem;
            _controller.DeleteEmployee(employee.id);
        }
    }
}
