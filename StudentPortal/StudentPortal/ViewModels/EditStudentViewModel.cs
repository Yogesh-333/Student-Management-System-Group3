
using System;
using System.Windows.Input;
using StudentPortal.Models;
using StudentPortal.Services;


namespace StudentPortal.MVVM.ViewModels
{
    public class EditStudentViewModel : BaseViewModel
    {
        private string _name;
        private int _age;
        private string _coursename;
        private string _contactnumber;
        private readonly Student _student;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        public string CourseName
        {
            get => _coursename;
            set => SetProperty(ref _coursename, value);
        }  public string ContactNumber
        {
            get => _contactnumber;
            set => SetProperty(ref _contactnumber, value);
        }
             

        public int Age
        {
            get => _age;
            set => SetProperty(ref _age, value);
        }

        public ICommand SaveChangesCommand { get; }

        public EditStudentViewModel(Student student)
        {
            _student = student;
            Name = student.Name;
            Age = student.Age;
            CourseName = student.CourseName;
            ContactNumber = student.ContactNumber;

            SaveChangesCommand = new RelayCommand(SaveChanges);
        }

        private void SaveChanges()
        {
            _student.Name = Name;
            _student.Age = Age;
            _student.CourseName = CourseName;
            _student.ContactNumber = ContactNumber;
            Database.UpdateStudent(_student);
        }
    }
}
