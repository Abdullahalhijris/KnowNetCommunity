using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowNetCommunity.Shared.Models
{
    public class Student
    {
        public int Id { get; set; } 
        public int StudentId { get; set; }
        public string StudantName { get; set; }
        public string? Gpa { get; set; }
        public int Email { get; set;}
        public int? PhoneNum { get; set;}

        public string PassWord { get; set;}

        public int? MajorId { get; set; }

        [ForeignKey("MajorId")]
        public Major major { get; set; }

        public Scheduler Scheduler { get; set; }

        public ICollection<Course> courses { get;}
    }
}
