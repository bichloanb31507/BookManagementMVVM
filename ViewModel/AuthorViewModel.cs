using MVVMforWPF.Data.Dao;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace MVVMforWPF.ViewModel
{
    public class AuthorViewModel : BaseViewModel
    {
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
            {
                _author = value; 
                OnPropertyChanged(); 
                
                if (Author != null)
                {
                    Name = Author.Name;
                    Address = Author.Address;
                    Phone = Author.Phone;
                    Email = Author.Email;
                    MoreInfo = Author.MoreInfo;
                }
            }
        }

        private string _name;

        public string Name
        {
            get => _name;
            set { _name = value; OnPropertyChanged(); }
        }

        private string _address;

        public string Address
        {
            get => _address;
            set { _address = value; OnPropertyChanged(); }
        }

        private string _phone;

        public string Phone
        {
            get => _phone;
            set { _phone = value; OnPropertyChanged(); }
        }

        private string _email;

        public string Email
        {
            get => _email;
            set { _email = value; OnPropertyChanged(); }
        }

        private string _moreInfo;

        public string MoreInfo
        {
            get => _moreInfo;
            set { _moreInfo = value; OnPropertyChanged(); }
        }

        public ICommand AddCommand { get; set; }

        public ICommand UpdateCommand { get; set; }

        public ICommand DeleteCommand { get; set; }

        public AuthorViewModel()
        {
            AuthorDao authorDao = DataDao.Instance().GetAuthorDao();
            Authors = new ObservableCollection<Author>(authorDao.findAll());
            AddCommand = new RelayCommand<object>((p) => {
                return checkNullValue() == false ? false : true;
            }, (p) => {
                Author author = new Author() {
                    Name = Name,
                    Address = Address,
                    Phone = Phone,
                    Email = Email,
                    MoreInfo = MoreInfo, 
                    Status = 0 
                };
                authorDao.insert(author);
                Authors.Add(author);
            });

            UpdateCommand = new RelayCommand<object>((p) => {
                return checkNullValue() == false || Author == null || authorDao.findById(Author.Id) == null ? false : true;
            }, (p) => {
                Author.Name = Name;
                Author.Address = Address;
                Author.Phone = Phone;
                Author.Email = Email;
                Author.MoreInfo = MoreInfo;
                authorDao.update(Author);
            });

            DeleteCommand = new RelayCommand<object>((p) => {
                return Author == null || authorDao.findById(Author.Id) == null ? false : true;
            }, (p) => {
                Author.Status = 1;
                authorDao.update(Author);
                Authors.Remove(Author);
            });
        }

        bool checkNullValue()
        {
            if (string.IsNullOrEmpty(Name) || 
                string.IsNullOrEmpty(Address) ||
                string.IsNullOrEmpty(Phone) ||
                string.IsNullOrEmpty(Email) ||
                string.IsNullOrEmpty(MoreInfo)) return false;
            return true;
        }
    }
}
