using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcProject.Models;

namespace MvcProject.Controllers
{
    public class BookController : Controller
    {
        // GET: BookController
        public ActionResult Index()
        {
            // Kitapları alıp, yazar adını ekleyerek ViewModel oluşturuyoruz
            var books = Data.Books.Select(b => new // Kitapları alıp, yazar adını ekleyerek ViewModel oluşturuyoruz
            {
                b.BookId,
                b.Title,
                b.Genre,
                b.PublishDate,
                b.ISBN,
                b.CopiesAvailable,
                AuthorName = Data.Authors.FirstOrDefault(a => a.AuthorId == b.AuthorId)?.FullName,
            }).ToList();

            var bookViewModels = books.Select(b => new BookViewModel
            {
                BookId = b.BookId,
                Title = b.Title,
                Genre = b.Genre,
                PublishDate = b.PublishDate,
                AuthorName = b.AuthorName
            }).ToList(); // ViewModel listesine dönüştürüyoruz

            return View(bookViewModels); // ViewModel listesini View'a gönderiyoruz
        }


        [HttpGet]
        public ActionResult NewBook()
        {
            ViewBag.Author = Data.Authors // Yazarları ViewBag'e ekliyoruz
                .Select(x => new SelectListItem // SelectListItem oluşturuyoruz çünkü DropDownList oluşturacağız DropDownList için SelectListItem kullanılır
                {
                    Value = x.AuthorId.ToString(), // Yazarın Id'si
                    Text = $"{x.FullName}"         // Yazarın adı
                })
                .ToList();

            return View();
        }


        [HttpPost]
        public ActionResult NewBook(NewBookViewModel book) // Yeni Kitap Ekleme Sayfası Post işlemi için
        {
            if (ModelState.IsValid)
            {
                Book newBook = new Book() // Yeni bir kitap oluşturuyoruz
                {
                    BookId = Data.Books.Max(b => b.BookId) + 1,
                    Title = book.Title,
                    AuthorId = book.AuthorId,
                    Genre = book.Genre,
                    PublishDate = book.PublishDate,
                    ISBN = book.ISBN,
                    CopiesAvailable = book.CopiesAvailable,
                };
                Data.Books.Add(newBook);
                return RedirectToAction("Index"); // Ekledikten sonra bu controllerın Indexıne Git
            }
            // Model hatalıysa, ViewBag'i doldurup sayfayı yeniden yükler:
            ViewBag.Author = Data.Authors
                .Select(a => new SelectListItem
                {
                    Value = a.AuthorId.ToString(), // Yazarın ID'sini değer olarak atar.
                    Text = $"{a.FullName}"                  // Yazarın adını metin olarak atar.
                })
                .ToList();
            return View(); // Geçerli Değilse
        }

        [HttpGet]
        public ActionResult EditBook(int id)
        {
            Book? book = Data.Books.FirstOrDefault(b => b.BookId == id);
            if (book == null)
                return NotFound();

            BookEditViewModel vm = new BookEditViewModel()
            {
                Id = book.BookId,
                Title = book.Title,
                Genre = book.Genre,
                PublishDate = book.PublishDate,
                ISBN = book.ISBN,
                CopiesAvailable = book.CopiesAvailable,
            };
            return View(vm);
        }

        [HttpPost]
        public ActionResult EditBook(BookEditViewModel Vm)
        {
            Book? book = Data.Books.FirstOrDefault(b => b.BookId == Vm.Id);
            if (book == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                book.Title = Vm.Title;
                book.Genre = Vm.Genre;
                book.PublishDate = Vm.PublishDate;
                book.ISBN = Vm.ISBN;
                book.CopiesAvailable = Vm.CopiesAvailable;

                return RedirectToAction("Index"); // Bu controllerın Indexıne Git
            }
            return View(Vm); // Geçerli Değilse
        }

        [HttpGet]
        public ActionResult DeleteBook(int id)
        {
            Book? book = Data.Books.FirstOrDefault(a => a.BookId == id);

            if (book == null)
                return NotFound(); // Yazar bulunamazsa 404 dönecek

            return View(book); // Yazar mevcutsa, Model ile View'ı döndürüyoruz
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Book? book = Data.Books.FirstOrDefault(a => a.BookId == id);

            if (book == null)
                return NotFound(); // Yazar bulunamazsa 404 dönecek

            Data.Books.Remove(book); // Yazar siliniyor
            return RedirectToAction("Index"); // Silme işlemi başarılıysa Index'e yönlendir
        }

        // Kitap detayları için GetAction
        [HttpGet]
        public ActionResult DetailsBook(int id)
        {
            Book? book = Data.Books.FirstOrDefault(b => b.BookId == id);
            if (book == null)
                return NotFound();

            return PartialView(book);
        }
    }
}