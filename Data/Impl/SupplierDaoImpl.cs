using MVVMforWPF.Data.Dao;
using MVVMforWPF.Utils;
using MVVMforWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMforWPF.Data.Impl
{
    public class SupplierDaoImpl : SupplierDao
    {
        private ShopDataContext db;
        public SupplierDaoImpl()
        {
            db = new ShopDataContext(Constants.DB_CONNECT_STRING);
        }
        public List<Supplier> findAll()
        {
            var all = from supplier in db.GetTable<Supplier>() where supplier.Status == 0 select supplier;
            var supplierList = all.ToList();
            return supplierList;
        }
        public int count()
        {
            var query = from supplier in db.GetTable<Supplier>() select supplier;
            List<Supplier> supplierList = query.ToList<Supplier>();
            return supplierList.Count();
        }
        public void insert(Supplier supplier)
        {
            db.Suppliers.InsertOnSubmit(supplier);
            db.SubmitChanges();
        }
        public void update(Supplier supplier)
        {
            Supplier find = db.Suppliers.Single(us => us.Id == supplier.Id);
            db.SubmitChanges();
        }
        public void deleteById(int id)
        {
            Supplier find = db.Suppliers.Single(us => us.Id == id);
            db.Suppliers.DeleteOnSubmit(find);
            db.SubmitChanges();
        }
        public Supplier findById(int id)
        {
            return db.Suppliers.Single(us => us.Id == id);
        }

        public bool findByPhone(string phone)
        {
            if (db.Suppliers.Single(us => us.Phone.Equals(phone)) != null) return false;
            return true;
        }

        public bool findByEmail(string email)
        {
            if (db.Suppliers.Single(us => us.Email.Equals(email)) != null) return false;
            return true;
        }
    }
}
