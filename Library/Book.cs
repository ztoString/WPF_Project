using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {

        private String _id;
        private String _title;
        private String _author;
        private String _publisher;
        private String _publishDate;
        private String _language;
        private String _pages;

        public String ID
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }
        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }
        
        public String Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public String Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public String PublishDate
        {
            get { return _publishDate; }
            set { _publishDate = value; }
        }

        public String Language
        {
            get { return _language; }
            set { _language = value; }
        }

        public String Pages
        {
            get { return _pages; }
            set { _pages = value; }
        }

    }
}
