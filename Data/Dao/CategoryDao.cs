using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMforWPF.Data.Dao
{
    public interface CategoryDao
    {
        void insert(Category category);
        void update(Category category);
        List<Category> findAll();
        int count();
        Category findById(int id);
        Category findByName(string name);
        void deleteById(int id);
    }
}
