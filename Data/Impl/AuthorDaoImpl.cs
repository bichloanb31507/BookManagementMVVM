using MVVMforWPF.Data.Dao;
using MVVMforWPF.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMforWPF.Data.Impl
{
    public class AuthorDaoImpl : AuthorDao
    {
        private ShopDataContext db;
        public AuthorDaoImpl()
        {
            db = new ShopDataContext(Constants.DB_CONNECT_STRING);
        }
        public int count()
        {
            var query = from author in db.GetTable<Author>() select author;
            List<Author> authorList = query.ToList<Author>();
            return authorList.Count();
        }
        public void deleteById(int id)
        {
            Author find = db.Authors.Single(us => us.Id == id);
            db.Authors.DeleteOnSubmit(find);
            db.SubmitChanges();
        }
        public List<Author> findAll()
        {
            var all = from author in db.GetTable<Author>() where author.Status == 0 select author;
            var authorList = all.ToList();
            return authorList;
        }
        public Author findById(int id)
        {
            return db.Authors.Single(us => us.Id == id);
        }

        public bool findByPhone(string phone)
        {
            if (db.Authors.Single(us => us.Phone.Equals(phone)) != null) return false;
            return true;
        }

        public bool findByEmail(string email)
        {
            if (db.Authors.Single(us => us.Email.Equals(email)) != null) return false;
            return true;
        }

        public void insert(Author author)
        {
            db.Authors.InsertOnSubmit(author);
            db.SubmitChanges();
        }
        public void update(Author author)
        {
            Author find = db.Authors.Single(us => us.Id == author.Id);
            db.SubmitChanges();
        }
    }
}
