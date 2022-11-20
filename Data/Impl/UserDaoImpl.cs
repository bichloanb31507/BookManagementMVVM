using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMforWPF;
using MVVMforWPF.Data.Dao;
using MVVMforWPF.Utils;

namespace MVVMforWPF.Data.Impl
{
    public class UserDaoImpl : UserDao
    {
        private ShopDataContext db;
        public UserDaoImpl()
        {
            db = new ShopDataContext(Constants.DB_CONNECT_STRING);
        }
        public int count()
        {
            var query = from user in db.GetTable<User>() select user;
            List<User> userList = query.ToList<User>();
            return userList.Count();
        }
        public void deleteById(int id)
        {
            User find = db.Users.Single(us => us.Id == id);
            db.Users.DeleteOnSubmit(find);
            db.SubmitChanges();
        }
        public User checkLogin(string username, string password)
        {
            User user = null;
            try
            {
               user = db.Users.Single(us => us.UserName == username && us.Password == password);
            }
            catch (Exception ex) 
            {
                ex.ToString();
            }
            return user;
        }
        public List<User> findAll()
        {
            var all = from user in db.GetTable<User>() select user;
            var userList = all.ToList();
            return userList;
        }
        public User findById(int id)
        {
            return db.Users.Single(us => us.Id == id);
        }
        public void insert(User user)
        {
            db.Users.InsertOnSubmit(user);
            db.SubmitChanges();
        }
        public void update(User user)
        {
            User find = db.Users.Single(us => us.Id == user.Id);
            db.SubmitChanges();
        }
    }
}
