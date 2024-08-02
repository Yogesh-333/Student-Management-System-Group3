using System;
using System.Collections.ObjectModel;
using StudentPortal.Services;

namespace StudentPortal.MVVM.ViewModels
{
    public class ViewAttendanceViewModel : BaseViewModel
    {
        private ObservableCollection<Models.Attendance> _attendanceRecords;
        private DateTime _selectedDate;

        public ObservableCollection<Models.Attendance> AttendanceRecords
        {
            get => _attendanceRecords;
            set => SetProperty(ref _attendanceRecords, value);
        }

        public DateTime SelectedDate
        {
            get => _selectedDate;
            set
            {
                if (SetProperty(ref _selectedDate, value)) // This should work correctly now
                {
                    LoadAttendanceForDate(value);
                }
            }
        }


        public ViewAttendanceViewModel()
        {
            SelectedDate = DateTime.Today; // Set default date to today
            LoadAttendanceForDate(SelectedDate);
        }

        public void LoadAttendanceForDate(DateTime date)
        {
            AttendanceRecords = new ObservableCollection<Models.Attendance>(Database.GetAttendanceByDate(date));
        }
    }
}
