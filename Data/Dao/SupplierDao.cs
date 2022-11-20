using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMforWPF.Data.Dao
{
    public interface SupplierDao
    {
        List<Supplier> findAll();
        int count();
        void insert(Supplier supplier);
        void update(Supplier supplier);
        void deleteById(int id);
        Supplier findById(int id);
        bool findByPhone(string phone);
        bool findByEmail(string email);
    }
}
