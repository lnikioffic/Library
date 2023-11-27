using Library.Models;
using Library.Representation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class BookController
    {
        public CRUDController<Book> CRUDController
        {
            get
            {
                return new CRUDController<Book>();
            }
        }

        public void Add(Book book)
        {
            CRUDController.Add(book);
        }

        public void Delete(Book book)
        {
            CRUDController.Delete(book);
        }

        public void Update(Book book)
        {
            using (var db = new LibraryContext())
            {
                var b = db.Books.Single(x => x.Id == book.Id);
                db.BookGenres.ToList();
                db.AuthorBooks.ToList();
                b.Title = book.Title;
                b.PublicationDate = book.PublicationDate;
                b.Publishing = book.Publishing;
                b.AuthorBooks = book.AuthorBooks;
                b.BookGenres = book.BookGenres;
                db.SaveChanges();
            }
        }

        public IEnumerable<PressBook> GetBooks()
        {
            return GetData().Select(x => new PressBook(x));
        }

        public List<Book> GetData(string? title = null)
        {
            using (var db = new LibraryContext())
            {
                if (title != null)
                    return db.Books
                        .Where(x => x.Title == title)
                        .Include(x => x.BookGenres)
                            .ThenInclude(x => x.Genre)
                        .Include(x => x.AuthorBooks)
                            .ThenInclude(x => x.Author)
                        .Include(x => x.Publishing)
                        .AsEnumerable()
                        .AsQueryable().ToList();
                var books = db.Books
                    .Include(x => x.BookGenres)
                        .ThenInclude(x => x.Genre)
                    .Include(x => x.AuthorBooks)
                        .ThenInclude(x => x.Author)
                    .Include(x => x.Publishing)
                    .AsEnumerable()
                    .AsQueryable().ToList();
                return books;
            }
        }

        public List<Book> GetActuall()
        {
            using (var db = new LibraryContext())
            {
                List<Book> b = new List<Book>();
                var j = db.Journals
                    .Where(x => x.ActualReturnDate == null)
                    .Include(x => x.Book).AsQueryable().ToList();
                var books = db.Books
                    .Include(x => x.BookGenres)
                        .ThenInclude(x => x.Genre)
                    .Include(x => x.AuthorBooks)
                        .ThenInclude(x => x.Author)
                    .Include(x => x.Publishing)
                    .AsEnumerable()
                    .AsQueryable().ToList();
                List<int> id = new List<int>();
                foreach (var ji in j)
                    id.Add(ji.Book.Id);

                //var s = db.Books.Join(db.Journals,
                //    u => u.Id,
                //    x => x.BookId,
                //    (u , x) => new
                //    {
                //        Title = u.Title,
                //        Books = x.Book,
                //        Ret = x.ActualReturnDate
                //    });

                foreach (var book in books)
                {
                    if (!id.Contains(book.Id))
                        b.Add(book);
                }
                return b;
            }
        }

    }
}
