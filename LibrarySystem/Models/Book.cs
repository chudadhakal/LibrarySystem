using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string SSBN { get; set; }
        public string Publisher { get; set; }
     
        public DateTime Published { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
