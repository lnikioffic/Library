using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class CRUDController<T>
        where T: class, IModel
    {
        public void Add(T dataObject)
        {
            using (var db = new LibraryContext())
            {
                var model = db
                    .GetType()
                    .GetProperties()
                    .Where(x => x.PropertyType.Equals(typeof(DbSet<T>)))
                    .First()
                    .GetValue(db);

                if (model as DbSet<T> != null)
                    ((DbSet<T>)model).Add(dataObject);

                db.SaveChanges();
            }
        }

        public void Delete(T dataObject)
        {
            using (var db = new LibraryContext())
            {
                var model = db
                    .GetType()
                    .GetProperties()
                    .Where(x => x.PropertyType.Equals(typeof(DbSet<T>)))
                    .First()
                    .GetValue(db);

                if (model as DbSet<T> != null)
                    ((DbSet<T>)model).Remove(dataObject);

                db.SaveChanges();
            }
        }

    }
}
