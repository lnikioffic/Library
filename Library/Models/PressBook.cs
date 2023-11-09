using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class PressBook
    {
        public string Title { get; }

        public string PublicationDate { get;  }

        [DisplayName(@"Авторы")]
        public ICollection<AuthorBook> AuthorBooks { get;}

        [DisplayName(@"Жанры")]
        public string BookGenres { get; }

        [DisplayName(@"Изадние")]
        public Publishing Publishing { get; }

        [Browsable(false)]
        public Book book { get; }

        public PressBook(Book book) 
        {
            this.book = book;
            Title = book.Title;
            PublicationDate = book.PublicationDate;
            List<string> gen = new List<string>();
            foreach(var genre in book.BookGenres) 
            {
                gen.Add(genre.Genre.ToString());
            }
            string genres = string.Join(",", gen);
            BookGenres = genres;
            Publishing = book.Publishing;
            AuthorBooks = book.AuthorBooks;
        }
    }
}
