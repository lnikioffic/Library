using Library.Models.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library.Controllers
{
    public class CRUDController<T>
        where T: class, IModel, ISearchField
    {
        public T Add(T dataObject)
        {
            using (var db = new LibraryContext())
            {
                var d = db.Set<T>().Add(dataObject);
                db.SaveChanges();
                return d.Entity;
            }
        }

        public List<T> Get(string field)
        {
            using (var db = new LibraryContext())
            {
                var d = db.Set<T>()
                    .Where(x => EF.Functions.Like((x.SearchField!).ToLower(), $"%{field.ToLower()}%"))
                    .AsQueryable().ToList();
                return d;
            }
        }

        public void Delete(T dataObject)
        {
            using (var db = new LibraryContext())
            {
                db.Set<T>().Remove(dataObject);
                db.SaveChanges();
            }
        }

    }
}
