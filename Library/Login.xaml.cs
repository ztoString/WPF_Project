using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Library
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        private UserViewModel userViewModel = null;
        public Login()
        {
            InitializeComponent();
            userViewModel = new UserViewModel();
            this.DataContext = userViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.userViewModel != null)
            {
                this.userViewModel.UserName = this.txtUserName.Text;
                this.userViewModel.UserPassword = this.txtPassword.Text;
                this.userViewModel.LoginCommand.Execute(1);
                if (userViewModel.IsLogin == 1) this.Close();
            }
        }

    }
}
