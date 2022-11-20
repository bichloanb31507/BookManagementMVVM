using MVVMforWPF.Data.Dao;
using MVVMforWPF.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMforWPF.Data.Impl
{
    public class CustomerDaoImpl : CustomerDao
    {
        private ShopDataContext db;
        public CustomerDaoImpl()
        {
            db = new ShopDataContext(Constants.DB_CONNECT_STRING);
        }
        public int count()
        {
            var query = from customer in db.GetTable<Customer>() select customer;
            List<Customer> customerList = query.ToList<Customer>();
            return customerList.Count();
        }
        public void deleteById(int id)
        {
            Customer find = db.Customers.Single(us => us.Id == id);
            db.Customers.DeleteOnSubmit(find);
            db.SubmitChanges();
        }
        public List<Customer> findAll()
        {
            var all = from customer in db.GetTable<Customer>() where customer.Status == 0 select customer;
            var customerList = all.ToList();
            return customerList;
        }
        public Customer findById(int id)
        {
            return db.Customers.Single(us => us.Id == id);
        }

        public bool findByPhone(string phone)
        {
            if (db.Customers.Single(us => us.Phone.Equals(phone)) != null) return false;
            return true;
        }

        public bool findByEmail(string email)
        {
            if (db.Customers.Single(us => us.Email.Equals(email)) != null) return false;
            return true;
        }

        public void insert(Customer customer)
        {
            db.Customers.InsertOnSubmit(customer);
            db.SubmitChanges();
        }
        public void update(Customer customer)
        {
            Customer find = db.Customers.Single(us => us.Id == customer.Id);
            db.SubmitChanges();
        }
    }
}
