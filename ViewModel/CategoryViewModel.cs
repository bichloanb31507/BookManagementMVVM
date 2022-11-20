using MVVMforWPF.Data.Dao;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMforWPF.ViewModel
{
    public class CategoryViewModel : BaseViewModel
    {
        private ObservableCollection<Category> _categories;

        public ObservableCollection<Category> Categories 
        { 
            get => _categories;
            set { _categories = value; OnPropertyChanged(); } 
        }

        private Category _category;

        public Category Category 
        { 
            get => _category;
            set 
            { _category = value; OnPropertyChanged(); Name = Category != null ? Category.Name : ""; }
        }

        private string _name;

        public string Name
        {
            get => _name;
            set { _name = value; OnPropertyChanged(); }
        }

        public ICommand AddCommand { get; set; }

        public ICommand UpdateCommand { get; set; }

        public ICommand DeleteCommand { get; set; }

        public CategoryViewModel()
        {
            CategoryDao categoryDao = DataDao.Instance().GetCategoryDao();
            Categories = new ObservableCollection<Category>(categoryDao.findAll());

            AddCommand = new RelayCommand<object>((p) => {
                if (string.IsNullOrEmpty(Name)) return false;
                if (categoryDao.findByName(Name) != null) return false;
                return true;
            }, (p) => { 
                Category category = new Category() { Name = Name, Status = 0 };
                categoryDao.insert(category);
                Categories.Add(category);
            });

            UpdateCommand = new RelayCommand<object>((p) => {
                if (string.IsNullOrEmpty(Name) || Category == null) return false;
                if (categoryDao.findByName(Name) != null) return false;
                return true;
            }, (p) => {
                Category.Name = Name;
                categoryDao.update(Category);
            });

            DeleteCommand = new RelayCommand<object>((p) => {
                if (string.IsNullOrEmpty(Name) || Category == null) return false;
                if (categoryDao.findByName(Name) == null) return false;
                return true;
            }, (p) => {
                Category.Status = 1;
                categoryDao.update(Category);
                Categories.Remove(Category);
            });
        }
    }
}
