using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject.Models
{
    public class Data
    {
        public static List<Book> Books { get; set; } = new()
        {
            new Book() { BookId = 1, Title = "To Kill a Mockingbird", AuthorId = 1, Genre = "Fiction", PublishDate = new DateTime(1960, 7, 11), ISBN = "9780061120084", CopiesAvailable = 5 },
            new Book() { BookId = 2, Title = "1984", AuthorId = 2, Genre = "Dystopian", PublishDate = new DateTime(1949, 6, 8), ISBN = "9780451524935", CopiesAvailable = 8 },
            new Book() { BookId = 3, Title = "PrBookIde and Prejudice", AuthorId = 3, Genre = "Romance", PublishDate = new DateTime(1813, 1, 28), ISBN = "9780141439518", CopiesAvailable = 4 },
            new Book() { BookId = 4, Title = "Adventures of Huckleberry Finn", AuthorId = 4, Genre = "Adventure", PublishDate = new DateTime(1884, 12, 10), ISBN = "9780486280615", CopiesAvailable = 7 },
            new Book() { BookId = 5, Title = "Moby-Dick", AuthorId = 5, Genre = "Adventure", PublishDate = new DateTime(1851, 10, 18), ISBN = "9780142437247", CopiesAvailable = 3 },
            new Book() { BookId = 6, Title = "Frankenstein", AuthorId = 6, Genre = "Horror", PublishDate = new DateTime(1818, 1, 1), ISBN = "9780486282114", CopiesAvailable = 6 },
            new Book() { BookId = 7, Title = "The Great Gatsby", AuthorId = 7, Genre = "Fiction", PublishDate = new DateTime(1925, 4, 10), ISBN = "9780743273565", CopiesAvailable = 10 },
            new Book() { BookId = 8, Title = "Harry Potter and the Sorcerer's Stone", AuthorId = 8, Genre = "Fantasy", PublishDate = new DateTime(1997, 6, 26), ISBN = "9780590353427", CopiesAvailable = 15 },
            new Book() { BookId = 9, Title = "The Old Man and the Sea", AuthorId = 9, Genre = "Fiction", PublishDate = new DateTime(1952, 9, 1), ISBN = "9780684830490", CopiesAvailable = 9 },
            new Book() { BookId = 10, Title = "War and Peace", AuthorId = 10, Genre = "Historical Fiction", PublishDate = new DateTime(1869, 1, 1), ISBN = "9780199232765", CopiesAvailable = 4 },
            new Book() { BookId = 11, Title = "One Hundred Years of Solitude", AuthorId = 11, Genre = "Magic Realism", PublishDate = new DateTime(1967, 5, 30), ISBN = "9780060883287", CopiesAvailable = 12 },
            new Book() { BookId = 12, Title = "The Catcher in the Rye", AuthorId = 12, Genre = "Fiction", PublishDate = new DateTime(1951, 7, 16), ISBN = "9780316769488", CopiesAvailable = 7 },
            new Book() { BookId = 13, Title = "Of Mice and Men", AuthorId = 13, Genre = "Fiction", PublishDate = new DateTime(1937, 2, 6), ISBN = "9780140177398", CopiesAvailable = 6 },
            new Book() { BookId = 14, Title = "Mrs. Dalloway", AuthorId = 14, Genre = "Fiction", PublishDate = new DateTime(1925, 5, 14), ISBN = "9780156628709", CopiesAvailable = 5 },
            new Book() { BookId = 15, Title = "Great Expectations", AuthorId = 15, Genre = "Fiction", PublishDate = new DateTime(1861, 1, 1), ISBN = "9780141439563", CopiesAvailable = 10 }
        };

        public static List<Author> Authors { get; set; } = new()
        {
            new Author() { AuthorId = 1, FirstName = "Harper", LastName = "Lee", DateOfBirth = new DateTime(1926, 4, 28) },
            new Author() { AuthorId = 2, FirstName = "George", LastName = "Orwell", DateOfBirth = new DateTime(1903, 6, 25) },
            new Author() { AuthorId = 3, FirstName = "Jane", LastName = "Austen", DateOfBirth = new DateTime(1775, 12, 16) },
            new Author() { AuthorId = 4, FirstName = "Mark", LastName = "Twain", DateOfBirth = new DateTime(1835, 11, 30) },
            new Author() { AuthorId = 5, FirstName = "Herman", LastName = "Melville", DateOfBirth = new DateTime(1819, 8, 1) },
            new Author() { AuthorId = 6, FirstName = "Mary", LastName = "Shelley", DateOfBirth = new DateTime(1797, 8, 30) },
            new Author() { AuthorId = 7, FirstName = "F. Scott", LastName = "Fitzgerald", DateOfBirth = new DateTime(1896, 9, 24) },
            new Author() { AuthorId = 8, FirstName = "J.K.", LastName = "Rowling", DateOfBirth = new DateTime(1965, 7, 31) },
            new Author() { AuthorId = 9, FirstName = "Ernest", LastName = "Hemingway", DateOfBirth = new DateTime(1899, 7, 21) },
            new Author() { AuthorId = 10, FirstName = "Leo", LastName = "Tolstoy", DateOfBirth = new DateTime(1828, 9, 9) },
            new Author() { AuthorId = 11, FirstName = "Gabriel", LastName = "García Márquez", DateOfBirth = new DateTime(1927, 3, 6) },
            new Author() { AuthorId = 12, FirstName = "J.D.", LastName = "Salinger", DateOfBirth = new DateTime(1919, 1, 1) },
            new Author() { AuthorId = 13, FirstName = "John", LastName = "Steinbeck", DateOfBirth = new DateTime(1902, 2, 27) },
            new Author() { AuthorId = 14, FirstName = "Virginia", LastName = "Woolf", DateOfBirth = new DateTime(1882, 1, 25) },
            new Author() { AuthorId = 15, FirstName = "Charles", LastName = "Dickens", DateOfBirth = new DateTime(1812, 2, 7) }
            };
    }
}
