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

        public List<ReportGenre> ReportGenres(DateOnly startDate, DateOnly endDate)
        {
            using (var db = new LibraryContext())
            {
                var allGenres = db.Genres.ToList();

                var genrePopularity = db.Genres
                        .GroupJoin(
                            db.BookGenres,
                            genre => genre.Id,
                            bookGenre => bookGenre.GenreId,
                            (genre, bookGenres) => new
                            {
                                GenreName = genre.Genre1,
                                BookIds = bookGenres.Select(bg => bg.BookId)
                            }
                        ).SelectMany(
                            genre => genre.BookIds,
                            (genre, bookId) => new
                            {
                                GenreName = genre.GenreName,
                                BookId = bookId
                            }
                        ).Join(
                            db.Books,
                            genreBook => genreBook.BookId,
                            book => book.Id,
                            (genreBook, book) => new
                            {
                                GenreName = genreBook.GenreName,
                                Book = book
                            }
                        ).Join(
                            db.Journals,
                            book => book.Book.Id,
                            journal => journal.BookId,
                            (book, journal) => new
                            {
                                GenreName = book.GenreName,
                                Journal = journal
                            }
                        )
                        .Where(journal => startDate < journal.Journal.DateOfIssued
                            && journal.Journal.DateOfIssued < endDate)
                        .GroupBy(result => new { result.GenreName })
                        .Select(group => new ReportGenre
                        {
                            Name = group.Key.GenreName,
                            CountBook = group.Count(),
                            Popularity = group.Count() > 0
                                ? 100.0 * group.Count() / db.Journals
                                    .Count(j => startDate < j.DateOfIssued && j.DateOfIssued < endDate)
                                : 0
                        })
                        .ToList();

                var result = allGenres
                        .GroupJoin(
                            genrePopularity,
                            allGenre => allGenre.Genre1,
                            usedGenre => usedGenre.Name,
                            (allGenre, usedGenres) => new ReportGenre
                            {
                                Name = allGenre.Genre1,
                                CountBook = usedGenres.FirstOrDefault()?.CountBook ?? 0,
                                Popularity = usedGenres.FirstOrDefault()?.Popularity ?? 0
                            }
                        )
                        .OrderByDescending(genre => genre.Popularity)
                        .ToList();

                return result;
            }
        }

        public List<ReportAuthor> ReportAuthors(DateOnly startDate, DateOnly endDate)
        {
            using (var db = new LibraryContext())
            {
                var allAuthor = db.Authors.ToList();

                var authorPopularity = db.Authors
                    .GroupJoin(
                        db.AuthorBooks,
                        author => author.Id,
                        authorBook => authorBook.AuthorId,
                        (author, authorBooks) => new
                        {
                            AuthorName = author.FirstName,
                            BookIds = authorBooks.Select(x => x.BookId)
                        })
                    .SelectMany(
                        author => author.BookIds.DefaultIfEmpty(),
                        (author, bookId) => new
                        {
                            AuthorName = author.AuthorName,
                            BookId = bookId,
                        })
                    .Join(
                        db.Books,
                        bookAuthor => bookAuthor.BookId,
                        book => book.Id,
                        (bookAuthor, book) => new
                        {
                            AuthorName = bookAuthor.AuthorName,
                            Book = book
                        })
                    .Join(
                        db.Journals,
                        book => book.Book.Id,
                        journal => journal.BookId,
                        (book, journal) => new
                        {
                            AuthorName = book.AuthorName,
                            Journal = journal,
                        })
                    .Where(j => startDate < j.Journal.DateOfIssued
                        && j.Journal.DateOfIssued < endDate)
                    .GroupBy(result => new { result.AuthorName})
                    .Select(group => new ReportAuthor
                    {
                        Name = group.Key.AuthorName,
                        CountBook = group.Count(),
                        Popularity = group.Count() > 0
                            ? 100.0 * group.Count() / db.Journals
                                .Count(j => startDate < j.DateOfIssued && j.DateOfIssued < endDate) : 0
                    }).ToList();

                var result = allAuthor
                    .GroupJoin(
                        authorPopularity,
                        allAuthor => allAuthor.FirstName,
                        usedAuthor => usedAuthor.Name,
                        (allAuthor, usedAuthor) => new ReportAuthor
                        {
                            Name = $"{allAuthor.FirstName} {allAuthor.LastName}",
                            CountBook = usedAuthor.FirstOrDefault()?.CountBook ?? 0,
                            Popularity = usedAuthor.FirstOrDefault()?.Popularity ?? 0,
                        })
                    .OrderByDescending(a => a.Popularity)
                    .ToList();
                return result;
            }
        }
        
        public string G()
        {
            using (var db = new LibraryContext())
            {
                var a = from book in db.Books
                        join bookgenre in db.BookGenres on book.Id equals bookgenre.BookId
                        join genre in db.Genres on bookgenre.GenreId equals genre.Id
                        select $"{genre.Genre1} {book.Title}";

                var s = db.Books
                    .Join(db.BookGenres,
                    b => b.Id,
                    bg => bg.BookId,
                    (b, bg) => new { b, bg })
                    .Join(db.Genres,
                    x => x.bg.GenreId,
                    name => name.Id,
                    (x, name) => $"{x.b.Title} {name.Genre1}")
                    .ToList();

                var g = db.Books
                    .GroupJoin(db.BookGenres,
                    b => b.Id,
                    bg => bg.BookId,
                    (b, bg) => $"Книга: {b.Title}, Жанры: {bg.Count()}");
                //  string.Join(", ", bg.Select(x => x.Genre.Genre1))

                var i = db.Genres
                    .GroupJoin(db.BookGenres,
                    genre => genre.Id,
                    bg => bg.GenreId,
                    (genre, bg) => new
                    {
                        Name = genre.Genre1,
                        C = bg.Join(db.Books,
                            bg => bg.BookId,
                            book => book.Id,
                            (bg, book) => new
                            {
                                c = book.Journals.Count
                            }).Count()
                    })
                    .Select(res => $"{res.Name} {res.C}");
                var res = i.ToList();

                var genreBookCounts = db.Genres
                            .GroupJoin(
                                db.BookGenres,
                                genre => genre.Id,
                                bookGenre => bookGenre.GenreId,
                                (genre, bookGenres) => new
                                {
                                    GenreName = genre.Genre1,
                                    BookIds = bookGenres.Select(bg => bg.BookId)
                                }
                            )
                            .SelectMany(
                                genre => genre.BookIds,
                                (genre, bookId) => new
                                {
                                    GenreName = genre.GenreName,
                                    BookId = bookId
                                }
                            )
                            .Join(
                                db.Books,
                                genreBook => genreBook.BookId,
                                book => book.Id,
                                (genreBook, book) => new
                                {
                                    GenreName = genreBook.GenreName,
                                    Book = book
                                }
                            )
                            .Join(
                                db.Journals,
                                book => book.Book.Id,
                                journal => journal.BookId,
                                (book, journal) => new
                                {
                                    GenreName = book.GenreName,
                                    Journal = journal
                                }
                                        )
                            .GroupBy(result => new { result.GenreName })
                            .Select(group => $"{group.Key.GenreName} {group.Count()}")
                            .ToList();

                return string.Join("\n", genreBookCounts);
            }
        }

    }
}
