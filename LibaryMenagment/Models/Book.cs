using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = "";
        public int AuthorId { get; set; }
        public string Genre { get; set; } = "";
        public DateTime PublishDate { get; set; }
        public string ISBN { get; set; } = "";
        public int CopiesAvailable { get; set; }

        public Author? Author { get; set; } // Yazar İle ilişkilendirme
    }
}