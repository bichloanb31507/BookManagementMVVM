using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMforWPF.Data.Dao
{
    public interface BookDao
    {
        void insert(Book book);
        void update(Book book);
        List<Book> findAll();
        int count();
        Book findById(string id);
        Book findByName(string name);
        void deleteById(string id);
    }
}
