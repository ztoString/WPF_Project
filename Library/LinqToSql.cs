using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LinqToSql
    {
        const string ConnectionString = @"Data Source=;Initial Catalog=WPF;User ID=sa;Pwd=4727028;Integrated Security=true;";
        static UserDataContext dc = new UserDataContext(ConnectionString);
        public static List<User> Query(string account,string pwd)
        {
            var aUser = from r in dc.User 
                        where r.Account == account && r.Pwd == pwd 
                            select r;
            return aUser.ToList();
        }
    }
}
