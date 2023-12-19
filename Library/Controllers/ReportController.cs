using Library.Models;
using Library.Models.ReportModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Controllers
{

    /*
     Популярность автора
        Автор
        Колличество выданных книг
        Популярность автора (Вычислять в процентах: 100 * количество выданных книг за период / 100)

     Жанры
        Жанр
        Колличество выданных книг с эти жанром
        Популярность жанра (Вычислять в процентах: 100 * количество 
            выдач книг данного жанра за выбранный период / Общее 
            количество выданных книг за выбранный период)

     Колличество выданных книг работниками за период
        Работник
        Кол-во книг
        
     */
    public class ReportController
    {
        public List<ReportStaff> ReportStaff(DateOnly startDate, DateOnly endDate)
        {
            using (var db = new LibraryContext())
            {
                var allStaff = db.Staff.ToList();

                var k2 = db.Journals
                    .Include(x => x.Book)
                    .Where(x => startDate < x.DateOfIssued && x.DateOfIssued < endDate)
                    .GroupBy(x => x.Staff)
                    .Select(x => new ReportStaff
                    {
                        Name = x.Key.ToString(),
                        Count = x.Count()
                    }).ToList();

                return k2;
            }
        }

        public List<ReportReturned> ReportReturneds(DateOnly startDate, DateOnly endDate)
        {
            using (var db = new LibraryContext())
            {
                //startDate < j.DateOfIssued && j.DateOfIssued < endDate
                //            &&
                DateTime nowDate = DateTime.Today;
                DateOnly n = DateOnly.Parse(nowDate.ToString("dd.MM.yyyy"));
                var result = db.Journals
                    .Include(j => j.Book)
                        .ThenInclude(b => b.AuthorBooks)
                            .ThenInclude(a => a.Author)
                    .Include(j => j.User)
                    .Where(j => j.ActualReturnDate == null && j.EstimatedReturnDate.Day - n.Day < 0)
                    .ToList()
                    .Select(x => new ReportReturned
                    {
                        User = $"{x.User.LastName} {x.User.FirstName} {x.User.Ticket}",
                        BookTitel = x.Book.Title,
                        EstimatedReturnDate = x.EstimatedReturnDate.ToString(),
                        MissedDays = (x.EstimatedReturnDate.Day - n.Day > 0) ? 0 :
                            Math.Abs(x.EstimatedReturnDate.Day - n.Day),
                        Authors = string.Join(", ", x.Book.AuthorBooks.Select(x => x.Author))
                    })
                    .OrderByDescending(x => x.MissedDays) .ToList();
                return result;
            }
        }

        public List<ReportGenre> ReportGenres(DateOnly startDate, DateOnly endDate)
        {
            using (var db = new LibraryContext())
            {
                var genres = db.Set<Book>()
                        .Include(b => b.BookGenres)
                            .ThenInclude(g => g.Genre)
                        .SelectMany(g => g.BookGenres.Select(x => x.Genre))
                        .GroupBy(g => g)
                        .ToList();

                var allGenres = db.Set<Journal>()
                    .Include(j => j.Book)
                        .ThenInclude(b => b.BookGenres)
                            .ThenInclude(g => g.Genre)
                    .Where(journal => startDate < journal.DateOfIssued
                            && journal.DateOfIssued < endDate)
                    .SelectMany(k => k.Book.BookGenres.Select(g => g.Genre)).ToList();

                var count = allGenres.Count();

                var d = allGenres.GroupBy(a => a)
                    .OrderByDescending(g => g.Count())
                    .Select(x => new ReportGenre
                    {
                        Name = x.Key.ToString(),
                        CountBook = x.Count(),
                        Popularity = Math.Round((x.Count() / (double)count * 100), 1),
                        Book = genres.First(a => a.Key == x.Key).Count()
                    }).ToList();

                return d;
            }
        }

        public List<ReportAuthor> ReportAuthors(DateOnly startDate, DateOnly endDate)
        {
            using (var db = new LibraryContext())
            {
              
                var authors = db.Set<Book>()
                        .Include(b => b.AuthorBooks)
                            .ThenInclude(a => a.Author)
                        .SelectMany(g => g.AuthorBooks.Select(x => x.Author))
                        .GroupBy(g => g)
                        .ToList();

                var allAuthors = db.Set<Journal>()
                   .Include(j => j.Book)
                       .ThenInclude(b => b.AuthorBooks)
                           .ThenInclude(g => g.Author)
                   .Where(journal => startDate < journal.DateOfIssued
                           && journal.DateOfIssued < endDate)
                   .SelectMany(k => k.Book.AuthorBooks.Select(g => g.Author)).ToList();

                var count = allAuthors.Count();

                var d = allAuthors.GroupBy(a => a)
                    .OrderByDescending(g => g.Count())
                    .Select(x => new ReportAuthor
                    {
                        Name = x.Key.ToStringNew(),
                        CountBook = x.Count(),
                        Popularity = Math.Round((x.Count() / (double)count * 100), 1),
                        Book = authors.First(a => a.Key == x.Key).Count()
                    }).ToList();

                return d;
            }
        }
        
        public string G()
        {
            using (var db = new LibraryContext())
            {
                var sa = db.Set<Journal>()
                    .Include(j => j.Book)
                        .ThenInclude(b => b.BookGenres)
                            .ThenInclude(g => g.Genre)
                    //.Where(j => j.DateOfIssued >= data && j.DateOfIssued <= ed)
                    .SelectMany(k => k.Book.BookGenres.Select(g => g.Genre));
                var count = sa.Count();
                var d = sa.GroupBy(a => a)
                    .OrderByDescending(g => g.Count())
                    .Select(x => new ReportGenre
                    {
                        Name = x.Key.ToString(),
                        CountBook = x.Count(),
                        Popularity = Math.Round((x.Count() / (double)count * 100))
                    }).ToList();
                var a = from book in db.Books
                        join bookgenre in db.BookGenres on book.Id equals bookgenre.BookId
                        join genre in db.Genres on bookgenre.GenreId equals genre.Id
                        select $"{genre.Genre1} {book.Title}";


                return string.Join("\n", d);
            }
        }

    }
}
