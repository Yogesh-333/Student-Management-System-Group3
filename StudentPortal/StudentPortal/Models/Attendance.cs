using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Models
{
    public class Attendance
    {
        public int Id { get; set; } // Primary key

        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }

        public string Name {  get; set; }

        public Student Student { get; set; }
    }
}
