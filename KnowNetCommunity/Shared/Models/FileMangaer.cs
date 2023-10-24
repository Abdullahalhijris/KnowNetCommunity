using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowNetCommunity.Shared.Models
{
    public class FileMangaer
    {
        [Key]
        public int FileId { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
    }
}
