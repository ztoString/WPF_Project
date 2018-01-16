using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Library
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private string userName;

        private string userPassword;

        private ICommand loginCommand;

        private int is_login;

        private User user = new User();

        public int IsLogin
        {
            get
            {
                return is_login;
            }
            set
            {
                this.is_login = value;
            }
        }

        public ICommand LoginCommand
        {
            get { return loginCommand; }
        }
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                this.userName = value;
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("UserName"));
                }
            }
        }

        public string UserPassword
        {
            get
            {
                return userPassword;
            }
            set
            {
                this.userPassword = value;
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("UserPassword"));
                }
            }
        }

        public UserViewModel()
        {
            loginCommand = new Command(this);
        }

        public void QueryData()
        {
            List<User> list = new List<User>();
            list = LinqToSql.Query(this.UserName, this.UserPassword);
            if (list != null && list.Count > 0)
            {
                MessageBox.Show("登录成功");
                is_login = 1;
                MainWindow Mn = new MainWindow();
                Mn.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
                return;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
