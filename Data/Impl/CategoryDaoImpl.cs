using MVVMforWPF.Data.Dao;
using MVVMforWPF.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMforWPF.Data.Impl
{
    public class CategoryDaoImpl : CategoryDao
    {
        private ShopDataContext db;
        public CategoryDaoImpl()
        {
            db = new ShopDataContext(Constants.DB_CONNECT_STRING);
        }
        public int count()
        {
            var query = from category in db.GetTable<Category>() select category;
            List<Category> categoryList = query.ToList<Category>();
            return categoryList.Count();
        }
        public void deleteById(int id)
        {
            Category find = db.Categories.Single(us => us.Id == id);
            db.Categories.DeleteOnSubmit(find);
            db.SubmitChanges();
        }
        public List<Category> findAll()
        {
            var all = from category in db.GetTable<Category>() where category.Status == 0 select category;
            var categoryList = all.ToList();
            return categoryList;
        }
        public Category findById(int id)
        {
            return db.Categories.Single(us => us.Id == id);
        }

        public Category findByName(string name)
        {
            return db.Categories.Single(us => us.Name.Equals(name));
        }
        public void insert(Category category)
        {
            db.Categories.InsertOnSubmit(category);
            db.SubmitChanges();
        }
        public void update(Category category)
        {
            Category find = db.Categories.Single(us => us.Id == category.Id);
            db.SubmitChanges();
        }
    }
}