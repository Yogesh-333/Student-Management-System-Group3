
using System;
using System.Windows.Controls;
using System.Windows.Input;
using StudentPortal.Services;

namespace StudentPortal.MVVM.ViewModels
{
    public class AddStudentViewModel : BaseViewModel
    {
        private string _name;
        private int _age;
        private string _coursename;
        private string _contactnumber;
        private DateTime _dateOfBirth;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        public string CourseName
        {
            get => _coursename;
            set => SetProperty(ref _coursename, value);
        }
        public string ContactNumber
        {
            get => _contactnumber;
            set => SetProperty(ref _contactnumber, value);
        }


        public int Age
        {
            get => _age;
            set => SetProperty(ref _age, value);
        }


        public ICommand AddStudentCommand { get; }

        public AddStudentViewModel()
        {
            AddStudentCommand = new RelayCommand(AddStudent);
        }

        private void AddStudent()
        {
            Database.AddStudent(new Models.Student
            {
                Name = Name,
                Age = Age,
                CourseName = CourseName,
                ContactNumber = ContactNumber
            });
        }
    }
}
