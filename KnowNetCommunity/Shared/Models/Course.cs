using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowNetCommunity.Shared.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        public string CorurseName { get; set; }


      
       public int MajorId { get; set; }
       
        
        [ForeignKey("MajorId")]
        Major major { get; set; }

        public ICollection<Student> students { get; set; }
    }
}
