using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VescNET.Domain.DTOs;
using VescNET.Domain.Interfaces;
using VescNET.Infra;

namespace Tester
{
    public partial class Form1 : Form
    {
        IBldc bldc;

        public Form1()
        {
            var buffer = new VescNET.Infra.Buffer();
            var packetProcess = new PacketProcess();
            var packet = new Packet(buffer, packetProcess);
            var serial = new SerialPort();
            var bldcComm = new BldcSerial(packet, serial);

            serial.PortName = "COM16";
            serial.BaudRate = 115200;
            serial.Open();

            bldcComm.OnData += BldcComm_OnData;

            bldc = new Bldc(buffer, bldcComm);
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            bldc.GetFwVersion();
        }

        private void BldcComm_OnData(object sender, VescNET.Domain.DTOs.ReceivedData e)
        {
            
        }
    }
}
