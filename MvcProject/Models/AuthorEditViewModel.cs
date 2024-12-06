using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Models
{
    public class AuthorEditViewModel
    {
        public int Id { get; set; }
        
        [Display(Name = "Yazar Adı")]
        [Required(ErrorMessage = "Yazar Adı Alanı Zorunludur!")]
        [MaxLength(30, ErrorMessage = "Yazar Adı 30 Karakteri Geçemez.")]
        public string FirstName { get; set; } = "";

        [Display(Name ="Yazar Soyadı")]
        [Required(ErrorMessage = "Yazar Soyadı Alanı Zorunludur!")]
        [MaxLength(20, ErrorMessage = "Yazar Soyadı 20 Karakteri Geçemez.")]
        public string LastName { get; set; } = "";

        [Display(Name = "Doğum Tarihi")]
        [Required(ErrorMessage = "Doğum Tarihi Alanı Zorunludur!")]
        [Range(typeof(DateTime), "01/01/1800", "01/01/2024", ErrorMessage = "Doğum Tarihi Tarihi, 1900 ile 2024 arasında olmalıdır.")] // Burada Kitap Yayınlanma tarihi 1900 ile 2024 arasında girilmediğinde 
        public DateTime DateOfBirth { get; set; }
    }
}