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

        private string type;

        public UserController(string type)
        {
            this.type = type;
        }

        public void Add(User user)
        {
            CRUDController.Add(user);
        }

        public void Delete(User user)
        {
            CRUDController.Delete(user);
        }

        public List<User> GetData()
        {
            using (var db = new LibraryContext())
            {
                var user = new List<User>();
                if (type == "user")
                    user = db.Users.Where(x => x.Role == null).AsQueryable().ToList();
                else
                    user = db.Users.Where(x => x.Role != null).AsQueryable().ToList();
                return user;
            }
        }
    }
}
