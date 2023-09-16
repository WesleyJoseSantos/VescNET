using System;
using System.IO.Ports;
using System.Windows.Forms;
using VescNET.Domain.DTOs;
using VescNET.Domain.Enums;
using VescNET.Domain.Interfaces;
using VescNET.Infra;

namespace Sample
{
    public partial class MainForm : Form
    {
        readonly IBldcComm comm;
        readonly IBldc bldc;

        public MainForm()
        {
            var buffer = new VescNET.Infra.Buffer();
            var packetProcess = new PacketProcess();
            var packet = new Packet(buffer, packetProcess);
            var serial = new SerialPort();
            comm = new BldcSerial(packet, serial);
            bldc = new Bldc(buffer, comm);

            comm.ConnectionChanged += BldcComm_ConnectionChanged;
            comm.OnData += BldcComm_OnData;

            InitializeComponent();
        }

        private void BldcComm_ConnectionChanged(object sender, bool connected)
        {
            if (connected)
            {
                Log("VESC is connected");
                btConnect.Invoke((MethodInvoker)delegate
                {
                    btConnect.Text = "Disconnect";
                });
                bldc.GetMcconf();
            }
            else
            {
                Log("VESC is disconected");
                btConnect.Invoke((MethodInvoker)delegate
                {
                    btConnect.Text = "Connect";
                });
                tbFirmware.Invoke((MethodInvoker)delegate
                {
                    tbFirmware.Text = "";
                });
                tbHardware.Invoke((MethodInvoker)delegate
                {
                    tbHardware.Text = "";
                });
                tbUUID.Invoke((MethodInvoker)delegate
                {
                    tbUUID.Text = "";
                });
            }
        }

        private void BldcComm_OnData(object sender, VescNET.Domain.DTOs.ReceivedData e)
        {
            switch (e.PacketId)
            {
                case CommPacketId.FwVersion:
                    var info = e.Data as DeviceInfo;
                    tbFirmware.Invoke((MethodInvoker)delegate
                    {
                        tbFirmware.Text = info.FirmwareVersion;
                    });
                    tbHardware.Invoke((MethodInvoker)delegate
                    {
                        tbHardware.Text = info.HardwareVersion;
                    });
                    tbUUID.Invoke((MethodInvoker)delegate
                    {
                        tbUUID.Text = BitConverter.ToString(info.Uuid);
                    });
                    break;
                case CommPacketId.GetValues:
                    Log(PacketProcess.PrintData(e));
                    break;
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
                    Log("Sending detected encoder parameters to VESC...");
                    var mcConf = propertyGridMcconf.SelectedObject as McConfiguration;
                    mcConf.FocEncoderOffset = encoder.Offset;
                    mcConf.FocEncoderRatio = encoder.Ratio;
                    mcConf.FocEncoderInverted = encoder.Inverted;
                    bldc.SetMcconf(mcConf);
                    break;
                case CommPacketId.SetMcConf:
                    Log("Mcconf sended to VESC");
                    bldc.GetMcconf();
                    break;
                case CommPacketId.SetAppConf:
                    Log("Appconf sended to VESC");
                    bldc.GetAppconf();
                    break;
            }
        }

        private void BtConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (comm.Connected == false)
                {
                    comm.Connect(bldc);
                }
                else 
                {
                    comm.Disconnect();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtSendMcconf_Click(object sender, System.EventArgs e)
        {
            if(propertyGridMcconf.SelectedObject != null && propertyGridMcconf.SelectedObject is McConfiguration)
            {
                bldc.SetMcconf(propertyGridMcconf.SelectedObject as McConfiguration);
            }
        }

        private void BtReadMcconf_Click(object sender, System.EventArgs e)
        {
            bldc.GetMcconf();
        }

        private void BtSendAppconf_Click(object sender, System.EventArgs e)
        {
            if (propertyGridAppconf.SelectedObject != null && propertyGridAppconf.SelectedObject is AppConfiguration)
            {
                bldc.SetAppconf(propertyGridAppconf.SelectedObject as AppConfiguration);
            }
        }

        private void BtReadAppconf_Click(object sender, System.EventArgs e)
        {
            bldc.GetAppconf();
        }

        private void BtGetFwInfo_Click(object sender, EventArgs e)
        {
            bldc.GetFwVersion();
        }

        private void BtGetValues_Click(object sender, EventArgs e)
        {
            bldc.GetValues();
        }

        private void BtSetDutyCycle_Click(object sender, EventArgs e)
        {
            if (float.TryParse(tbDutyCycle.Text, out float dutyCycle))
            {
                Log($"Set Duty Cycle: {dutyCycle}");
                bldc.SetDutyCycle(dutyCycle);
            }
            else
            {
                Log("Error: Incorrect Input Value");
            }
        }

        private void BtSetCurrent_Click(object sender, EventArgs e)
        {
            if (float.TryParse(tbCurrent.Text, out float current))
            {
                Log($"Set Current: {current}");
                bldc.SetCurrent(current);
            }
            else
            {
                Log("Error: Incorrect Input Value");
            }
        }

        private void BtSetCurrentBrake_Click(object sender, EventArgs e)
        {
            if (float.TryParse(tbCurrentBrake.Text, out float current))
            {
                Log($"Set Current Brake: {current}");
                bldc.SetCurrentBrake(current);
            }
            else
            {
                Log("Error: Incorrect Input Value");
            }
        }

        private void BtSetRPM_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbRpm.Text, out int rpm))
            {
                Log($"Set RPM: {rpm}");
                bldc.SetRpm(rpm);
            }
            else
            {
                Log("Error: Incorrect Input Value");
            }
        }

        private void BtSetPos_Click(object sender, EventArgs e)
        {
            if (float.TryParse(tbPos.Text, out float pos))
            {
                Log($"Set Position: {pos}");
                bldc.SetPos(pos);
            }
            else
            {
                Log("Error: Incorrect Input Value");
            }
        }

        private void BtSetHandbrake_Click(object sender, EventArgs e)
        {
            if (float.TryParse(tbHandbrake.Text, out float current))
            {
                Log($"Set Handbrake: {current}");
                bldc.SetHandbrake(current);
            }
            else
            {
                Log("Error: Incorrect Input Value");
            }
        }

        private void BtSetServoPos_Click(object sender, EventArgs e)
        {
            if (float.TryParse(tbServoPos.Text, out float pos))
            {
                Log($"Set Servo Position: {pos}");
                bldc.SetServoPos(pos);
            }
            else
            {
                Log("Error: Incorrect Input Value");
            }
        }

        private void BtDetectEncoder_Click(object sender, EventArgs e)
        {
            if(float.TryParse(tbDetectEncoder.Text, out float current))
            {
                Log($"Detect Encoder: {current}");
                bldc.DetectEncoder(current);
            }
            else
            {
                Log("Error: Incorrect Input Value");
            }
        }

        private void Log(string msg)
        {
            if(textBoxLog.InvokeRequired)
            {
                textBoxLog.Invoke((MethodInvoker)delegate
                {
                    textBoxLog.AppendText($"{msg}{Environment.NewLine}");
                });
            }
            else
            {
                textBoxLog.AppendText($"{msg}{Environment.NewLine}");
            }
        }
    }
}
