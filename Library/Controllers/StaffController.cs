using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class StaffController
    {
        public CRUDController<Staff> CRUDController
        {
            get
            {
                return new CRUDController<Staff>();
            }
        }

        public void Add(Staff user)
        {
            CRUDController.Add(user);
        }

        public void Delete(Staff user)
        {
            CRUDController.Delete(user);
        }

        public void Update(Staff user)
        {
            using (var db = new LibraryContext())
            {
                var u = db.Staff.Single(x => x.Id == user.Id);
                u.FirstName = user.FirstName;
                u.LastName = user.LastName;
                u.Patronymic = user.Patronymic;
                u.Role = user.Role;
                db.SaveChanges();
            }
        }

        public List<Staff> GetData(string? name = null, string? last_name = null)
        {
            using (var db = new LibraryContext())
            {
                if (name != null)
                    return db.Staff
                        .Where(x => x.FirstName == name && x.LastName == last_name)
                        .Include(x => x.Role)
                        .AsQueryable().ToList();
                return db.Staff
                    .Include(x => x.Role)
                    .AsQueryable().ToList();
            }
        }
    }
}
