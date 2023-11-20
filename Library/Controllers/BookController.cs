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

        public List<Book> GetData()
        {
            using (var db = new LibraryContext())
            {
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
    }
}
