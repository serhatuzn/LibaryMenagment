using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Models
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; } = ""; // Yazarın adı ve soyadı
        public DateTime DateOfBirth { get; set; }
    }
}