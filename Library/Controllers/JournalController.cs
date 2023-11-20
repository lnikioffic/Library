using Library.Models;
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

        public List<Journal> GetData()
        {
            using (var db = new LibraryContext())
            {
                return db.Journals
                    .Include(x => x.Book)
                    .Include(x => x.User)
                    .Include(x => x.Staff)
                    .AsQueryable().ToList();
            }
        }
    }
}
