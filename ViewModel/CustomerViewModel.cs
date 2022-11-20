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
    public class CustomerViewModel : BaseViewModel
    {
        private ObservableCollection<Customer> _customers;

        public ObservableCollection<Customer> Customers
        {
            get => _customers;
            set { _customers = value; OnPropertyChanged(); }
        }

        private Customer _customer;

        public Customer Customer
        {
            get => _customer;
            set
            {
                _customer = value;
                OnPropertyChanged();

                if (Customer != null)
                {
                    Name = Customer.Name;
                    Address = Customer.Address;
                    Phone = Customer.Phone;
                    Email = Customer.Email;
                    MoreInfo = Customer.MoreInfo;
                    ContractDate = Customer.ContractDate;
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

        private DateTime? _contractDate;

        public DateTime? ContractDate
        {
            get => _contractDate;
            set { _contractDate = value; OnPropertyChanged(); }
        }

        public ICommand AddCommand { get; set; }

        public ICommand UpdateCommand { get; set; }

        public ICommand DeleteCommand { get; set; }

        public CustomerViewModel()
        {
            CustomerDao customerDao = DataDao.Instance().GetCustomerDao();
            Customers = new ObservableCollection<Customer>(customerDao.findAll());
            AddCommand = new RelayCommand<object>((p) => {
                return checkNullValue() == false ? false : true;
            }, (p) => {
                Customer customer = new Customer()
                {
                    Name = Name,
                    Address = Address,
                    Phone = Phone,
                    Email = Email,
                    MoreInfo = MoreInfo,
                    ContractDate = ContractDate,
                    Status = 0
                };
                customerDao.insert(customer);
                Customers.Add(customer);
            });

            UpdateCommand = new RelayCommand<object>((p) => {
                return checkNullValue() == false || Customer == null || customerDao.findById(Customer.Id) == null ? false : true;
            }, (p) => {
                Customer.Name = Name;
                Customer.Address = Address;
                Customer.Phone = Phone;
                Customer.Email = Email;
                Customer.MoreInfo = MoreInfo;
                Customer.ContractDate = ContractDate;
                customerDao.update(Customer);
            });

            DeleteCommand = new RelayCommand<object>((p) => {
                return Customer == null || customerDao.findById(Customer.Id) == null ? false : true;
            }, (p) => {
                Customer.Status = 1;
                customerDao.update(Customer);
                Customers.Remove(Customer);
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
