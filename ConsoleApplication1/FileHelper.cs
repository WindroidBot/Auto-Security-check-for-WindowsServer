using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
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

        public static void SpecifiedDir()
        {
            if (Directory.Exists(@"D:/检查日志") == false)
            {
                Console.WriteLine("检查结果保存在D:/检查日志");
                Directory.CreateDirectory(@"D:/检查日志");
            }
        }
    }
}
