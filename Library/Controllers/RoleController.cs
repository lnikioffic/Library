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

        public List<Role> Get(string name)
        {
            return CRUDController.Get(name);
        }

        public Role Add(Role role)
        {
            return CRUDController.Add(role);
        }

        public Role Update(Role role)
        {
            using (var db = new LibraryContext())
            {
                var rol = db.Roles.Single(x => x.Id == role.Id);
                rol.NameRole = role.NameRole;
                db.SaveChanges();
                return rol;
            }
        }

        public void Delete(Role role)
        {
            CRUDController.Delete(role);
        }
    }
}
