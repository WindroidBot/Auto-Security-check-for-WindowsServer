using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchtasksTool
{
    class SchtasksService
    {
        private string fileName;//bat文件名
        private string schtasksName;//计划任务名
        private string serviceName;//服务名
        private string periodicUnit;//周期单位
        private string periodic;//周期
        private string startTime;//初次执行时间
        private string action;//执行动作
        private string batPath;//脚本路径，格式以cmd中格式为准

        #region 访问器方法
        public string ServiceName
        {
            get
            {
                return serviceName;
            }

            set
            {
                serviceName = value;
            }
        }

        public string PeriodicUnit
        {
            get
            {
                return periodicUnit;
            }

            set
            {
                periodicUnit = value;
            }
        }

        public string Periodic
        {
            get
            {
                return periodic;
            }

            set
            {
                periodic = value;
            }
        }

        public string Action
        {
            get
            {
                return action;
            }

            set
            {
                action = value;
            }
        }

        public string BatPath
        {
            get
            {
                return batPath;
            }

            set
            {
                batPath = value;
            }
        }

        public string StartTime
        {
            get
            {
                return startTime;
            }

            set
            {
                startTime = value;
            }
        }

        public string FileName
        {
            get
            {
                return fileName;
            }

            set
            {
                fileName = value;
            }
        }

        public string SchtasksName
        {
            get
            {
                return schtasksName;
            }

            set
            {
                schtasksName = value;
            }
        }
        #endregion

        #region 构造方法
        public SchtasksService()
        {

        }

        /// <summary>
        /// SchtasksService构造方法
        /// </summary>
        /// <param name="schtasksName">计划任务名</param>
        /// <param name="serviceName">服务名称</param>
        /// <param name="periodicUnit">周期单位</param>
        /// <param name="periodic">周期</param>
        /// <param name="action">执行动作</param>
        /// <param name="startTime">初次执行时间</param>
        public SchtasksService(string schtasksName,string serviceName,string periodicUnit,string periodic,string action,string startTime)
        {
            this.schtasksName = schtasksName;
            this.serviceName = serviceName;
            this.periodicUnit = periodicUnit;
            this.periodic = periodic;
            this.action = action;
            fileName = "schtasks_" + serviceName;
            batPath = "D:\\" + fileName + ".bat";
            this.startTime = startTime;
            
        }
        #endregion

        #region 创建计划任务
        /// <summary>
        /// 创建重启服务计划任务
        /// </summary>
        /// <returns></returns>
        public bool CreateSchtasks_RestartService()
        {
            string output = "";
            string batString = "sc stop " + serviceName + "\r\n" + "sc start " + serviceName;
            string CreateSchtasks = @"schtasks /create /SC " + periodicUnit + @" /MO " + periodic + @" /TN " + schtasksName + @" /TR " + BatPath + @" /ST " + startTime;
            Console.WriteLine(CreateSchtasks);
            //string CreateSchtasks = @"schtasks /create /SC hourly /MO 6 /TN test /TR C:\Windows\System32\mspaint.exe /ST 12:00";
            FileHelper.CreateBat(batPath, batString);//创建bat脚本
            cmdHelper.RunCmd(CreateSchtasks,out output);//添加计划任务
            return true;
        }

        /// <summary>
        /// 创建停止服务计划任务
        /// </summary>
        /// <returns></returns>
        public bool CreateSchtasks_StopService()
        {
            string output = "";
            string batString = "sc stop " + serviceName ;
            string CreateSchtasks = @"schtasks /create /SC " + periodicUnit + @" /MO " + periodic + @" /TN " + schtasksName + @" /TR " + BatPath + @" /ST " + startTime;
            //string CreateSchtasks = @"schtasks /create /SC hourly /MO 6 /TN test /TR C:\Windows\System32\mspaint.exe /ST 12:00";
            FileHelper.CreateBat(batPath, batString);//创建bat脚本
            cmdHelper.RunCmd(CreateSchtasks, out output);//添加计划任务
            return true;
        }

        /// <summary>
        /// 创建启动服务计划任务
        /// </summary>
        /// <returns></returns>
        public bool CreateSchtasks_StartService()
        {
            string output = "";
            string batString = "sc start " + serviceName;
            string CreateSchtasks = @"schtasks /create /SC " + periodicUnit + @" /MO " + periodic + @" /TN " + schtasksName + @" /TR " + BatPath + @" /ST " + startTime;
            //string CreateSchtasks = @"schtasks /create /SC hourly /MO 6 /TN test /TR C:\Windows\System32\mspaint.exe /ST 12:00";
            FileHelper.CreateBat(batPath, batString);//创建bat脚本
            cmdHelper.RunCmd(CreateSchtasks, out output);//添加计划任务
            return true;
        }
        #endregion


    }
}
