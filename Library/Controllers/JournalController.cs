﻿using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class JournalController
    {
        public CRUDController<Journal> CRUDController
        {
            get
            {
                return new CRUDController<Journal>();
            }
        }

        public void Add(Journal journal)
        {
            CRUDController.Add(journal);
        }

        public void Delete(Journal journal)
        {
            CRUDController.Delete(journal);
        }

        public void Update(Journal journal)
        {
            using (var db = new LibraryContext())
            {
                var j = db.Journals.Single(x => x.Id == journal.Id);
                j.DateOfIssued = journal.DateOfIssued;
                j.EstimatedReturnDate = journal.EstimatedReturnDate;
                if (journal.ActualReturnDate != null)
                    j.ActualReturnDate = journal.ActualReturnDate;
                j.Book = journal.Book;
                j.Staff = journal.Staff;
                j.User = journal.User;
                db.SaveChanges();
            }
        }

        public List<Journal> GetData()
        {
            using (var db = new LibraryContext())
            {
                return db.Journals
                    .Include(x => x.Book)
                    .Include(x => x.User)
                    .Include(x => x.Staff)
                    .OrderByDescending(x => x.DateOfIssued)
                    .AsQueryable().ToList();
            }
        }

        public List<Journal> GetData(string name)
        {
            using (var db = new LibraryContext())
            {
                var d = db.Journals
                    .Include(x => x.Book)
                    .Include(x => x.User)
                    .Include(x => x.Staff)
                    .AsEnumerable()
                    //.Where(x => EF.Functions.Like((x.SearchField!).ToLower(), $"%{field.ToLower()}%"))
                    .Where(x => x.SearchField.ToLower().Contains(name.ToLower()))
                    .OrderBy(x => x.SearchField)
                    .ToList();
                return d;
            }
        }

        public string GetReport()
        {
            using (var db = new LibraryContext())
            {
                var k2 = db.Journals.Include(x => x.Book)
                    .GroupBy(x => x.Book.Title)
                    .Select(x => $"{x.Key} {x.Count()}").ToList();

                return string.Join("\n", k2);
            }
        }

        public string G()
        {
            using(var db = new LibraryContext())
            {
                var a = from book in db.Books
                        join bookgenre in db.BookGenres on book.Id equals bookgenre.BookId
                        join genre in db.Genres on bookgenre.GenreId equals genre.Id
                        select $"{genre.Genre1} {book.Title}";

                var s = db.Books
                    .Join(db.BookGenres,
                    b => b.Id,
                    bg => bg.BookId,
                    (b, bg) => new {b, bg})
                    .Join(db.Genres,
                    x => x.bg.GenreId,
                    name => name.Id,
                    (x, name) => $"{x.b.Title} {name.Genre1}")
                    .ToList();

                var g = db.Books
                    .GroupJoin(db.BookGenres,
                    b => b.Id,
                    bg => bg.BookId,
                    (b, bg) => $"Книга: {b.Title}, Жанры: {string.Join(", ", bg.Select(x => x.Genre.Genre1))}");

                var res = g.ToList();

                return string.Join("\n", res);
            }
        }
    }
}
