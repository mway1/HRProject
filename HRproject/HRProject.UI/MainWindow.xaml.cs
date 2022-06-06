using HRProject.BLL;
using System;
using System.Windows;
using System.Windows.Controls;

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
            _controller = new Controller();
            InitializeComponent();

            Button_ChangeNameOfDepartment.IsEnabled = false;

        }

        private void Button_ChangeNameOfDepartment_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TreeView_Department_Initialized(object sender, EventArgs e)
        {
            TextBlock newItem = new TextBlock() { Text = "Best of the best" };
            TreeView_Department.Items.Add(newItem);
        }

    }
}
