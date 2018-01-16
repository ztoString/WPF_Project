using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;

namespace Library
{
    public class BookListViewModel:ModelBase
    {
        string strFilePath = string.Empty;
        IEnumerable<Book> _bookLibrary;
        ObservableCollection<Book> _bookList;
        Book _selectedBook;
        string _searchText = string.Empty;
        int _searchType = 0;



        public ObservableCollection<Book> BookList
        {
            get
            {
                return _bookList;
            }
            set
            {
                if (_bookList != value)
                {
                    _bookList = value;
                    RaisePropertyChanged("BookList");
                }
            }
        }

        public Book SelectedBook
        {
            get
            {
                return _selectedBook;
            }
            set
            {
                if (_selectedBook != value)
                {
                    _selectedBook = value;
                    RaisePropertyChanged("SelectedBook");
                }
            }
        }

        public String SearchText
        {
            get
            {
                return _searchText;
            }
            set
            {
                if (_searchText != value)
                {
                    _searchText = value;
                    RaisePropertyChanged("SearchText");
                }
            }
        }

        public int SearchType
        {
            get { return _searchType; }
            set
            {
                _searchType = value;
            }
        }

        private Command _addCommand;
        private Command _deleteCommand;
        private Command _searchCommand;
        private Command _saveCommand;

        public ICommand AddCommand
        {
            get
            {
                return _addCommand;
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                return _deleteCommand;
            }
        }

        public ICommand SearchCommand
        {
            get
            {
                return _searchCommand;
            }
        }

        public ICommand SaveCommand
        {
            get
            {
                return _saveCommand;
            }
        }

        public BookListViewModel()
        {
            _addCommand = new Command((p) => Add(p), (p) => CanAdd(p));
            _deleteCommand = new Command((p) => Delete(p), (p) => CanDelete(p));
            _searchCommand = new Command((p) => Search(p), (p) => CanSearch(p));
            _saveCommand = new Command((p) => Save(p), (p) => CanSave(p));

            strFilePath = "../../BookLibrary.xml";

            LoadLibrary();
        }

        private void LoadLibrary()
        {
            XDocument doc = XDocument.Load(strFilePath);

            _bookLibrary = from e in doc.Descendants("Book")
                           select new Book()
                           {
                               ID = e.Attribute("ID").Value,
                               Title = e.Element("Title").Value,
                               Author = e.Element("Author").Value,
                               Publisher = e.Element("Publisher").Value,
                               PublishDate = e.Element("PublishDate").Value,
                               Pages = e.Element("Pages").Value,
                               Language = e.Element("Language").Value
                           };

            _bookList = _bookLibrary.ToObservableCollection();

            SelectedBook = BookList.FirstOrDefault();
        }

        private bool CanAdd(object param)
        {
            return true;
        }

        private bool CanDelete(object param)
        {
            return SelectedBook != null;
        }

        private bool CanSearch(object param)
        {
            return true;
        }

        private bool CanSave(object param)
        {
            return true;
        }

        private void Add(object param)
        {
            Book newBook = new Book()
            {
                ID = (Convert.ToInt32((from b in BookList.Cast<Book>() select b.ID).Max<string>()) + 1).ToString()
            };
            BookList.Add(newBook);
            _bookLibrary = BookList.ToIEnumerable<Book>();
            SelectedBook = newBook;
        }

        private void Delete(object param)
        {
            if (SelectedBook != null)
            {
                BookList.Remove(SelectedBook);
                _bookLibrary = BookList.ToIEnumerable<Book>();
                SelectedBook = BookList.LastOrDefault();
                MessageBox.Show("删除成功！", "提示");
            }
        }

        private void Search(object param)
        {
            if (!String.IsNullOrEmpty(SearchText))
            {
                IEnumerable<Book> search = null;
                switch (SearchType)
                {
                    case 0:
                        search = from b in BookList.Cast<Book>()
                                 where b.Title.ToLower().Contains(SearchText.ToLower())
                                 select b;
                        break;
                    case 1:
                        search = from b in BookList.Cast<Book>()
                                 where b.Author.ToLower().Contains(SearchText.ToLower())
                                 select b;
                        break;
                    case 2:
                        search = from b in BookList.Cast<Book>()
                                 where b.Publisher.ToLower().Contains(SearchText.ToLower())
                                 select b;
                        break;
                }
                BookList = search.ToObservableCollection<Book>();
            }
            else
            {
                BookList = _bookLibrary.ToObservableCollection<Book>();
            }
        }
        private void Save(Object param)
        {
            IEnumerable<Book> newData = BookList.Cast<Book>();
            XDocument newDoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "true"));
            XElement bookLibrary = new XElement("BookLibrary");
            if (newData.Last().Title==null||newData.Last().Author==null||newData.Last().Publisher==null||newData.Last().PublishDate==null||newData.Last().Language==null||newData.Last().Pages==null)
            {
                MessageBox.Show("信息填写不完整！","提示");
                return;
            }
            if(!RegexTxt.IsChinEngNum(newData.Last().Title))
            {
                MessageBox.Show("书名格式：中文,英文,数字！", "提示");
                return;
            }
            if (!RegexTxt.IsChiEng(newData.Last().Author))
            {
                MessageBox.Show("作者格式：中文,英文！", "提示");
                return;
            }
            if (!RegexTxt.IsChiEng(newData.Last().Publisher))
            {
                MessageBox.Show("出版机构格式：中文,英文！", "提示");
                return;
            }
            if (!RegexTxt.IsDate(newData.Last().PublishDate))
            {
                MessageBox.Show("日期格式为xxxx/xx/xx", "提示");
                return;
            }
            if (!RegexTxt.IsChiEng(newData.Last().Language))
            {
                MessageBox.Show("语言格式：中文,英文！", "提示");
                return;
            }
            if (!RegexTxt.IsPositiveInt(newData.Last().Pages))
            {
                MessageBox.Show("页数格式为非零正整数！", "提示");
                return;
            }
            foreach (var b in newData)
            {
                
                XElement book = new XElement("Book",
                    new XAttribute("ID", b.ID),
                    new XElement("Title", b.Title),
                    new XElement("Author", b.Author),
                    new XElement("Publisher", b.Publisher),
                    new XElement("PublishDate", b.PublishDate),
                    new XElement("Language", b.Language),
                    new XElement("Pages", b.Pages)
                    );
                bookLibrary.Add(book);
            }

            newDoc.Add(bookLibrary);
            newDoc.Save(strFilePath);
            MessageBox.Show("保存成功！", "提示");
        }
    }
}
