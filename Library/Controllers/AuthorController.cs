using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class AuthorController
    {
        public CRUDController<Author> CRUDController
        {
            get
            {
                return new CRUDController<Author>();
            }
        }

        public List<Author> GetData()
        {
            using (var db = new LibraryContext())
            {
                return db.Authors.AsQueryable().ToList();
            }
        }

        public List<Author> GetData(string name)
        {
            return CRUDController.Get(name);
        }

        public Author Add(Author author)
        {
            return CRUDController.Add(author);
        }

        public void Delete(Author author)
        {
            CRUDController.Delete(author);
        }

        internal Author Update(Author author)
        {
            using (var db = new LibraryContext())
            {
                var aut = db.Authors.Single(x => x.Id == author.Id);
                aut.FirstName = author.FirstName;
                aut.LastName = author.LastName;
                aut.Patronymic = author.Patronymic;
                db.SaveChanges();
                return aut;
            }
        }
    }
}
