using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Models
{
    public class NewBookViewModel
    {
        [DisplayName("Kitap İsmi")]
        [Required(ErrorMessage = "Kitap İsmi Alanı Zorunludur!")]
        [MaxLength(20, ErrorMessage = "Kitabın İsmi 20 Karakteri Geçemez.")]
        public string Title { get; set; } = "";

        [DisplayName("Yazar İsmi")]
        public int AuthorId { get; set; }

        [DisplayName("Kitap Türü")]
        [Required(ErrorMessage = "Kitap Türünü Alanı Zorunludur!")]
        [MaxLength(20, ErrorMessage = "Kitabın Türü 20 Karakteri Geçemez.")]
        public string Genre { get; set; } = "";

        [DisplayName("Yayın Tarihi")]
        [Required(ErrorMessage = "Yayın Tarihi Alanı Zorunludur!")]
        [Range(typeof(DateTime), "01/01/1800", "01/01/2024", ErrorMessage = "Yayın Tarihi, 1900 ile 2024 arasında olmalıdır.")] // Burada Kitap Yayınlanma tarihi 1900 ile 2024 arasında girilmediğinde 
        public DateTime PublishDate { get; set; }

        [DisplayName("ISBN")]
        [Required(ErrorMessage = "ISBN Alanı Zorunludur")]
        public string ISBN { get; set; } = "";

        [DisplayName("Kopya Sayısı")]
        [Required(ErrorMessage = "Kopya Sayısı Alanı Zorunludur")]
        public int CopiesAvailable { get; set; }
    }
}

