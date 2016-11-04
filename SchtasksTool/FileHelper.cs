using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchtasksTool
{
    public static class FileHelper
    {
        /// <summary>
        /// 将结果写入文件
        /// </summary>
        /// <param name="path">指定文件路径</param>
        /// <param name="res">接收输出结果</param>
        public static void WriteFile(string path,string res)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(res);
            sw.Flush();
            Console.WriteLine("日志已创建："+ path);
            sw.Close();
            fs.Close();
        }

        /// <summary>
        /// 创建日志目录
        /// </summary>
        public static void SpecifiedDir()
        {
            if (Directory.Exists(@"D:/检查日志") == false)
            {
                Console.WriteLine("检查结果保存在D:/检查日志");
                Directory.CreateDirectory(@"D:/检查日志");
            }
        }

        /// <summary>
        /// 创建bat文件并写入脚本代码
        /// </summary>
        /// <param name="path">bat文件路径</param>
        /// <param name="ScriptStr">脚本代码</param>
        public static void CreateBat(string path,string ScriptStr)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            //开始写入
            sw.Write(ScriptStr);
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }
    }
}
