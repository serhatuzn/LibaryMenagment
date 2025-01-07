using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Models
{
    public class AboutViewModel
    {
        // Burası da hakkında kısımı için var yorumlar ver başlıklar olduğu için
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string ImageUrl { get; set; } = "";
    }

}
