using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;

namespace MvcProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: AboutController
        public ActionResult Index()
        {
            var model = new AboutViewModel // Hakkında sayfası için ViewModel oluşturuyoruz
            {
                Title = "Hakkında", // Sayfa başlığı
                Description = "Biz, kitapların gücüne inanan bir topluluğuz. Amacımız, kullanıcılarımıza çeşitli kitaplar ve yazarlar hakkında bilgi sağlamak, onların kitap okuma alışkanlıklarını teşvik etmektir.", // Sayfa açıklaması
            };

            return View(model);
        }

    }
}
