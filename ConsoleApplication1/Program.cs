using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cmd = { @"ipconfig /all" , "systeminfo", "netstat -anb", "tasklist&net start",
                "wmic process get name,executablepath,processid " };
            string output = "";
            string[] path = { @"D:\检查日志\IP检查.txt" , @"D:\检查日志\系统信息检查.txt",
                @"D:\检查日志\端口信息检查.txt", @"D:\检查日志\进程信息检查.txt", @"D:\检查日志\进程路径检查.txt" };
            FileHelper.SpecifiedDir();
            //.RunCmd(cmd, out output);
            //FileHelper.WriteFile(path, output);
            for(int i = 0; i < 5; i++)
            {
                cmdHelper.AutoCmdCreateLog(cmd[i], path[i], output);
            }           
            Console.Read();
        }
    }
}
