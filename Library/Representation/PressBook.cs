using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Representation
{
    public class PressBook
    {
        [DisplayName(@"Название")]
        public string Title { get; }

        [DisplayName(@"Год издания")]
        public string PublicationDate { get; }

        [DisplayName(@"Авторы")]
        public string AuthorBooks { get; }

        [DisplayName(@"Жанры")]
        public string BookGenres { get; }

        [DisplayName(@"Изадние")]
        public string Publishing { get; }

        [Browsable(false)]
        public Book book { get; }

        public PressBook(Book book)
        {
            this.book = book;
            Title = book.Title;
            PublicationDate = book.PublicationDate;
            BookGenres = string.Join(", ", book.BookGenres.Select(x => x.Genre));
            Publishing = book.Publishing.Name;
            AuthorBooks = string.Join(", ", book.AuthorBooks.Select(x => x.Author));
        }
    }
}
