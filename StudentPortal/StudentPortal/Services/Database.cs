using StudentPortal.Data;
using StudentPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentPortal.Services
{
    public static class Database
    {
        public static void AddStudent(Student student)
        {
            using (var context = new StudentPortalDbContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        public static List<Student> GetAllStudents()
        {
            using (var context = new StudentPortalDbContext())
            {
                return context.Students.ToList();
            }
        }

        public static void UpdateStudent(Student student)
        {
            using (var context = new StudentPortalDbContext())
            {
                context.Students.Update(student);
                context.SaveChanges();
            }
        }

        public static void DeleteStudent(Student student)
        {
            using (var context = new StudentPortalDbContext())
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
        }

        public static void AddAttendance(Attendance attendance)
        {
            using (var context = new StudentPortalDbContext())
            {
                context.AttendanceRecords.Add(attendance);
                context.SaveChanges();
            }
        }

        public static List<Attendance> GetAllAttendance()
        {
            using (var context = new StudentPortalDbContext())
            {
                return context.AttendanceRecords.ToList();
            }
        }

        public static List<Attendance> GetAttendanceByDate(DateTime date)
        {
            using (var context = new StudentPortalDbContext())
            {
                // Filter attendance records by the specified date
                return context.AttendanceRecords
                    .Where(a => a.Date.Date == date.Date) // Compare only the date part
                    .ToList();
            }
        }
    }
}
