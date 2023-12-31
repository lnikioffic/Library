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

        public Journal Add(Journal journal)
        {
            return CRUDController.Add(journal);
        }

        public void Delete(Journal journal)
        {
            CRUDController.Delete(journal);
        }

        public Journal Update(Journal journal)
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
                return j;
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
    }
}
