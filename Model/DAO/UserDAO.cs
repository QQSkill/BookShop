using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class UserDAO
    {
        BookShopDbContext db = null;
        public UserDAO()
        {
            db = new BookShopDbContext();
        }


        public long Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }

        //public long InsertForFacebook(Account entity)
        //{
        //    var user = db.Accounts.SingleOrDefault(x => x.username == entity.username);
        //    if (user == null)
        //    {
        //        db.Accounts.Add(entity);
        //        db.SaveChanges();
        //        return entity.id;
        //    }
        //    else
        //    {
        //        return user.ID;
        //    }
        //}

        //public bool Update(Account entity)
        //{
        //    try
        //    {
        //        var user = db.Accounts.Find(entity.ID);
        //        user.Name = entity.Name;
        //        if (!string.IsNullOrEmpty(entity.Password))
        //        {
        //            user.Password = entity.Password;
        //        }
        //        user.Address = entity.Address;
        //        user.Email = entity.Email;
        //        user.ModifiedBy = entity.ModifiedBy;
        //        user.ModifiedDate = entity.ModifiedDate;
        //        db.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        // or write a logging message.
        //        return false;
        //    }
        //}

        //public IEnumerable<User> ListAll(string searchString, int page, int pageSize)
        //{
        //    IQueryable<User> model = db.Users;
        //    if (!string.IsNullOrEmpty(searchString))
        //    {
        //        model = model.Where(x => x.UserName.Contains(searchString) || x.Name.Contains(searchString));
        //    }
        //    return model.OrderByDescending(x => x.CreatedDate).ToPagedList(page, pageSize);
        //}

        public User GetByID(string userName)
        {
            return db.Users.SingleOrDefault(x => x.UserName == userName);
        }

        //public User ViewDetail(int id)
        //{
        //    return db.Users.Find(id);
        //}

        public int Login(string userName, string passWord)
        {
            var result = GetByID(userName);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if (1 == 0)
                {
                    return -1;
                }
                else
                {
                    if (result.Password == passWord)
                        return 1;
                    else
                    {
                        return -2;
                    }
                }
            }
        }

        //    public bool ChangeStatus(long id)
        //    {
        //        var user = db.Users.Find(id);
        //        user.Status = !user.Status;
        //        db.SaveChanges();
        //        return user.Status;
        //    }

        //    public bool Delete(int id)
        //    {
        //        try
        //        {
        //            var user = db.Users.Find(id);
        //            db.Users.Remove(user);
        //            db.SaveChanges();
        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            return false;
        //        }
        //    }

        public bool CheckUserName(string userName)
        {
            int i = db.Users.Count(x => x.UserName == userName);
            if (i > 0)
                return true;
            return false;
        }

        //    public bool CheckEmail(string email)
        //    {
        //        return db.Users.Count(x => x.Email == email) > 0;
        //    }
        //}
    }
}
