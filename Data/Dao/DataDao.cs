using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMforWPF.Data.Dao
{
    public abstract class DataDao
    {
        private static DataDao instance;
        public static void init(DataDao _instance)
        {
            instance = _instance;
        }
        public static DataDao Instance()
        {
            return instance;
        }
        abstract public UserDao GetUserDao();
        abstract public CategoryDao GetCategoryDao();
        abstract public AuthorDao GetAuthorDao();
        abstract public CustomerDao GetCustomerDao();
        abstract public SupplierDao GetSupplierDao();
        abstract public BookDao GetBookDao();
    }
}
