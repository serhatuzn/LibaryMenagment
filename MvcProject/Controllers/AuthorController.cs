using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;

namespace MvcProject.Controllers
{
    public class AuthorController : Controller
    {
        public ActionResult Index()
        {
             List<Author> authors = Data.Authors.OrderBy(x => x.AuthorId).ToList();// Sort the book details in descending order by the number of available copies.
            return View(authors);
        }

        [HttpGet]
        public ActionResult NewAuthor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewAuthor(NewAuthorViewModel author)
        {
            if (ModelState.IsValid)
            {
                Author newAuthor = new Author()
                {
                    AuthorId = Data.Authors.Max(b => b.AuthorId) + 1,
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    DateOfBirth = author.DateOfBirth,
                };
                Data.Authors.Add(newAuthor);
                return RedirectToAction("Index"); // Ekledikten sonra bu controllerın Indexıne Git
            }
            return View(); // Geçerli Değilse
        }

        [HttpGet]
        public ActionResult EditAuthor(int id)
        {
            Author? author = Data.Authors.FirstOrDefault(a => a.AuthorId == id);
            if (author == null)
                return NotFound();

            AuthorEditViewModel vm = new AuthorEditViewModel()
            {
                Id = author.AuthorId,
                FirstName = author.FirstName,
                LastName = author.LastName,
                DateOfBirth = author.DateOfBirth,
            };
            return View(vm);
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


