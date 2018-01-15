using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library
{
    public class RegexTxt
    {
        //纯数字
        public bool IsNumber(string input)
        {
            string temp = @"^[0-9]*$";
            Regex rex = new Regex(temp);
            if (rex.IsMatch(input))
            {
                return true;
            }
            else
                return false;
        }

        //纯汉字
        public bool IsChinese(string input)
        {
            string temp = @"^[\u4e00-\u9fa5]/g";
            Regex rex = new Regex(temp);
            if (rex.IsMatch(input))
            {
                return true;
            }
            else
                return false;
        }
        //日期
        public bool IsDate(string input)
        {
            string temp = @"^(?<year>\\d{2,4})/(?<month>\\d{1,2})/(?<day>\\d{1,2})$";
            Regex rex = new Regex(temp);
            if (rex.IsMatch(input))
            {
                return true;
            }
            else
                return false;
        }

    }
}
