using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class PublishingController
    {
        public CRUDController<Publishing> CRUDController
        {
            get
            {
                return new CRUDController<Publishing>();
            }
        }

        public List<Publishing> GetData(string? name = null)
        {
            using (var db = new LibraryContext())
            {
                if (name != null)
                    return db.Publishings
                        .Where(x => x.Name == name)
                        .AsQueryable().ToList();
                return db.Publishings.AsQueryable().ToList();
            }
        }

        public void Add(Publishing publishing)
        {
            CRUDController.Add(publishing);
        }

        public void Delete(Publishing publishing)
        {
            CRUDController.Delete(publishing);
        }

        internal void Update(Publishing publishing)
        {
            using (var db = new LibraryContext())
            {
                var pub = db.Publishings.Single(x => x.Id == publishing.Id);
                pub.Name = publishing.Name;
                pub.Address = publishing.Address;
                db.SaveChanges();
            }
        }
    }
}
