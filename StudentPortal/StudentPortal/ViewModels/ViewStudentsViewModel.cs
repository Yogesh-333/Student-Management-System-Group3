
using System.Collections.ObjectModel;
using StudentPortal.Models;
using System.Windows.Input;
using StudentPortal.Services;
using StudentPortal.Views;
using System.Text;
using System.Windows;
using System.IO;

namespace StudentPortal.MVVM.ViewModels
{
    public class ViewStudentsViewModel : BaseViewModel
    {
        private Student _selectedStudent;

        public ObservableCollection<Student> Students { get; }
        public Student SelectedStudent
        {
            get => _selectedStudent;
            set => SetProperty(ref _selectedStudent, value);
        }

        public ICommand EditStudentCommand { get; }
        public ICommand DeleteStudentCommand { get; }

        public ICommand ExportToCsvCommand { get; }

        public ViewStudentsViewModel()
        {
            Students = new ObservableCollection<Student>(Database.GetAllStudents());
            EditStudentCommand = new RelayCommand<Student>(EditStudent);
            DeleteStudentCommand = new RelayCommand<Student>(DeleteStudent);
            ExportToCsvCommand = new RelayCommand(ExportToCsv);
        }

        private void ExportToCsv()
        {
            var csvBuilder = new StringBuilder();
            csvBuilder.AppendLine("Id,Name,Age,CourseName,ContactNumber"); // Header

            foreach (var student in Students)
            {
                csvBuilder.AppendLine($"{student.Id},{student.Name},{student.Age},{student.CourseName},{student.ContactNumber}");
            }

            // Save the CSV to a file
            var filePath = @"D:\Conestoga\Software programming - brasil\Student-Management-System-Group3\StudentPortal\students.csv"; // Updated path
            try
            {
                File.WriteAllText(filePath, csvBuilder.ToString());
                MessageBox.Show($"Data exported to {filePath} successfully!", "Export Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting data: {ex.Message}", "Export Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void EditStudent(Student student)
        {
            var editStudentView = new EditStudentView
            {
                DataContext = new EditStudentViewModel(student)
            };
            editStudentView.ShowDialog();
            Students.Clear();
            foreach (var std in Database.GetAllStudents())
            {
                Students.Add(std);
            }
        }

        private void DeleteStudent(Student student)
        {
            Database.DeleteStudent(student);
            Students.Remove(student);
        }
    }
}
