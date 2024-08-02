using System;
using System.Windows;
using System.Windows.Controls;
using StudentPortal.MVVM.ViewModels;

namespace StudentPortal.Views
{
    public partial class ViewAttendanceView : Window
    {
        public ViewAttendanceView()
        {
            InitializeComponent();
            this.DataContext = new ViewAttendanceViewModel(); // Set your ViewModel

            // Set the date range for the calendar
            attendanceCalendar.DisplayDateStart = DateTime.Now.AddMonths(-1);
            attendanceCalendar.DisplayDateEnd = DateTime.Now.AddMonths(1);
        }

        private void Calendar_SelectedDatesChanged(object sender, RoutedEventArgs e)
        {
            if (sender is Calendar calendar)
            {
                var selectedDates = calendar.SelectedDates;
                if (selectedDates.Count > 0)
                {
                    // Load attendance for the first selected date
                    (this.DataContext as ViewAttendanceViewModel)?.LoadAttendanceForDate(selectedDates[0]);
                }
            }
        }
    }
}
