using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchtasksTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Test_Click(object sender, EventArgs e)
        {
            /*
            string dir = "C:\\test.bat";
            string cmd = @"schtasks /create /SC hourly /MO 6 /TN test /TR C:\Windows\System32\mspaint.exe /ST 12:00";
            FileHelper.CreateBat(dir, cmd);
            cmdHelper.RunBat(dir);
            */

            //SchtasksService test = new SchtasksService("aaaaa","secbizsrv", "HOURLY", "15", "aaa", "12:00");
            //test.CreateSchtasks_RestartService();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_PeriodicUnit.SelectedIndex = 0;
            comboBox_Action.SelectedIndex = 2;
            comboBox_StartH.SelectedIndex = 12;
            comboBox_StartM.SelectedIndex = 30;
        }

        private void button_CreateSchtasks_Click(object sender, EventArgs e)
        {
            SchtasksService Schtasks1 = new SchtasksService(textBox_SchtasksName.Text, textBox_ServiceName.Text,
                comboBox_PeriodicUnit.Text, textBox_Periodic.Text, comboBox_Action.Text, comboBox_StartH.Text + ":" + comboBox_StartM.Text);
            string temp = comboBox_PeriodicUnit.Text;
            string temp2 = comboBox_Action.Text;
            switch (temp)
            {
                case "分钟":
                    Schtasks1.PeriodicUnit = "MINUTE";
                    break;
                case "小时":
                    Schtasks1.PeriodicUnit = "HOURLY";
                    break;
                case "天":
                    Schtasks1.PeriodicUnit = "DAILY";
                    break;
                case "周":
                    Schtasks1.PeriodicUnit = "WEEKLY";
                    break;
                case "月":
                    Schtasks1.PeriodicUnit = "MONTHLY";
                    break;
            }
            switch (temp2)
            {
                case "启动服务":
                    Schtasks1.Action = "start";
                    break;
                case "停止服务":
                    Schtasks1.Action = "stop";
                    break;
                case "重启服务":
                    Schtasks1.Action = "restart";
                    break;
            }
            //Schtasks1.CreateSchtasks_RestartService();
            Schtasks1.CreateSchtasks(Schtasks1.Action);
            iniHelper.create_ini(Schtasks1.FileName,Schtasks1.SchtasksName,Schtasks1.ServiceName,
                Schtasks1.PeriodicUnit,Schtasks1.Periodic,Schtasks1.StartTime,Schtasks1.Action);
        }

        private void button_OpenServices_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("services.msc");
        }

        private void button_OpenSchtasks_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("taskschd.msc");
        }
    }
}
