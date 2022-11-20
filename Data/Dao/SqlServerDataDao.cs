using MVVMforWPF.Data.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMforWPF.Data.Dao
{
    public class SqlServerDataDao : DataDao
    {
        public override AuthorDao GetAuthorDao()
        {
            return new AuthorDaoImpl();
        }
        public override CategoryDao GetCategoryDao()
        {
            return new CategoryDaoImpl();
        }

        public override UserDao GetUserDao()
        {
            return new UserDaoImpl();
        }

        public override CustomerDao GetCustomerDao()
        {
            return new CustomerDaoImpl();
        }

        public override SupplierDao GetSupplierDao()
        {
            return new SupplierDaoImpl();
        }

        public override BookDao GetBookDao()
        {
            return new BookDaoImpl();
        }
    }
}
