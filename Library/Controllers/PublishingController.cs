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

        public List<Publishing> GetData()
        {
            using (var db = new LibraryContext())
            {
                var publishings = db.Publishings.AsQueryable();
                return publishings.ToList();
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
