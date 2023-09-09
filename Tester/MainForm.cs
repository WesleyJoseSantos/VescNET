using System;
using System.IO.Ports;
using System.Windows.Forms;
using VescNET.Domain.DTOs;
using VescNET.Domain.Enums;
using VescNET.Domain.Interfaces;
using VescNET.Infra;

namespace Tester
{
    public partial class MainForm : Form
    {
        SerialPort serial = new SerialPort();
        IBldc bldc;

        public MainForm()
        {
            var buffer = new VescNET.Infra.Buffer();
            var packetProcess = new PacketProcess();
            var packet = new Packet(buffer, packetProcess);
            var bldcComm = new BldcSerial(packet, serial);

            bldcComm.OnData += BldcComm_OnData;

            bldc = new Bldc(buffer, bldcComm);
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            comboBoxPort.Items.AddRange(SerialPort.GetPortNames());
            comboBoxBaud.SelectedItem = "115200";
        }

        private void BldcComm_OnData(object sender, VescNET.Domain.DTOs.ReceivedData e)
        {
            switch (e.PacketId)
            {
                case CommPacketId.GetMcConf:
                    propertyGridMcconf.Invoke((MethodInvoker)delegate
                    {
                        propertyGridMcconf.SelectedObject = e.Data;
                    });
                    Log("Mcconf received");
                    break;
                case CommPacketId.GetAppConf:
                    propertyGridAppconf.Invoke((MethodInvoker)delegate
                    {
                        propertyGridAppconf.SelectedObject = e.Data;
                    });
                    Log("Appconf received");
                    break;
                case CommPacketId.DetectEncoder:
                    var encoder = e.Data as DetectEncoderResult;
                    Log($"Encoder Offset: {encoder.Offset}");
                    Log($"Encoder Ratio: {encoder.Ratio}");
                    Log($"Encoder Inverted: {encoder.Inverted}");
                    break;
            }
        }

        private void buttonConnect_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (bldc.Connected)
                {
                    serial.Close();
                    buttonConnect.Text = "Connect";
                }
                else
                {
                    serial.PortName = comboBoxPort.Text;
                    serial.BaudRate = int.Parse(comboBoxBaud.Text);
                    serial.Open();
                    if (serial.IsOpen)
                    {
                        buttonConnect.Text = "Disconnect";
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonSendMcconf_Click(object sender, System.EventArgs e)
        {
            if(propertyGridMcconf.SelectedObject != null && propertyGridMcconf.SelectedObject is McConfiguration)
            {
                bldc.SetMcconf(propertyGridMcconf.SelectedObject as McConfiguration);
            }
        }

        private void buttonReadMcconf_Click(object sender, System.EventArgs e)
        {
            bldc.GetMcconf();
        }

        private void buttonSendAppconf_Click(object sender, System.EventArgs e)
        {
            if (propertyGridAppconf.SelectedObject != null && propertyGridAppconf.SelectedObject is AppConfiguration)
            {
                bldc.SetAppconf(propertyGridAppconf.SelectedObject as AppConfiguration);
            }
        }

        private void buttonReadAppconf_Click(object sender, System.EventArgs e)
        {
            bldc.GetAppconf();
        }

        private void buttonDetectEncoder_Click(object sender, System.EventArgs e)
        {
            if(bldc.Connected)
            {
                bldc.DetectEncoder(10.0f);
                Log("Encoder detection on progress...");
            }
        }

        private void Log(string msg)
        {
            if(textBoxLog.InvokeRequired)
            {
                textBoxLog.Invoke((MethodInvoker)delegate
                {
                    textBoxLog.Text += $"{msg}{Environment.NewLine}";
                });
            }
            else
            {
                textBoxLog.Text += $"{msg}{Environment.NewLine}";
            }
        }
    }
}
