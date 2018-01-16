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
        public static bool IsNumber(string input)
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

        //非零正整数
        public static bool IsPositiveInt(string input)
        {
            string temp = @"^\+?[1-9][0-9]*$";
            Regex rex = new Regex(temp);
            if (rex.IsMatch(input))
            {
                return true;
            }
            else
                return false;
        }

        //英文
        public static bool IsEng(string input)
        {
            string temp = @"^[a-zA-Z]+$";
            Regex rex = new Regex(temp);
            if (rex.IsMatch(input))
            {
                return true;
            }
            else
                return false;
        }
        //中文+英文
        public static bool IsChiEng(string input)
        {
            string temp = @"^[\u4e00-\u9fa5A-Za-z]+$";
            Regex rex = new Regex(temp);
            if (rex.IsMatch(input))
            {
                return true;
            }
            else
                return false;
        }
        //日期
        public static bool IsDate(string input)
        {
            string temp = "^(?<year>\\d{2,4})/(?<month>\\d{1,2})/(?<day>\\d{1,2})$";
            Regex rex = new Regex(temp);
            if (rex.IsMatch(input))
            {
                return true;
            }
            else
                return false;
        }
        //中文、英文、数字但不包括下划线等符号
        public static bool IsChinEngNum(string input)
        {
            string temp = @"^[\w\u4E00-\u9FA5\uF900-\uFA2D]*$";
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
