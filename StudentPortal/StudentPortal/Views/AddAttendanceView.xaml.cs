using System;
using System.Windows;
using StudentPortal.MVVM.ViewModels;

namespace StudentPortal.Views
{
    public partial class AddAttendanceView : Window
    {
        public AddAttendanceView()
        {
            InitializeComponent();
            DataContext = new AddAttendanceViewModel(); // Set DataContext to the ViewModel
        }
    }
}
