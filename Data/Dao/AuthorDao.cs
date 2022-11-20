using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMforWPF.Data.Dao
{
    public interface AuthorDao
    {
        void insert(Author author);
        void update(Author author);
        List<Author> findAll();
        int count();
        Author findById(int id);
        bool findByPhone(string phone);
        bool findByEmail(string email);
        void deleteById(int id);
    }
}
