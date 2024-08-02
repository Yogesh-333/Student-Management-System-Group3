using System;
using System.Windows.Input;
using StudentPortal.Models;
using StudentPortal.Services;

namespace StudentPortal.MVVM.ViewModels
{
    public class AddAttendanceViewModel : BaseViewModel
    {
        private int _studentId;
        private DateTime _date; // Initialize this to today's date
        private bool _isPresent;

        public int StudentId
        {
            get => _studentId;
            set => SetProperty(ref _studentId, value);
        }

        public DateTime Date
        {
            get => _date;
            set => SetProperty(ref _date, value);
        }

        public bool IsPresent
        {
            get => _isPresent;
            set => SetProperty(ref _isPresent, value);
        }

        public ICommand AddAttendanceCommand { get; }

        public AddAttendanceViewModel()
        {
            Date = DateTime.Today; // Initialize the Date property to today's date
            AddAttendanceCommand = new RelayCommand(AddAttendance);
        }

        private void AddAttendance()
        {
            var attendance = new Attendance
            {
                StudentId = StudentId,
                Date = Date,
                IsPresent = IsPresent
            };
            Database.AddAttendance(attendance);
        }
    }
}
