using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using StudentPortal.Models;
using StudentPortal.Services;

namespace StudentPortal.MVVM.ViewModels
{
    public class AddAttendanceViewModel : BaseViewModel
    {
        private DateTime _date;
        private ObservableCollection<StudentAttendance> _students;

        public DateTime Date
        {
            get => _date;
            set => SetProperty(ref _date, value);
        }

        public ObservableCollection<StudentAttendance> Students
        {
            get => _students;
            set => SetProperty(ref _students, value);
        }

        public ICommand SaveAttendanceCommand { get; }

        public AddAttendanceViewModel()
        {
            Date = DateTime.Today;
            Students = new ObservableCollection<StudentAttendance>();
            SaveAttendanceCommand = new RelayCommand(SaveAttendance);
        }

        public void LoadStudentsForDate(DateTime date)
        {
            Students.Clear();
            var allStudents = Database.GetAllStudents();
            var attendances = Database.GetAttendanceByDate(date);

            foreach (var student in allStudents)
            {
                var attendance = attendances.FirstOrDefault(a => a.StudentId == student.Id);
                Students.Add(new StudentAttendance
                {
                    Id = student.Id,
                    Name = student.Name,
                    IsPresent = attendance?.IsPresent ?? false
                });
            }
        }

        private void SaveAttendance()
        {
            foreach (var studentAttendance in Students)
            {
                var attendance = new Attendance
                {
                    StudentId = studentAttendance.Id,
                    Date = Date,
                    IsPresent = studentAttendance.IsPresent,
                    Name = studentAttendance.Name // Ensure Name is set
                };
                Database.AddOrUpdateAttendance(attendance);
            }
            MessageBox.Show("Student attendance updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }

    public class StudentAttendance : BaseViewModel
    {
        private bool _isPresent;

        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsPresent
        {
            get => _isPresent;
            set => SetProperty(ref _isPresent, value);
        }
    }
}
