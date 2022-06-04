using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HRProject.BLL.OutputModels;
using HRProject.BLL.InputModels;
using HRProject.BLL;

namespace HRProject.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller _controller;

        public MainWindow()
        {
            InitializeComponent();
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
