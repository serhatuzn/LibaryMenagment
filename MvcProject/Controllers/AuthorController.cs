using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;

namespace MvcProject.Controllers
{
    public class AuthorController : Controller
    {
        public ActionResult Index()
        {
             List<Author> authors = Data.Authors.OrderBy(x => x.AuthorId).ToList(); // Yazarları Id'ye göre sıralıyoruz
            return View(authors); // Yazarları View'a gönderiyoruz
        }

        [HttpGet]
        public ActionResult NewAuthor() // Yeni Yazar Ekleme Sayfası
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewAuthor(NewAuthorViewModel author) // Yeni Yazar Ekleme Sayfası Post işlemi için
        {
            if (ModelState.IsValid) // Eğer Model geçerliyse
            {
                Author newAuthor = new Author() // Yeni bir yazar oluşturuyoruz
                {
                    AuthorId = Data.Authors.Max(b => b.AuthorId) + 1, // Yazar Id'sini en büyük Id'nin bir fazlası olarak belirliyoruz
                    FirstName = author.FirstName, // Yazar Adı
                    LastName = author.LastName, // Yazar Soyadı
                    DateOfBirth = author.DateOfBirth, // Yazar Doğum Tarihi
                };
                Data.Authors.Add(newAuthor); // Yazarı ekliyoruz
                return RedirectToAction("Index"); // Ekledikten sonra bu controllerın Indexıne Git
            }
            return View(); // Geçerli Değilse
        }

        [HttpGet]
        public ActionResult EditAuthor(int id) // Yazar Düzenleme Sayfası
        {
            Author? author = Data.Authors.FirstOrDefault(a => a.AuthorId == id); // Yazarı buluyoruz
            if (author == null) // Eğer yazar bulunamazsa
                return NotFound(); // 404 Hata kodu dönecek

            AuthorEditViewModel vm = new AuthorEditViewModel() // Yazarı düzenlemek için ViewModel oluşturuyoruz
            {
                Id = author.AuthorId, // Yazar Id'si
                FirstName = author.FirstName, // Yazar Adı
                LastName = author.LastName, // Yazar Soyadı
                DateOfBirth = author.DateOfBirth, // Yazar Doğum Tarihi
            };
            return View(vm); // Yazar mevcutsa, Model ile View'ı döndürüyoruz
        }

        [HttpPost]
        public ActionResult EditAuthor(AuthorEditViewModel Vm)
        {
            Author? author = Data.Authors.FirstOrDefault(b => b.AuthorId == Vm.Id);
            if (author == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                author.FirstName = Vm.FirstName;
                author.LastName = Vm.LastName;
                author.DateOfBirth = Vm.DateOfBirth;

                return RedirectToAction("Index"); // Bu controllerın Indexıne Git
            }
            return View(Vm); // Geçerli Değilse
        }

        [HttpGet]
        public ActionResult DeleteAuthor(int id)
        {
            Author? author = Data.Authors.FirstOrDefault(a => a.AuthorId == id);

            if (author == null)
                return NotFound(); // Yazar bulunamazsa 404 dönecek

            return View(author); // Yazar mevcutsa, Model ile View'ı döndürüyoruz
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Author? author = Data.Authors.FirstOrDefault(a => a.AuthorId == id);

            if (author == null)
                return NotFound(); // Yazar bulunamazsa 404 dönecek

            Data.Authors.Remove(author); // Yazar siliniyor
            return RedirectToAction("Index"); // Silme işlemi başarılıysa Index'e yönlendir
        }
        // Yazar detayları için GetAction
        [HttpGet]
        public ActionResult DetailsAuthor(int id)
        {
            Author? author = Data.Authors.FirstOrDefault(b => b.AuthorId == id);
            if (author == null)
                return NotFound();

            return PartialView(author);
        }
    }

}


