using Library.Models;
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

        private bool staff;

        public UserController(bool staff)
        {
            this.staff = staff;
        }

        public void Add(User user)
        {
            if (!staff)
                user.Role = false; 
            else
                user.Role = true;
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

        public List<User> GetData()
        {
            using (var db = new LibraryContext())
            {
                var user = new List<User>();
                if (!staff)
                    user = db.Users.Where(x => x.Role == false).AsQueryable().ToList();
                else
                    user = db.Users.Where(x => x.Role == true).AsQueryable().ToList();
                return user;
            }
        }
    }
}
