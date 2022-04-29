namespace SoftSensConf_AK_4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.connectionTabPage = new System.Windows.Forms.TabPage();
            this.labelBitRate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxConnectionInfo = new System.Windows.Forms.TextBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.comboboxComPort = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboboxBitRate = new System.Windows.Forms.ComboBox();
            this.parameterTabPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReciveValue = new System.Windows.Forms.Button();
            this.buttonSetValue = new System.Windows.Forms.Button();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.buttonDownloadConfig = new System.Windows.Forms.Button();
            this.textboxParameterInfo = new System.Windows.Forms.TextBox();
            this.textboxValueSet = new System.Windows.Forms.TextBox();
            this.comboboxParameterSelect = new System.Windows.Forms.ComboBox();
            this.valuesTabPage = new System.Windows.Forms.TabPage();
            this.buttonStopReading = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxAlarmHigh = new System.Windows.Forms.TextBox();
            this.textboxAlarmLow = new System.Windows.Forms.TextBox();
            this.buttonReadRaw = new System.Windows.Forms.Button();
            this.buttonReadScaled = new System.Windows.Forms.Button();
            this.textboxValueInfo = new System.Windows.Forms.TextBox();
            this.textboxConnectionStatuscolour = new System.Windows.Forms.TextBox();
            this.labelConnectionStaus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerReadRaw = new System.Windows.Forms.Timer(this.components);
            this.timerReadScaled = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelAlarmStatus = new System.Windows.Forms.Label();
            this.textboxAlarmStatuscolour = new System.Windows.Forms.TextBox();
            this.timerConnectionStatus = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.connectionTabPage.SuspendLayout();
            this.parameterTabPage.SuspendLayout();
            this.valuesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.connectionTabPage);
            this.tabControl.Controls.Add(this.parameterTabPage);
            this.tabControl.Controls.Add(this.valuesTabPage);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(801, 421);
            this.tabControl.TabIndex = 0;
            // 
            // connectionTabPage
            // 
            this.connectionTabPage.Controls.Add(this.labelBitRate);
            this.connectionTabPage.Controls.Add(this.label5);
            this.connectionTabPage.Controls.Add(this.textboxConnectionInfo);
            this.connectionTabPage.Controls.Add(this.buttonDisconnect);
            this.connectionTabPage.Controls.Add(this.comboboxComPort);
            this.connectionTabPage.Controls.Add(this.buttonConnect);
            this.connectionTabPage.Controls.Add(this.comboboxBitRate);
            this.connectionTabPage.Location = new System.Drawing.Point(4, 25);
            this.connectionTabPage.Name = "connectionTabPage";
            this.connectionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.connectionTabPage.Size = new System.Drawing.Size(793, 392);
            this.connectionTabPage.TabIndex = 0;
            this.connectionTabPage.Text = "Communication";
            this.connectionTabPage.UseVisualStyleBackColor = true;
            // 
            // labelBitRate
            // 
            this.labelBitRate.AutoSize = true;
            this.labelBitRate.Location = new System.Drawing.Point(27, 113);
            this.labelBitRate.Name = "labelBitRate";
            this.labelBitRate.Size = new System.Drawing.Size(57, 16);
            this.labelBitRate.TabIndex = 6;
            this.labelBitRate.Text = "Bit Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Port:";
            // 
            // textboxConnectionInfo
            // 
            this.textboxConnectionInfo.Location = new System.Drawing.Point(560, 6);
            this.textboxConnectionInfo.Multiline = true;
            this.textboxConnectionInfo.Name = "textboxConnectionInfo";
            this.textboxConnectionInfo.Size = new System.Drawing.Size(230, 380);
            this.textboxConnectionInfo.TabIndex = 4;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(116, 361);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(107, 28);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // comboboxComPort
            // 
            this.comboboxComPort.FormattingEnabled = true;
            this.comboboxComPort.Location = new System.Drawing.Point(90, 55);
            this.comboboxComPort.Name = "comboboxComPort";
            this.comboboxComPort.Size = new System.Drawing.Size(152, 24);
            this.comboboxComPort.TabIndex = 3;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(3, 361);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(107, 28);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboboxBitRate
            // 
            this.comboboxBitRate.FormattingEnabled = true;
            this.comboboxBitRate.Location = new System.Drawing.Point(90, 110);
            this.comboboxBitRate.Name = "comboboxBitRate";
            this.comboboxBitRate.Size = new System.Drawing.Size(152, 24);
            this.comboboxBitRate.TabIndex = 2;
            // 
            // parameterTabPage
            // 
            this.parameterTabPage.Controls.Add(this.label4);
            this.parameterTabPage.Controls.Add(this.label3);
            this.parameterTabPage.Controls.Add(this.buttonReciveValue);
            this.parameterTabPage.Controls.Add(this.buttonSetValue);
            this.parameterTabPage.Controls.Add(this.buttonSaveConfig);
            this.parameterTabPage.Controls.Add(this.buttonDownloadConfig);
            this.parameterTabPage.Controls.Add(this.textboxParameterInfo);
            this.parameterTabPage.Controls.Add(this.textboxValueSet);
            this.parameterTabPage.Controls.Add(this.comboboxParameterSelect);
            this.parameterTabPage.Location = new System.Drawing.Point(4, 25);
            this.parameterTabPage.Name = "parameterTabPage";
            this.parameterTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.parameterTabPage.Size = new System.Drawing.Size(793, 392);
            this.parameterTabPage.TabIndex = 1;
            this.parameterTabPage.Text = "Parameters";
            this.parameterTabPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parameter:";
            // 
            // buttonReciveValue
            // 
            this.buttonReciveValue.Location = new System.Drawing.Point(3, 361);
            this.buttonReciveValue.Name = "buttonReciveValue";
            this.buttonReciveValue.Size = new System.Drawing.Size(107, 28);
            this.buttonReciveValue.TabIndex = 6;
            this.buttonReciveValue.Text = "Recive";
            this.buttonReciveValue.UseVisualStyleBackColor = true;
            this.buttonReciveValue.Click += new System.EventHandler(this.buttonReciveValue_Click);
            // 
            // buttonSetValue
            // 
            this.buttonSetValue.Location = new System.Drawing.Point(116, 361);
            this.buttonSetValue.Name = "buttonSetValue";
            this.buttonSetValue.Size = new System.Drawing.Size(107, 28);
            this.buttonSetValue.TabIndex = 5;
            this.buttonSetValue.Text = "Set";
            this.buttonSetValue.UseVisualStyleBackColor = true;
            this.buttonSetValue.Click += new System.EventHandler(this.buttonSetValue_Click);
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.Location = new System.Drawing.Point(566, 358);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(107, 28);
            this.buttonSaveConfig.TabIndex = 4;
            this.buttonSaveConfig.Text = "Save";
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            // 
            // buttonDownloadConfig
            // 
            this.buttonDownloadConfig.Location = new System.Drawing.Point(679, 358);
            this.buttonDownloadConfig.Name = "buttonDownloadConfig";
            this.buttonDownloadConfig.Size = new System.Drawing.Size(105, 28);
            this.buttonDownloadConfig.TabIndex = 3;
            this.buttonDownloadConfig.Text = "Download";
            this.buttonDownloadConfig.UseVisualStyleBackColor = true;
            this.buttonDownloadConfig.Click += new System.EventHandler(this.buttonDownloadConfig_Click);
            // 
            // textboxParameterInfo
            // 
            this.textboxParameterInfo.Location = new System.Drawing.Point(566, 6);
            this.textboxParameterInfo.Multiline = true;
            this.textboxParameterInfo.Name = "textboxParameterInfo";
            this.textboxParameterInfo.Size = new System.Drawing.Size(221, 346);
            this.textboxParameterInfo.TabIndex = 2;
            // 
            // textboxValueSet
            // 
            this.textboxValueSet.Location = new System.Drawing.Point(101, 149);
            this.textboxValueSet.Name = "textboxValueSet";
            this.textboxValueSet.Size = new System.Drawing.Size(125, 22);
            this.textboxValueSet.TabIndex = 1;
            // 
            // comboboxParameterSelect
            // 
            this.comboboxParameterSelect.FormattingEnabled = true;
            this.comboboxParameterSelect.Items.AddRange(new object[] {
            "ID",
            "LRV",
            "URV",
            "AlarmLow",
            "AlarmHigh"});
            this.comboboxParameterSelect.Location = new System.Drawing.Point(101, 70);
            this.comboboxParameterSelect.Name = "comboboxParameterSelect";
            this.comboboxParameterSelect.Size = new System.Drawing.Size(125, 24);
            this.comboboxParameterSelect.TabIndex = 0;
            // 
            // valuesTabPage
            // 
            this.valuesTabPage.Controls.Add(this.buttonStopReading);
            this.valuesTabPage.Controls.Add(this.chart1);
            this.valuesTabPage.Controls.Add(this.label7);
            this.valuesTabPage.Controls.Add(this.label6);
            this.valuesTabPage.Controls.Add(this.textboxAlarmHigh);
            this.valuesTabPage.Controls.Add(this.textboxAlarmLow);
            this.valuesTabPage.Controls.Add(this.buttonReadRaw);
            this.valuesTabPage.Controls.Add(this.buttonReadScaled);
            this.valuesTabPage.Controls.Add(this.textboxValueInfo);
            this.valuesTabPage.Location = new System.Drawing.Point(4, 25);
            this.valuesTabPage.Name = "valuesTabPage";
            this.valuesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.valuesTabPage.Size = new System.Drawing.Size(793, 392);
            this.valuesTabPage.TabIndex = 2;
            this.valuesTabPage.Text = "Values";
            this.valuesTabPage.UseVisualStyleBackColor = true;
            // 
            // buttonStopReading
            // 
            this.buttonStopReading.Location = new System.Drawing.Point(485, 361);
            this.buttonStopReading.Name = "buttonStopReading";
            this.buttonStopReading.Size = new System.Drawing.Size(107, 28);
            this.buttonStopReading.TabIndex = 8;
            this.buttonStopReading.Text = "Stop";
            this.buttonStopReading.UseVisualStyleBackColor = true;
            this.buttonStopReading.Click += new System.EventHandler(this.buttonStopReading_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 50);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Scaled Values";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Raw Values";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(589, 305);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Low";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "High";
            // 
            // textboxAlarmHigh
            // 
            this.textboxAlarmHigh.Location = new System.Drawing.Point(386, 22);
            this.textboxAlarmHigh.Name = "textboxAlarmHigh";
            this.textboxAlarmHigh.Size = new System.Drawing.Size(100, 22);
            this.textboxAlarmHigh.TabIndex = 4;
            // 
            // textboxAlarmLow
            // 
            this.textboxAlarmLow.Location = new System.Drawing.Point(492, 22);
            this.textboxAlarmLow.Name = "textboxAlarmLow";
            this.textboxAlarmLow.Size = new System.Drawing.Size(100, 22);
            this.textboxAlarmLow.TabIndex = 3;
            // 
            // buttonReadRaw
            // 
            this.buttonReadRaw.Location = new System.Drawing.Point(116, 361);
            this.buttonReadRaw.Name = "buttonReadRaw";
            this.buttonReadRaw.Size = new System.Drawing.Size(107, 28);
            this.buttonReadRaw.TabIndex = 2;
            this.buttonReadRaw.Text = "Read Raw";
            this.buttonReadRaw.UseVisualStyleBackColor = true;
            this.buttonReadRaw.Click += new System.EventHandler(this.buttonReadRaw_Click);
            // 
            // buttonReadScaled
            // 
            this.buttonReadScaled.Location = new System.Drawing.Point(3, 361);
            this.buttonReadScaled.Name = "buttonReadScaled";
            this.buttonReadScaled.Size = new System.Drawing.Size(107, 28);
            this.buttonReadScaled.TabIndex = 1;
            this.buttonReadScaled.Text = "Read Scaled";
            this.buttonReadScaled.UseVisualStyleBackColor = true;
            this.buttonReadScaled.Click += new System.EventHandler(this.buttonReadScaled_Click);
            // 
            // textboxValueInfo
            // 
            this.textboxValueInfo.Location = new System.Drawing.Point(598, 6);
            this.textboxValueInfo.Multiline = true;
            this.textboxValueInfo.Name = "textboxValueInfo";
            this.textboxValueInfo.Size = new System.Drawing.Size(192, 380);
            this.textboxValueInfo.TabIndex = 0;
            // 
            // textboxConnectionStatuscolour
            // 
            this.textboxConnectionStatuscolour.Location = new System.Drawing.Point(771, 423);
            this.textboxConnectionStatuscolour.Name = "textboxConnectionStatuscolour";
            this.textboxConnectionStatuscolour.Size = new System.Drawing.Size(23, 22);
            this.textboxConnectionStatuscolour.TabIndex = 1;
            // 
            // labelConnectionStaus
            // 
            this.labelConnectionStaus.AutoSize = true;
            this.labelConnectionStaus.Location = new System.Drawing.Point(677, 426);
            this.labelConnectionStaus.Name = "labelConnectionStaus";
            this.labelConnectionStaus.Size = new System.Drawing.Size(90, 16);
            this.labelConnectionStaus.TabIndex = 2;
            this.labelConnectionStaus.Text = "Disconnected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Connection Status:";
            // 
            // timerReadRaw
            // 
            this.timerReadRaw.Tick += new System.EventHandler(this.timerReadRaw_Tick);
            // 
            // timerReadScaled
            // 
            this.timerReadScaled.Tick += new System.EventHandler(this.timerReadScaled_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alarm Status:";
            // 
            // labelAlarmStatus
            // 
            this.labelAlarmStatus.AutoSize = true;
            this.labelAlarmStatus.Location = new System.Drawing.Point(102, 426);
            this.labelAlarmStatus.Name = "labelAlarmStatus";
            this.labelAlarmStatus.Size = new System.Drawing.Size(51, 16);
            this.labelAlarmStatus.TabIndex = 5;
            this.labelAlarmStatus.Text = "Normal";
            // 
            // textboxAlarmStatuscolour
            // 
            this.textboxAlarmStatuscolour.Location = new System.Drawing.Point(161, 423);
            this.textboxAlarmStatuscolour.Name = "textboxAlarmStatuscolour";
            this.textboxAlarmStatuscolour.Size = new System.Drawing.Size(24, 22);
            this.textboxAlarmStatuscolour.TabIndex = 6;
            // 
            // timerConnectionStatus
            // 
            this.timerConnectionStatus.Tick += new System.EventHandler(this.timerConnectionStatus_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textboxAlarmStatuscolour);
            this.Controls.Add(this.labelAlarmStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelConnectionStaus);
            this.Controls.Add(this.textboxConnectionStatuscolour);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.connectionTabPage.ResumeLayout(false);
            this.connectionTabPage.PerformLayout();
            this.parameterTabPage.ResumeLayout(false);
            this.parameterTabPage.PerformLayout();
            this.valuesTabPage.ResumeLayout(false);
            this.valuesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage connectionTabPage;
        private System.Windows.Forms.TabPage parameterTabPage;
        private System.Windows.Forms.TabPage valuesTabPage;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.ComboBox comboboxComPort;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboboxBitRate;
        private System.Windows.Forms.TextBox textboxConnectionInfo;
        private System.Windows.Forms.TextBox textboxConnectionStatuscolour;
        private System.Windows.Forms.Label labelConnectionStaus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxValueSet;
        private System.Windows.Forms.ComboBox comboboxParameterSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReciveValue;
        private System.Windows.Forms.Button buttonSetValue;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.Button buttonDownloadConfig;
        private System.Windows.Forms.TextBox textboxParameterInfo;
        private System.Windows.Forms.Label labelBitRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonReadRaw;
        private System.Windows.Forms.Button buttonReadScaled;
        private System.Windows.Forms.TextBox textboxValueInfo;
        private System.Windows.Forms.Timer timerReadRaw;
        private System.Windows.Forms.Timer timerReadScaled;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAlarmStatus;
        private System.Windows.Forms.TextBox textboxAlarmStatuscolour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxAlarmHigh;
        private System.Windows.Forms.TextBox textboxAlarmLow;
        private System.Windows.Forms.Timer timerConnectionStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonStopReading;
    }
}

