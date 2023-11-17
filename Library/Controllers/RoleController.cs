using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class RoleController
    {
        public CRUDController<Role> CRUDController
        {
            get
            {
                return new CRUDController<Role>();
            }
        }

        public List<Role> GetData(string? role = null)
        {
            using (var db = new LibraryContext())
            {
                if (role != null) 
                    return db.Roles.Where(x => x.NameRole == role).AsQueryable().ToList();
                return db.Roles.AsQueryable().ToList();
            }
        }
    }
}
