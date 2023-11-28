using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class UserController
    {
        public CRUDController<User> CRUDController
        {
            get
            {
                return new CRUDController<User>();
            }
        }

        public void Add(User user)
        {
            CRUDController.Add(user);
        }

        public void Delete(User user)
        {
            CRUDController.Delete(user);
        }

        public void Update(User user)
        {
            using (var db = new LibraryContext())
            {
                var u = db.Users.Single(x => x.Id == user.Id);
                u.FirstName = user.FirstName;
                u.LastName = user.LastName;
                u.Patronymic = user.Patronymic;
                db.SaveChanges();
            }
        }

        public override int GetHashCode()
        {
            return Math.Abs(Guid.NewGuid().GetHashCode() % 100000000);
        }

        public List<User> GetData(string? name = null, string? last_name = null)
        {
            using (var db = new LibraryContext())
            {
                if (name != null)
                    return db.Users
                        .Where(x => x.FirstName == name && x.LastName == last_name)
                        .AsQueryable().ToList();
                return db.Users.AsQueryable().ToList();
            }
        }

        public List<User> GetData(string name)
        {
            return CRUDController.Get(name);
        }
    }
}
