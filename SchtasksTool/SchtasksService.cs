using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchtasksTool
{
    class SchtasksService
    {
        #region 属性
        /// <summary>
        /// bat文件名
        /// </summary>
        private string fileName;
        /// <summary>
        /// 计划任务名
        /// </summary>
        private string schtasksName;
        /// <summary>
        /// 服务名
        /// </summary>
        private string serviceName;
        /// <summary>
        /// 周期单位
        /// </summary>
        private string periodicUnit;
        /// <summary>
        /// 周期
        /// </summary>
        private string periodic;
        /// <summary>
        /// 初次执行时间
        /// </summary>
        private string startTime;
        /// <summary>
        /// 执行动作
        /// </summary>
        private string action;//执行动作
        /// <summary>
        /// 脚本路径，格式以cmd中格式为准
        /// </summary>
        private string batPath;
        #endregion

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
        /// <summary>
        /// SchtasksService构造方法
        /// </summary>
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
            batPath = "C:\\" + fileName + ".bat";
            this.startTime = startTime;            
        }
        #endregion

        /// <summary>
        /// 创建计划任务
        /// </summary>
        /// <param name="action">执行动作</param>
        /// <returns></returns>
        public bool CreateSchtasks(string action)
        {
            string batString=null;
            switch (action)
            {
                case "start":
                    batString = "sc start " + serviceName;
                    break;
                case "stop":
                    batString = "sc stop " + serviceName;
                    break;
                case "restart":
                    batString = "sc stop " + serviceName + "\r\n" + "sc start " + serviceName;
                    break;
            }
            string output = "";
            string CreateSchtasks = @"schtasks /create /SC " + periodicUnit + @" /MO " + periodic + @" /TN " + schtasksName + @" /TR " + BatPath + @" /ST " + startTime;
            FileHelper.CreateBat(batPath, batString);//创建bat脚本
            cmdHelper.RunCmd(CreateSchtasks, out output);//添加计划任务
            return true;
        }







    }
}
