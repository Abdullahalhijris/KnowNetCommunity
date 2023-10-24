using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowNetCommunity.Shared.Models
{
    public class Major
    {
        public int MajorId { get; set; }
        public string MajorName { get; set; }

        public List<Student> students { get; set; }

        List<Major> majors { get; set; }

    }
}
