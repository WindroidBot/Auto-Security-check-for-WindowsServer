using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
        /// 创建ini配置文件
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="schtasksName"></param>
        /// <param name="serviceName"></param>
        /// <param name="periodicUnit"></param>
        /// <param name="periodic"></param>
        /// <param name="action"></param>
        /// <param name="startTime"></param>
        public static void create_ini(string fileName, string schtasksName, string serviceName, 
            string periodicUnit, string periodic,string startTime, string action)
        {
            WritePrivateProfileString(fileName, "schtasksName", schtasksName,"D:\\SchtasksService.ini");
            WritePrivateProfileString(fileName, "serviceName", serviceName, "D:\\SchtasksService.ini");
            WritePrivateProfileString(fileName, "periodicUnit", periodicUnit, "D:\\SchtasksService.ini");
            WritePrivateProfileString(fileName, "periodic", periodic, "D:\\SchtasksService.ini");
            WritePrivateProfileString(fileName, "startTime", action, "D:\\SchtasksService.ini");
            WritePrivateProfileString(fileName, "action", startTime, "D:\\SchtasksService.ini");
            WritePrivateProfileString(fileName, "batPath", "C:\\" + fileName + ".bat", "D:\\SchtasksService.ini");
            File.SetAttributes("D:\\SchtasksService.ini", FileAttributes.Hidden); //设置为隐藏文件
        }


    }
}
