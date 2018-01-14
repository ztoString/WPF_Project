using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class MainWindowModel:ModelBase
    {
        BookListViewModel _bookListViewModel;

        public BookListViewModel BookListViewModel
        {
            get
            {
                if (_bookListViewModel == null)
                {
                    _bookListViewModel = new BookListViewModel();
                }
                return _bookListViewModel;
            }
            set
            {
                if (_bookListViewModel != value)
                {
                    _bookListViewModel = value;
                    RaisePropertyChanged("BookListViewModel");
                }
            }
        }
    }
}
