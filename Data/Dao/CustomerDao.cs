using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMforWPF.Data.Dao
{
    public interface CustomerDao
    {
        List<Customer> findAll();
        int count();
        void insert(Customer customer);
        void update(Customer customer);
        void deleteById(int id);
        Customer findById(int id);
        bool findByPhone(string phone);
        bool findByEmail(string email);
    }
}
