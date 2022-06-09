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

        private Controller controller = new Controller();
        private ObservableCollection<ProjectOutputModel> Projects = new ObservableCollection<ProjectOutputModel>();
        private Controller _controller = new Controller();

        private int _employeeId = 2;

        public MainWindow()
        {
            this.Initialized += Window_Initialized;
            InitializeComponent();
        }

        public void Window_Initialized(object? sender, EventArgs e)
        {
            ComboBoxProjects.ItemsSource = ProjectTypes.Types;
            ListBoxProjects.ItemsSource = Projects;
            ComboBox_Project_Tab1Create.ItemsSource = Projects;

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

        private void ComboBoxProjects_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            LoadProjectList(
                controller.GetAllProjects(ComboBoxProjects.SelectedItem.ToString()!)
            );
        }

        private void ListBoxProjects_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_EmployeeHistory_Loaded(object sender, RoutedEventArgs e)
        {
            var historyModels = _controller.GetAllEmployeeHistory(_employeeId);

            DataGrid_EmployeeHistory.ItemsSource = historyModels;

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
            (sender as ComboBox).ItemsSource = controller.SearchProjects(name: ComboBox_Project_Tab1Create.Text, limit: 5);
            (sender as ComboBox).IsDropDownOpen = true;
        }

        private void ComboBox_PositionCreate_TextChanged(object sender, TextChangedEventArgs e)
        {
            (sender as ComboBox).ItemsSource = controller.SearchPosition(name: ComboBox_PositionCreate.Text, limit: 5);
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
