using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Runtime.InteropServices;

namespace SchtasksTool
{
    public static class iniHelper
    {
        #region 声明读写INI文件的API函数
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString
            (string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString
            (string section, string key, string defVal, StringBuilder retVal, int size, string filePath);
        #endregion

        /// <summary>
        /// 创建ini文件
        /// </summary>
        public static void create_ini()
        {
            WritePrivateProfileString("TEST1", "ID", "22", @"C:\test.ini");
            WritePrivateProfileString("TEST1", "NAME", "Windows", @"C:\test.ini");
            WritePrivateProfileString("TEST2", "ID", "33", @"C:\test.ini");
            WritePrivateProfileString("TEST2", "NAME", "Android", @"C:\test.ini");
            Console.WriteLine("ini文件已创建");
        }
        /// <summary>
        /// 读取ini字段值
        /// </summary>
        /// <param name="Section">节名</param>
        /// <param name="key">键名</param>
        /// <returns></returns>
        public static string ContentValue(string Section, string key)
        {

            StringBuilder value = new StringBuilder(1024);
            GetPrivateProfileString(Section, key, "", value, 1024, @"D:\test.ini");
            return value.ToString();
        }

        /// <summary>
        /// 修改ini字段值
        /// </summary>
        /// <param name="Section">节名</param>
        /// <param name="key">键名</param>
        /// <param name="value">新的键值</param>
        public static void update_ini(string Section, string key, string value)
        {
            WritePrivateProfileString(Section, key, value, @"D:\test.ini");
        }
    }
}
