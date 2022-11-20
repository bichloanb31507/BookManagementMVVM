using MVVMforWPF.Data.Dao;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMforWPF.ViewModel
{
    public class BookViewModel : BaseViewModel
    {
        private ObservableCollection<Book> _books;

        public ObservableCollection<Book> Books
        {
            get => _books;
            set { _books = value; OnPropertyChanged(); }
        }

        private Book _book;

        public Book Book
        {
            get => _book;
            set
            { _book = value; OnPropertyChanged(); Name = Book != null ? Book.Name : ""; }
        }

        private ObservableCollection<Author> _authors;

        public ObservableCollection<Author> Authors
        {
            get => _authors;
            set { _authors = value; OnPropertyChanged(); }
        }

        private Author _author;

        public Author Author
        {
            get => _author;
            set
            { _author = value; OnPropertyChanged(); }
        }

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
            { _category = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Supplier> _suppliers;

        public ObservableCollection<Supplier> Suppliers
        {
            get => _suppliers;
            set { _suppliers = value; OnPropertyChanged(); }
        }

        private Supplier _supplier;

        public Supplier Supplier
        {
            get => _supplier;
            set
            { _supplier = value; OnPropertyChanged(); }
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

        public BookViewModel()
        {
            BookDao bookDao = DataDao.Instance().GetBookDao();
            Books = new ObservableCollection<Book>(bookDao.findAll());

            AuthorDao authorDao = DataDao.Instance().GetAuthorDao();
            Authors = new ObservableCollection<Author>(authorDao.findAll());

            CategoryDao categoryDao = DataDao.Instance().GetCategoryDao();
            Categories = new ObservableCollection<Category>(categoryDao.findAll());

            SupplierDao supplierDao = DataDao.Instance().GetSupplierDao();
            Suppliers = new ObservableCollection<Supplier>(supplierDao.findAll());

            AddCommand = new RelayCommand<object>((p) => {
                if (string.IsNullOrEmpty(Name)) return false;
                if (bookDao.findByName(Name) != null) return false;
                return true;
            }, (p) => {
                Book book = new Book() { Name = Name, Status = 0 };
                bookDao.insert(book);
                Books.Add(book);
            });

            UpdateCommand = new RelayCommand<object>((p) => {
                if (string.IsNullOrEmpty(Name) || Book == null) return false;
                if (bookDao.findByName(Name) != null) return false;
                return true;
            }, (p) => {
                Book.Name = Name;
                bookDao.update(Book);
            });

            DeleteCommand = new RelayCommand<object>((p) => {
                if (string.IsNullOrEmpty(Name) || Book == null) return false;
                if (bookDao.findByName(Name) == null) return false;
                return true;
            }, (p) => {
                Book.Status = 1;
                bookDao.update(Book);
                Books.Remove(Book);
            });
        }
    }
}
