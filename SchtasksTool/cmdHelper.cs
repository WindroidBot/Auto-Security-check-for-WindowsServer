using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchtasksTool
{
    public static class cmdHelper
    {
        private static string CmdPath = @"C:\Windows\System32\cmd.exe";
        /// <summary>
        /// 执行cmd命令
        /// </summary>
        /// <param name="cmd">执行语句</param>
        /// <param name="output">结果的委托</param>
        public static void RunCmd(string cmd, out string output)
        {
            cmd = cmd.Trim().TrimEnd('&') + "&exit";
            using (Process p = new Process())
            {
                p.StartInfo.FileName = CmdPath;
                p.StartInfo.UseShellExecute = false;        //是否使用操作系统shell启动
                p.StartInfo.RedirectStandardInput = true;   //接受来自调用程序的输入信息
                p.StartInfo.RedirectStandardOutput = true;  //由调用程序获取输出信息
                p.StartInfo.RedirectStandardError = true;   //重定向标准错误输出
                p.StartInfo.CreateNoWindow = true;          //不显示程序窗口
                p.Start();//启动程序
                //向cmd窗口写入命令
                p.StandardInput.WriteLine(cmd);
                p.StandardInput.AutoFlush = true;
                //获取cmd窗口的输出信息
                output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();//等待程序执行完退出进程
                Console.WriteLine("执行完成！");
                p.Close();
            }
        }

        /// <summary>
        /// 执行cmd命令并将结果写入日志
        /// </summary>
        /// <param name="cmd">执行语句</param>
        /// <param name="path">日志路径</param>
        /// <param name="output">结果的委托</param>
        public static void AutoCmdCreateLog(string cmd, string path, string output)
        {
            RunCmd(cmd, out output);
            FileHelper.WriteFile(path, output);
        }

        /// <summary>
        /// 执行bat脚本
        /// </summary>
        /// <param name="path">脚本路径</param>
        /// <returns></returns>
        public static bool RunBat(string path)
        {
            Process proc = null;
            try
            {
                proc = new Process();
                proc.StartInfo.FileName = path;
                proc.StartInfo.Arguments = string.Format("10");//this is argument
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred :{0},{1}", ex.Message, ex.StackTrace.ToString());
                MessageBox.Show("脚本执行失败！","粗错了辣", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
