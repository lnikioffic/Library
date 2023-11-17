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

        [DisplayName(@"Дата публикации")]
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
            List<string> gen = new List<string>();
            foreach (var genre in book.BookGenres)
                gen.Add(genre.Genre.ToString());
            string genres = string.Join(", ", gen);
            BookGenres = genres;
            Publishing = book.Publishing.Name;
            List<string> aut = new List<string>();
            foreach (var authro in book.AuthorBooks)
                aut.Add(authro.Author.ToString());
            AuthorBooks = string.Join(", ", aut);
        }
    }
}
