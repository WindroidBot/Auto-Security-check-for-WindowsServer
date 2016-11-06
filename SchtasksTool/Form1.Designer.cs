namespace SchtasksTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_ServiceName = new System.Windows.Forms.Label();
            this.textBox_ServiceName = new System.Windows.Forms.TextBox();
            this.label_PeriodicUnit = new System.Windows.Forms.Label();
            this.comboBox_PeriodicUnit = new System.Windows.Forms.ComboBox();
            this.label_Periodic = new System.Windows.Forms.Label();
            this.textBox_Periodic = new System.Windows.Forms.TextBox();
            this.button_CreateSchtasks = new System.Windows.Forms.Button();
            this.listBox_Schtasks = new System.Windows.Forms.ListBox();
            this.button_DeleteSchtasks = new System.Windows.Forms.Button();
            this.button_OpenSchtasks = new System.Windows.Forms.Button();
            this.button_Test = new System.Windows.Forms.Button();
            this.button_OpenServices = new System.Windows.Forms.Button();
            this.label_Action = new System.Windows.Forms.Label();
            this.comboBox_Action = new System.Windows.Forms.ComboBox();
            this.label_SchtasksName = new System.Windows.Forms.Label();
            this.textBox_SchtasksName = new System.Windows.Forms.TextBox();
            this.label_startTime = new System.Windows.Forms.Label();
            this.comboBox_StartH = new System.Windows.Forms.ComboBox();
            this.comboBox_StartM = new System.Windows.Forms.ComboBox();
            this.label_hour = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_ServiceName
            // 
            this.label_ServiceName.AutoSize = true;
            this.label_ServiceName.Location = new System.Drawing.Point(70, 49);
            this.label_ServiceName.Name = "label_ServiceName";
            this.label_ServiceName.Size = new System.Drawing.Size(65, 12);
            this.label_ServiceName.TabIndex = 0;
            this.label_ServiceName.Text = "服务名称：";
            // 
            // textBox_ServiceName
            // 
            this.textBox_ServiceName.Location = new System.Drawing.Point(141, 46);
            this.textBox_ServiceName.Name = "textBox_ServiceName";
            this.textBox_ServiceName.Size = new System.Drawing.Size(100, 21);
            this.textBox_ServiceName.TabIndex = 1;
            // 
            // label_PeriodicUnit
            // 
            this.label_PeriodicUnit.AutoSize = true;
            this.label_PeriodicUnit.Location = new System.Drawing.Point(70, 87);
            this.label_PeriodicUnit.Name = "label_PeriodicUnit";
            this.label_PeriodicUnit.Size = new System.Drawing.Size(65, 12);
            this.label_PeriodicUnit.TabIndex = 2;
            this.label_PeriodicUnit.Text = "周期单位：";
            // 
            // comboBox_PeriodicUnit
            // 
            this.comboBox_PeriodicUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_PeriodicUnit.FormattingEnabled = true;
            this.comboBox_PeriodicUnit.Items.AddRange(new object[] {
            "分钟",
            "小时",
            "天",
            "周",
            "月"});
            this.comboBox_PeriodicUnit.Location = new System.Drawing.Point(141, 84);
            this.comboBox_PeriodicUnit.Name = "comboBox_PeriodicUnit";
            this.comboBox_PeriodicUnit.Size = new System.Drawing.Size(100, 20);
            this.comboBox_PeriodicUnit.TabIndex = 3;
            // 
            // label_Periodic
            // 
            this.label_Periodic.AutoSize = true;
            this.label_Periodic.Location = new System.Drawing.Point(94, 124);
            this.label_Periodic.Name = "label_Periodic";
            this.label_Periodic.Size = new System.Drawing.Size(41, 12);
            this.label_Periodic.TabIndex = 4;
            this.label_Periodic.Text = "周期：";
            // 
            // textBox_Periodic
            // 
            this.textBox_Periodic.Location = new System.Drawing.Point(141, 120);
            this.textBox_Periodic.Name = "textBox_Periodic";
            this.textBox_Periodic.Size = new System.Drawing.Size(100, 21);
            this.textBox_Periodic.TabIndex = 5;
            // 
            // button_CreateSchtasks
            // 
            this.button_CreateSchtasks.Location = new System.Drawing.Point(72, 270);
            this.button_CreateSchtasks.Name = "button_CreateSchtasks";
            this.button_CreateSchtasks.Size = new System.Drawing.Size(86, 23);
            this.button_CreateSchtasks.TabIndex = 6;
            this.button_CreateSchtasks.Text = "创建计划任务";
            this.button_CreateSchtasks.UseVisualStyleBackColor = true;
            this.button_CreateSchtasks.Click += new System.EventHandler(this.button_CreateSchtasks_Click);
            // 
            // listBox_Schtasks
            // 
            this.listBox_Schtasks.FormattingEnabled = true;
            this.listBox_Schtasks.ItemHeight = 12;
            this.listBox_Schtasks.Location = new System.Drawing.Point(626, 167);
            this.listBox_Schtasks.Name = "listBox_Schtasks";
            this.listBox_Schtasks.Size = new System.Drawing.Size(120, 88);
            this.listBox_Schtasks.TabIndex = 7;
            // 
            // button_DeleteSchtasks
            // 
            this.button_DeleteSchtasks.Location = new System.Drawing.Point(660, 261);
            this.button_DeleteSchtasks.Name = "button_DeleteSchtasks";
            this.button_DeleteSchtasks.Size = new System.Drawing.Size(86, 23);
            this.button_DeleteSchtasks.TabIndex = 8;
            this.button_DeleteSchtasks.Text = "删除计划任务";
            this.button_DeleteSchtasks.UseVisualStyleBackColor = true;
            // 
            // button_OpenSchtasks
            // 
            this.button_OpenSchtasks.Location = new System.Drawing.Point(192, 270);
            this.button_OpenSchtasks.Name = "button_OpenSchtasks";
            this.button_OpenSchtasks.Size = new System.Drawing.Size(168, 21);
            this.button_OpenSchtasks.TabIndex = 9;
            this.button_OpenSchtasks.Text = "打开Windows计划任务管理器";
            this.button_OpenSchtasks.UseVisualStyleBackColor = true;
            // 
            // button_Test
            // 
            this.button_Test.Location = new System.Drawing.Point(626, 87);
            this.button_Test.Name = "button_Test";
            this.button_Test.Size = new System.Drawing.Size(86, 27);
            this.button_Test.TabIndex = 10;
            this.button_Test.Text = "功能测试按钮";
            this.button_Test.UseVisualStyleBackColor = true;
            this.button_Test.Click += new System.EventHandler(this.button_Test_Click);
            // 
            // button_OpenServices
            // 
            this.button_OpenServices.Location = new System.Drawing.Point(264, 46);
            this.button_OpenServices.Name = "button_OpenServices";
            this.button_OpenServices.Size = new System.Drawing.Size(144, 21);
            this.button_OpenServices.TabIndex = 11;
            this.button_OpenServices.Text = "打开Windows服务管理器";
            this.button_OpenServices.UseVisualStyleBackColor = true;
            this.button_OpenServices.Click += new System.EventHandler(this.button_OpenServices_Click);
            // 
            // label_Action
            // 
            this.label_Action.AutoSize = true;
            this.label_Action.Location = new System.Drawing.Point(94, 159);
            this.label_Action.Name = "label_Action";
            this.label_Action.Size = new System.Drawing.Size(41, 12);
            this.label_Action.TabIndex = 12;
            this.label_Action.Text = "动作：";
            // 
            // comboBox_Action
            // 
            this.comboBox_Action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Action.FormattingEnabled = true;
            this.comboBox_Action.Items.AddRange(new object[] {
            "启动服务",
            "停止服务",
            "重启服务"});
            this.comboBox_Action.Location = new System.Drawing.Point(141, 156);
            this.comboBox_Action.Name = "comboBox_Action";
            this.comboBox_Action.Size = new System.Drawing.Size(100, 20);
            this.comboBox_Action.TabIndex = 13;
            // 
            // label_SchtasksName
            // 
            this.label_SchtasksName.AutoSize = true;
            this.label_SchtasksName.Location = new System.Drawing.Point(58, 16);
            this.label_SchtasksName.Name = "label_SchtasksName";
            this.label_SchtasksName.Size = new System.Drawing.Size(77, 12);
            this.label_SchtasksName.TabIndex = 14;
            this.label_SchtasksName.Text = "计划任务名：";
            // 
            // textBox_SchtasksName
            // 
            this.textBox_SchtasksName.Location = new System.Drawing.Point(141, 13);
            this.textBox_SchtasksName.Name = "textBox_SchtasksName";
            this.textBox_SchtasksName.Size = new System.Drawing.Size(100, 21);
            this.textBox_SchtasksName.TabIndex = 15;
            // 
            // label_startTime
            // 
            this.label_startTime.AutoSize = true;
            this.label_startTime.Location = new System.Drawing.Point(46, 201);
            this.label_startTime.Name = "label_startTime";
            this.label_startTime.Size = new System.Drawing.Size(89, 12);
            this.label_startTime.TabIndex = 16;
            this.label_startTime.Text = "初次执行时间：";
            // 
            // comboBox_StartH
            // 
            this.comboBox_StartH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_StartH.FormattingEnabled = true;
            this.comboBox_StartH.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBox_StartH.Location = new System.Drawing.Point(141, 198);
            this.comboBox_StartH.Name = "comboBox_StartH";
            this.comboBox_StartH.Size = new System.Drawing.Size(43, 20);
            this.comboBox_StartH.TabIndex = 17;
            // 
            // comboBox_StartM
            // 
            this.comboBox_StartM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_StartM.FormattingEnabled = true;
            this.comboBox_StartM.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBox_StartM.Location = new System.Drawing.Point(213, 198);
            this.comboBox_StartM.Name = "comboBox_StartM";
            this.comboBox_StartM.Size = new System.Drawing.Size(43, 20);
            this.comboBox_StartM.TabIndex = 18;
            // 
            // label_hour
            // 
            this.label_hour.AutoSize = true;
            this.label_hour.Location = new System.Drawing.Point(190, 201);
            this.label_hour.Name = "label_hour";
            this.label_hour.Size = new System.Drawing.Size(17, 12);
            this.label_hour.TabIndex = 19;
            this.label_hour.Text = "时";
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(262, 201);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(17, 12);
            this.label_min.TabIndex = 20;
            this.label_min.Text = "分";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 357);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.label_hour);
            this.Controls.Add(this.comboBox_StartM);
            this.Controls.Add(this.comboBox_StartH);
            this.Controls.Add(this.label_startTime);
            this.Controls.Add(this.textBox_SchtasksName);
            this.Controls.Add(this.label_SchtasksName);
            this.Controls.Add(this.comboBox_Action);
            this.Controls.Add(this.label_Action);
            this.Controls.Add(this.button_OpenServices);
            this.Controls.Add(this.button_Test);
            this.Controls.Add(this.button_OpenSchtasks);
            this.Controls.Add(this.button_DeleteSchtasks);
            this.Controls.Add(this.listBox_Schtasks);
            this.Controls.Add(this.button_CreateSchtasks);
            this.Controls.Add(this.textBox_Periodic);
            this.Controls.Add(this.label_Periodic);
            this.Controls.Add(this.comboBox_PeriodicUnit);
            this.Controls.Add(this.label_PeriodicUnit);
            this.Controls.Add(this.textBox_ServiceName);
            this.Controls.Add(this.label_ServiceName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ServiceName;
        private System.Windows.Forms.TextBox textBox_ServiceName;
        private System.Windows.Forms.Label label_PeriodicUnit;
        private System.Windows.Forms.ComboBox comboBox_PeriodicUnit;
        private System.Windows.Forms.Label label_Periodic;
        private System.Windows.Forms.TextBox textBox_Periodic;
        private System.Windows.Forms.Button button_CreateSchtasks;
        private System.Windows.Forms.ListBox listBox_Schtasks;
        private System.Windows.Forms.Button button_DeleteSchtasks;
        private System.Windows.Forms.Button button_OpenSchtasks;
        private System.Windows.Forms.Button button_Test;
        private System.Windows.Forms.Button button_OpenServices;
        private System.Windows.Forms.Label label_Action;
        private System.Windows.Forms.ComboBox comboBox_Action;
        private System.Windows.Forms.Label label_SchtasksName;
        private System.Windows.Forms.TextBox textBox_SchtasksName;
        private System.Windows.Forms.Label label_startTime;
        private System.Windows.Forms.ComboBox comboBox_StartH;
        private System.Windows.Forms.ComboBox comboBox_StartM;
        private System.Windows.Forms.Label label_hour;
        private System.Windows.Forms.Label label_min;
    }
}

