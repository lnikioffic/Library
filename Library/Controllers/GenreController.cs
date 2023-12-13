using Library.Models;
using Library.Representation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Controllers
{
    internal class GenreController
    {
        public CRUDController<Genre> CRUDController
        {
            get
            {
                return new CRUDController<Genre>();
            }
        }

        public Genre Add(Genre genre)
        {
            var newGenre = CRUDController.Add(genre);
            return newGenre;
        }

        public Genre Update(Genre genre)
        {
            using (var db = new LibraryContext())
            {
                var gen = db.Genres.Single(x => x.Id == genre.Id);
                gen.Genre1 = genre.Genre1;
                db.SaveChanges();
                return gen;
            }
        }

        public void Delete(Genre genre)
        {
            CRUDController.Delete(genre);
        }

        public List<Genre> GetData() 
        {
            using (var db = new LibraryContext())
            {
                return db.Genres.AsQueryable().ToList();
            }
        }

        public List<Genre> GetData(string name)
        {
            return CRUDController.Get(name);
        }

    }
}
