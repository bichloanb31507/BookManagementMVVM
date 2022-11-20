using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MVVMforWPF.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool IsLoaded = false;
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand CategoryWindowCommand { get; set; }
        public ICommand AuthorWindowCommand { get; set; }
        public ICommand CustomerWindowCommand { get; set; }
        public ICommand SupplierWindowCommand { get; set; }
        public ICommand BookWindowCommand { get; set; }
        public MainViewModel()
        {
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) => {
                IsLoaded = true;

                if (p == null) return;

                p.Hide();
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog();
                var loginVM = loginWindow.DataContext as LoginViewModel;

                if (loginVM == null) return;

                if (loginVM.IsLogged)
                    p.Show();
                else
                    p.Close();
            });

            CategoryWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                CategoryWindow categoryWindow = new CategoryWindow();
                categoryWindow.ShowDialog();
            });

            AuthorWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                AuthorWindow authorWindow = new AuthorWindow();
                authorWindow.ShowDialog();
            });

            CustomerWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                CustomerWindow customerWindow = new CustomerWindow();
                customerWindow.ShowDialog();
            });

            SupplierWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                SupplierWindow supplierWindow = new SupplierWindow();
                supplierWindow.ShowDialog();
            });

            BookWindowCommand = new RelayCommand<object>((p) => { return true; }, (p) => {
                BookWindow bookWindow = new BookWindow();
                bookWindow.ShowDialog();
            });
        }
    }
}
