using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.VisualBasic;


namespace SoftSensConf_AK_4
{
    public partial class Form1 : Form
    {
        //Raw Values
        List<int> analogReading = new List<int>();
        List<DateTime> timestampRaw = new List<DateTime>();

        //Scaled Values
        List<float> scaledReading = new List<float>();
        List<DateTime> timestampScaled = new List<DateTime>();

        //Database Variables
        string conSoftSensConf = ConfigurationManager.ConnectionStrings["DatabaseOOP"].ConnectionString;
        List<string> listID = new List<string>();
        List<string> listLRV = new List<string>();
        List<string> listURV = new List<string>();
        List<string> listAlarmLow = new List<string>();
        List<string> listAlarmHigh = new List<string>();

        

        public Form1()
        {
            InitializeComponent();
            comboboxComPort.Items.AddRange(SerialPort.GetPortNames());
            comboboxComPort.Text = "--Select--";
            string[] baudRate = new string[] { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            comboboxBitRate.Items.AddRange(baudRate);
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            timerReadRaw.Interval = 2000;
            timerReadRaw.Tick += new EventHandler(timerReadRaw_Tick);
            timerReadScaled.Interval = 2000;
            timerReadScaled.Tick += new EventHandler(timerReadScaled_Tick);

            //Predetermended Values
            textboxConnectionInfo.Text = "Staus: Disconnected";
            labelConnectionStaus.Text = "Disconnected";
            textboxConnectionStatuscolour.BackColor = Color.Red;

            labelAlarmStatus.Text = "Normal";
            textboxAlarmStatuscolour.BackColor = Color.Green;
        }

        //
        // Funksjoner
        //
        void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string ReceivedData = ((SerialPort)sender).ReadLine();
            List<string> splitReceivedData = new List<string>(ReceivedData.Split(';'));


            if (splitReceivedData[0].Trim() == "readconf" & comboboxParameterSelect.Text != "")
            {
                updateArduino(splitReceivedData);
            }

            if (splitReceivedData[0].Trim() == "readscaled")
            {
                plotScaledValues(splitReceivedData);
            }

            if (splitReceivedData[0].Trim() == "readraw")
            {
                readRawValues(splitReceivedData);
            }

            if (splitReceivedData[0].Trim() == "readconf")
            {
                showList(splitReceivedData);

                textboxAlarmHigh.Text = splitReceivedData[5];
                textboxAlarmLow.Text = splitReceivedData[4];
            }
        }

        private void updateArduino(List<string> splitReceivedData)
        {
            textboxParameterInfo.Clear();
            splitReceivedData[comboboxParameterSelect.SelectedIndex + 1] = textboxValueSet.Text;
            string newValues = (splitReceivedData[1] + ";" + splitReceivedData[2] + ";" + splitReceivedData[3] + ";" + splitReceivedData[4] + ";" + splitReceivedData[5]);
            textboxParameterInfo.AppendText(newValues);

            string passwordbox = Interaction.InputBox("Authentication is required to update instrument values. Please enter password:", "Authentication Required", "..", 10, 10);

            string password = (passwordbox + ">");
            string newParameters = ("writeconf>" + password + newValues);
            textboxParameterInfo.AppendText(newParameters);
            serialPort1.WriteLine(newParameters);
        }

        private void plotScaledValues(List<string> splitReceivedData)
        {
            string data = splitReceivedData[1];
            float scaled = float.Parse(data, CultureInfo.InvariantCulture);
            scaledReading.Add(scaled);
            timestampScaled.Add(DateTime.Now);
            chart1.Series["Scaled Values"].Points.DataBindXY(timestampScaled, scaledReading);
            chart1.Invalidate();

            textboxValueInfo.Invoke((MethodInvoker)delegate { textboxValueInfo.AppendText(splitReceivedData[1] + "\r\n"); });

            if (float.Parse(splitReceivedData[1]) > float.Parse(textboxAlarmHigh.Text))
            {
                labelAlarmStatus.Text = "High!";
                textboxAlarmStatuscolour.BackColor = Color.Red;
            }

            else if (float.Parse(splitReceivedData[1]) < float.Parse(textboxAlarmLow.Text))
            {
                labelAlarmStatus.Text = "Low!";
                textboxAlarmStatuscolour.BackColor = Color.Red;
            }

            else
            {
                labelAlarmStatus.Text = "Normal";
                textboxAlarmStatuscolour.BackColor = Color.Green;
            }


        }

