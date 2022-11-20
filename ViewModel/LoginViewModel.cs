using MVVMforWPF.Data.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Security.Cryptography;

namespace MVVMforWPF.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public bool IsLogged { get; set; }

        private string _UserName;

        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }

        private string _Password;

        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }

        public ICommand PasswordChangedCommand { get; set; }
        public ICommand LoginCommand { get; set; }

        public LoginViewModel()
        {
            IsLogged = false;
            UserName = "";
            Password = "";
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true;  }, (p) => { Password = p.Password; });
            LoginCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { CheckLogin(p); });
        }

        void CheckLogin(Window p)
        {
            if (p == null) return;

            string passwordEncode = MD5Hash(Base64Encode(Password));
            UserDao userDao = DataDao.Instance().GetUserDao();
            User user = userDao.checkLogin(UserName, passwordEncode);

            if (user != null)
            {
                IsLogged = true;
                p.Close();
            } else
            {
                IsLogged = false;
                MessageBox.Show("Sai tài khoản mật khẩu");
            }
        }

        string Base64Encode(string text)
        {
            var textBytes = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(textBytes);
        }

        string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
