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

        public User Add(User user)
        {
            return CRUDController.Add(user);
        }

        public void Delete(User user)
        {
            CRUDController.Delete(user);
        }

        public User Update(User user)
        {
            using (var db = new LibraryContext())
            {
                var u = db.Users.Single(x => x.Id == user.Id);
                u.FirstName = user.FirstName;
                u.LastName = user.LastName;
                u.Patronymic = user.Patronymic;
                db.SaveChanges();
                return u;
            }
        }

        public override int GetHashCode()
        {
            return Math.Abs(Guid.NewGuid().GetHashCode() % 100000000);
        }

        public List<User> GetData(int? ticket = null)
        {
            using (var db = new LibraryContext())
            {
                if (ticket != null)
                    return db.Users
                        .Where(x => x.Ticket == ticket)
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
