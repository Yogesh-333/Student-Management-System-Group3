
using System;
using System.Windows.Input;
using StudentPortal.Models;
using StudentPortal.Services;


namespace StudentPortal.MVVM.ViewModels
{
    public class EditStudentViewModel : BaseViewModel
    {
        private string _name;
        private string _email;
        private DateTime _dateOfBirth;
        private readonly Student _student;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set => SetProperty(ref _dateOfBirth, value);
        }

        public ICommand SaveChangesCommand { get; }

        public EditStudentViewModel(Student student)
        {
            _student = student;
            Name = student.Name;
            Email = student.Email;
            DateOfBirth = student.DateOfBirth;

            SaveChangesCommand = new RelayCommand(SaveChanges);
        }

        private void SaveChanges()
        {
            _student.Name = Name;
            _student.Email = Email;
            _student.DateOfBirth = DateOfBirth;
            Database.UpdateStudent(_student);
        }
    }
}