        private void readRawValues(List<string> splitReceivedData)
        {
            int iRaw;

            if (int.TryParse(splitReceivedData[1].Trim(), out iRaw))
            {
                analogReading.Add(iRaw);
                timestampRaw.Add(DateTime.Now);
                chart1.Series["Raw Values"].Points.DataBindXY(timestampRaw, analogReading);
                chart1.Invalidate();

                textboxValueInfo.Invoke((MethodInvoker)delegate { textboxValueInfo.AppendText(splitReceivedData[1] + "\r\n"); });

                if (int.Parse(splitReceivedData[1]) > int.Parse(textboxAlarmHigh.Text))
                {
                    labelAlarmStatus.Text = "High!";
                    textboxAlarmStatuscolour.BackColor = Color.Red;
                }

                else if (int.Parse(splitReceivedData[1]) < int.Parse(textboxAlarmLow.Text))
                {
                    labelAlarmStatus.Text = "Low!";
                    textboxAlarmStatuscolour.BackColor = Color.Red;
                }

                else
                {
                    labelAlarmStatus.Text = "Normal";
                    textboxAlarmStatuscolour.BackColor = Color.Green;
                }
            }

        }

        private void showList(List<string> splitReceivedData)
        {
            textboxParameterInfo.Clear();

            for (int i = 0; i < splitReceivedData.Count; i++)
            {
                textboxParameterInfo.Invoke((MethodInvoker)delegate { textboxParameterInfo.AppendText(splitReceivedData[i] + "\r\n"); });
            }
        }

        //
        // Events
        //
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboboxComPort.Text;
                serialPort1.Open();
                textboxConnectionInfo.Text = "Status: Connected";
                labelConnectionStaus.Text = "Connected";
                textboxConnectionStatuscolour.BackColor = Color.Green;
                timerConnectionStatus.Start();
                serialPort1.WriteLine("readconf");
            }

            catch (ArgumentException)
            {
                textboxConnectionInfo.Text = "Status: Disconnected";
                labelConnectionStaus.Text = "Disconnected";
                textboxConnectionStatuscolour.BackColor = Color.Red;

                // Lag Pop-up box her
            }

            catch (IOException)
            {
                textboxConnectionInfo.Text = "Status: Disconnected";
                labelConnectionStaus.Text = "Disconnected";
                textboxConnectionStatuscolour.BackColor = Color.Red;

                // Lag Pop-up box her
            }

            catch (InvalidOperationException)
            {
                textboxConnectionInfo.Text = "Status: Connected";
                labelConnectionStaus.Text = "Connected";
                textboxConnectionStatuscolour.BackColor = Color.Green;

                // Lag Pop-up box her
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            textboxConnectionInfo.Text = "Status: Disconnected";
            labelConnectionStaus.Text = "Disconnected";
            textboxConnectionStatuscolour.BackColor = Color.Red;
        }

