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
    /// BookListView.xaml 的交互逻辑
    /// </summary>
    public partial class BookListView : UserControl
    {
        public BookListView()
        {
            InitializeComponent();
        }
        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            BookListViewModel bookListViewModel = dgBookList.DataContext as BookListViewModel;
            if (bookListViewModel != null)
            {
                bookListViewModel.SearchCommand.Execute(null);
            }
        }
    }
}
