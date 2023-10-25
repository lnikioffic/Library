using Library.Models;
using Library.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Controllers
{
    internal class GenreController
    {
        public GenreController()
        {
            //RepresentationFabric = new GenreRepresentationFabric();
        }

        public CRUDController<Genre> CRUDController
        {
            get
            {
                return new CRUDController<Genre>();
            }
        }

        //private IRepresentationFabric<Genre> RepresentationFabric { get; }

        public void Add(Genre genre)
        {
            CRUDController.Add(genre);
        }

        public void Update(Genre genre)
        {
            using (var db = new LibraryContext())
            {
                var gen = db.Genres.Single(x => x.Id == genre.Id);
                gen.Genre1 = genre.Genre1;
                db.SaveChanges();
            }
        }

        public void Delete(Genre genre)
        {
            CRUDController.Delete(genre);
        }

        //public IEnumerable<ITableRepresentation> GetGenres()
        //{
        //    return GetData().Select((x) => RepresentationFabric.CreateTableRepresentation(x));
        //}

        public List<Genre> GetData() 
        {
            using (var db = new LibraryContext())
            {
                var genre = db.Genres.AsQueryable();
                return genre.ToList();
            }
        }
    }
}
