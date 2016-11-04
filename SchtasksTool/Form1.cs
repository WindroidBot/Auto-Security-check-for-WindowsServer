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

            SchtasksService test = new SchtasksService("aaaaa","secbizsrv", "HOURLY", "15", "aaa", "12:00");
            test.CreateSchtasks_RestartService();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_PeriodicUnit.SelectedIndex = 0;
            comboBox_Action.SelectedIndex = 2;
        }

        private void button_CreateSchtasks_Click(object sender, EventArgs e)
        {
            SchtasksService Schtasks1 = new SchtasksService(textBox_SchtasksName.Text, textBox_ServiceName.Text,
                "HOURLY", textBox_Periodic.Text, comboBox_Action.Text, comboBox_StartH.Text + ":" + comboBox_StartM.Text);
            Console.WriteLine(comboBox_StartH.Text);
            Console.WriteLine(comboBox_StartM.Text);
            Schtasks1.CreateSchtasks_RestartService();
        }
    }
}
