﻿using Library.Models.Interface;
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
        public T Add(T dataObject)
        {
            using (var db = new LibraryContext())
            {
                var d = db.Set<T>().Add(dataObject);
                db.SaveChanges();
                return d.Entity;
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