        private void timerConnectionStatus_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                textboxConnectionInfo.Text = "Status: Connected";
                labelConnectionStaus.Text = "Connected";
                textboxConnectionStatuscolour.BackColor = Color.Green;
            }

            else
            {
                textboxConnectionInfo.Text = "Status: Disconnected";
                labelConnectionStaus.Text = "Disconnected";
                textboxConnectionStatuscolour.BackColor = Color.Red;

                // Lag Pop-up box her

                timerConnectionStatus.Stop();
            }
        }

        private void timerReadRaw_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readraw");
        }

        private void timerReadScaled_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readscaled");
        }

        private void buttonReciveValue_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readconf");
        }

        private void buttonSetValue_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (textboxValueSet.Text != "" & comboboxParameterSelect.SelectedIndex > -1)
                {
                    serialPort1.WriteLine("readconf");
                }

                else
                {
                    textboxParameterInfo.Clear();
                    textboxParameterInfo.AppendText("Please select a parameter and write a value!");
                }
            }
        }
        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            string ID, sqlQuery;
            float URV, LRV;
            int alarmLow, alarmHigh;
            
            List<string> list = new List<string>(textboxParameterInfo.Text.Split('\n'));

            try
            {
                ID = list[1];
                URV = float.Parse(list[2]);
                LRV = float.Parse(list[3]);
                alarmHigh = int.Parse(list[4]);
                alarmLow = int.Parse(list[5]);
                string DAU_ID = "100000";
                string Prod_ID = "200000";
                string Area_Code = "A1";
                string IO_ID = "300000";
                SqlConnection con = new SqlConnection(conSoftSensConf);
                sqlQuery = String.Concat(@"INSERT INTO Instrument VALUES ('", ID,"', '", LRV, "', '", URV, "', '", alarmLow, "', '", alarmHigh, "', '", DAU_ID, "','", Prod_ID, "', '", Area_Code, "', '", IO_ID, "')");
                con.Open();
                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void buttonDownloadConfig_Click(object sender, EventArgs e)
        {
            try
            {
                listID.Clear();
                listLRV.Clear();
                listURV.Clear();
                listAlarmLow.Clear();
                listAlarmHigh.Clear();

                SqlConnection con = new SqlConnection(conSoftSensConf);
                string sqlQuery = "SELECT Tag, LRV, URV, Alerm_Low, Alarm_High FROM Instrument";
                SqlCommand sql = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader dr = sql.ExecuteReader();
                while (dr.Read() == true)
                {
                    sqlQuery = dr[0].ToString();
                    listID.Add(sqlQuery);
                    sqlQuery = dr[1].ToString();
                    listLRV.Add(sqlQuery);
                    sqlQuery = dr[2].ToString();
                    listURV.Add(sqlQuery);
                    sqlQuery = dr[3].ToString();
                    listAlarmLow.Add(sqlQuery);
                    sqlQuery = dr[4].ToString();
                    listAlarmHigh.Add(sqlQuery);
                }
                con.Close();

                textboxParameterInfo.Clear();
                textboxParameterInfo.AppendText("Available Configurations:" + "\r\n");

                for (int i = 0; i < listID.Count; i++)
                {
                    string Config = ((i+1) + ": " + listID[i] + ";" + listLRV[i] + ";" + listURV[i] + ";" + listAlarmLow[i] + ";" + listAlarmHigh[i]);
                    textboxParameterInfo.AppendText(Config + "\r\n");
                }

                string configBox = Interaction.InputBox("You need to choose a config. Please enter a number coresponding with the config you want:", "Selected Config Needed", "..", 10, 10);

                string newConfig = (listID[int.Parse(configBox)-1] + ";" + listLRV[int.Parse(configBox)-1] + ";" + listURV[int.Parse(configBox)-1] + ";" + listAlarmLow[int.Parse(configBox)-1] + ";" + listAlarmHigh[int.Parse(configBox)-1]);

                string passwordBox = Interaction.InputBox("Authentication is required to update instrument values. Please enter password:", "Authentication Required", "..", 10, 10);

                newConfig = ("writeconf>" + passwordBox + ">" + newConfig);

                serialPort1.WriteLine(newConfig);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonReadScaled_Click(object sender, EventArgs e)
        {
            timerReadScaled.Start();
        }

        private void buttonReadRaw_Click(object sender, EventArgs e)
        {
            timerReadRaw.Start();
        }

        private void buttonStopReading_Click(object sender, EventArgs e)
        {
            if (timerReadRaw.Enabled == true)
            {
                timerReadRaw.Stop();

                string Tag, sqlQuery;

                List<string> list = new List<string> (textboxParameterInfo.Text.Split('\n'));

                Tag = list[1];

                for(int i = 0; i < analogReading.Count; i++)
                {
                    SqlConnection con = new SqlConnection(conSoftSensConf);
                    sqlQuery = String.Concat(@"INSERT INTO Datalog (Raw_Values, Date_time, Instrument_Tag) VALUES ('", analogReading[i],"', '", timestampRaw[i],"', '", Tag,"')");
                    con.Open();
                    SqlCommand command = new SqlCommand(sqlQuery, con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }

            if (timerReadScaled.Enabled == true)
            {
                timerReadScaled.Stop();

                string Tag1, sqlQuery;

                List<string> list1 = new List<string>(textboxParameterInfo.Text.Split('\n'));

                Tag1 = list1[1];

                for (int i = 0; i < analogReading.Count; i++)
                {
                    SqlConnection con = new SqlConnection(conSoftSensConf);
                    sqlQuery = String.Concat(@"INSERT INTO Datalog (Scaled_Values, Date_time, Instrument_Tag) VALUES ('", scaledReading[i], "', '", timestampScaled[i], "', '", Tag1, "')");
                    con.Open();
                    SqlCommand command = new SqlCommand(sqlQuery, con);
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
    
