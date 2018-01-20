using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 
using System.IO.Ports;
using System.Windows.Forms;

namespace IFEBluetoothInterface
{
    public partial class BluetoothInterface : Form
    {
        public int count = 0;
        List<string> parse_receive = new List<string>();

        public string datain;

        public BluetoothInterface()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BaudRateDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object Baud = BaudRateDropDown.SelectedItem;
            int Baud_int = Int32.Parse(Baud.ToString());
            BT.BaudRate = Baud_int;
        }

        private void DataBitsDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object DataBits = DataBitsDropDown.SelectedItem;
            int databits_int = Int32.Parse(DataBits.ToString());
            BT.DataBits = databits_int;
        }

        private void ParityDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HandshakeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RefreshListButton_Click(object sender, EventArgs e)
        {
            COMDropDown.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (String x in ports) {
                COMDropDown.Items.Add(x);
            }
                

        }

        private void TransmitDataTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TransmitDataTextBox.Text == "Meher") MessageBox.Show("I've got a dream: 'Anyone can cook, mon cherie!'");
            if (TransmitDataTextBox.Text == "Rose") MessageBox.Show("Sometimes in your life a Daisy sprouts and you become buds.");
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (ConnectButton.Text == "Connect")
            {
                ConnectButton.Text = "Disconnect";
                BT.Open();
            }

            else if (ConnectButton.Text == "Disconnect")
            {
                ConnectButton.Text = "Connect";
                BT.Close();
                MessageBox.Show("Disconnected from bluetooth port");
            }
        }

        private void COMDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            BT.PortName = COMDropDown.Text;
        }

        private void ReceivedDataTextBox_TextChanged(object sender, EventArgs e)
        {
            //ReceivedDataTextBox.Select(0, 0);
            //ReceivedDataTextBox.SelectedText = datain + Environment.NewLine;
        }

        public void BT_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ReceivedDataTextBox.Invoke(new MethodInvoker(delegate
            {
                ReceivedDataTextBox.Clear();
                count++;
                datain = BT.ReadExisting();
                parse_receive.Add(datain);
                parse_receive.Reverse();
                foreach (string x in parse_receive) {
                    ReceivedDataTextBox.AppendText(x + "\n");
                }
                parse_receive.Reverse();
            }));

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string data = TransmitDataTextBox.Text;
            BT.Write(data);
            BT.Write("\r\n");
        }

        private void BluetoothInterface_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void BluetoothInterface_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
