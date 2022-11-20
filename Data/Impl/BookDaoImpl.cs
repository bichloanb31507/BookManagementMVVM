using MVVMforWPF.Data.Dao;
using MVVMforWPF.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMforWPF.Data.Impl
{
    public class BookDaoImpl : BookDao
    {
        private ShopDataContext db;
        public BookDaoImpl()
        {
            db = new ShopDataContext(Constants.DB_CONNECT_STRING);
        }
        public int count()
        {
            var query = from book in db.GetTable<Book>() select book;
            List<Book> bookList = query.ToList<Book>();
            return bookList.Count();
        }
        public void deleteById(string id)
        {
            Book find = db.Books.Single(us => us.Id.Equals(id));
            db.Books.DeleteOnSubmit(find);
            db.SubmitChanges();
        }
        public List<Book> findAll()
        {
            var all = from book in db.GetTable<Book>() where book.Status == 0 select book;
            var bookList = all.ToList();
            return bookList;
        }
        public Book findById(string id)
        {
            return db.Books.Single(us => us.Id.Equals(id));
        }

        public Book findByName(string name)
        {
            return db.Books.Single(us => us.Name.Equals(name));
        }
        public void insert(Book book)
        {
            db.Books.InsertOnSubmit(book);
            db.SubmitChanges();
        }
        public void update(Book book)
        {
            Book find = db.Books.Single(us => us.Id.Equals(book.Id));
            db.SubmitChanges();
        }
    }
}
