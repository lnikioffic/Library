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

        public Staff Add(Staff user)
        {
            return CRUDController.Add(user);
        }

        public void Delete(Staff user)
        {
            CRUDController.Delete(user);
        }

        public Staff Update(Staff user)
        {
            using (var db = new LibraryContext())
            {
                var u = db.Staff.Single(x => x.Id == user.Id);
                u.FirstName = user.FirstName;
                u.LastName = user.LastName;
                u.Patronymic = user.Patronymic;
                u.Role = user.Role;
                db.SaveChanges();
                return u;
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

        public List<Staff> GetData(string name)
        {
            using (var db = new LibraryContext())
            {
                var d = db.Staff
                    .Include(x => x.Role)
                    .AsEnumerable()
                    //.Where(x => EF.Functions.Like((x.SearchField!).ToLower(), $"%{field.ToLower()}%"))
                    .Where(x => x.SearchField.ToLower().Contains(name.ToLower()))
                    .OrderBy(x => x.SearchField)
                    .ToList();
                return d;
            }
        }

    }
}
