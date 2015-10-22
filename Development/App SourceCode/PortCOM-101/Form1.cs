using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortCOM_101
{
    using System.IO.Ports;

    public partial class Form1 : Form
    {
        
        Controller _controller;
        //private Queue<ushort> receivedData = new Queue<ushort>();

        string com_portname;
        int com_baudrate;

        public Form1()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (cbPortName.SelectedValue != null)
            {
                com_portname = cbPortName.SelectedItem.ToString();
                _controller = new Controller(com_portname, 19200, Parity.None, 8, StopBits.One);
                _controller.DataReceived += ControllerOnDataReceived;
                _controller.Open();

            }
            else
            {
                //
            }
        }

        private void ControllerOnDataReceived(object sender, ControllerDataReceivedEventArgs controllerDataReceivedEventArgs)
        {
            //receivedData.Enqueue(controllerDataReceivedEventArgs.BoardData[0]);
            //processQueue();
        }

        private void mySerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void cbPortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var ports = System.IO.Ports.SerialPort.GetPortNames();
            //cbPortName.DataSource = ports;
        }

        private void cbPortName_Click(object sender, EventArgs e)
        {
            var ports = System.IO.Ports.SerialPort.GetPortNames();
            cbPortName.DataSource = ports;
        }

        private void btDesconectar_Click(object sender, EventArgs e)
        {

        }
    }
}
