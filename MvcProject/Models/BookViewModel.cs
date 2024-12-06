using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Models
{
    public class BookViewModel
    {
        public int BookId { get; set; }
        public string Title { get; set; } = "";
        public string Genre { get; set; } = "";
        public string? AuthorName { get; set; }  = ""; // Yazar adı soyadı
        public DateTime PublishDate { get; set; } = DateTime.MinValue;
    }

}