using System.Collections.ObjectModel;
using StudentPortal.Services;

namespace StudentPortal.MVVM.ViewModels
{
    public class ViewAttendanceViewModel : BaseViewModel
    {
        private ObservableCollection<Models.Attendance> _attendanceRecords;

        public ObservableCollection<Models.Attendance> AttendanceRecords
        {
            get => _attendanceRecords;
            set => SetProperty(ref _attendanceRecords, value);
        }

        public ViewAttendanceViewModel()
        {
            AttendanceRecords = new ObservableCollection<Models.Attendance>(Database.GetAllAttendance());
        }
    }
}
