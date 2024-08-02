using System;
using System.Windows;
using System.Windows.Controls;
using StudentPortal.MVVM.ViewModels;

namespace StudentPortal.Views
{
    public partial class AddAttendanceView : Window
    {
        public AddAttendanceView()
        {
            InitializeComponent();
            this.DataContext = new AddAttendanceViewModel();
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is Calendar calendar && calendar.SelectedDate.HasValue)
            {
                (this.DataContext as AddAttendanceViewModel)?.LoadStudentsForDate(calendar.SelectedDate.Value);
            }
        }
    }
}
