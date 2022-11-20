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
    public class SupplierViewModel : BaseViewModel
    {
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
            {
                _supplier = value;
                OnPropertyChanged();

                if (Supplier != null)
                {
                    Name = Supplier.Name;
                    Address = Supplier.Address;
                    Phone = Supplier.Phone;
                    Email = Supplier.Email;
                    MoreInfo = Supplier.MoreInfo;
                    ContractDate = Supplier.ContractDate;
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

        public SupplierViewModel()
        {
            SupplierDao supplierDao = DataDao.Instance().GetSupplierDao();
            Suppliers = new ObservableCollection<Supplier>(supplierDao.findAll());
            AddCommand = new RelayCommand<object>((p) => {
                return checkNullValue() == false ? false : true;
            }, (p) => {
                Supplier supplier = new Supplier()
                {
                    Name = Name,
                    Address = Address,
                    Phone = Phone,
                    Email = Email,
                    MoreInfo = MoreInfo,
                    ContractDate = ContractDate,
                    Status = 0
                };
                supplierDao.insert(supplier);
                Suppliers.Add(supplier);
            });

            UpdateCommand = new RelayCommand<object>((p) => {
                return checkNullValue() == false || Supplier == null || supplierDao.findById(Supplier.Id) == null ? false : true;
            }, (p) => {
                Supplier.Name = Name;
                Supplier.Address = Address;
                Supplier.Phone = Phone;
                Supplier.Email = Email;
                Supplier.MoreInfo = MoreInfo;
                Supplier.ContractDate = ContractDate;
                supplierDao.update(Supplier);
            });

            DeleteCommand = new RelayCommand<object>((p) => {
                return Supplier == null || supplierDao.findById(Supplier.Id) == null ? false : true;
            }, (p) => {
                Supplier.Status = 1;
                supplierDao.update(Supplier);
                Suppliers.Remove(Supplier);
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
