using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Client
{
    public partial class Form1 : Form
    {
        Socket client;
        byte []buffer;
        public Form1()
        {
            InitializeComponent();
            buffer = new byte[1024];
            ipAddressTxt.Text = GetLocalIp();
            portNoTxt.Text = "8000";

            
        }

         string GetLocalIp()
        {
            string hostName = Dns.GetHostName();
            IPHostEntry ipHost = Dns.GetHostByName(hostName);
            return ipHost.AddressList[ipHost.AddressList.Length - 1].ToString();
            
        }
        void updateGUI(bool isRunning)
        {
            connectBtn.Enabled = !isRunning;
            disconnectBtn.Enabled = isRunning;
            sendMessegeBtn.Enabled = isRunning;
            statusLabel.Text = isRunning ? "Connected" : "Dissconnected";
            statusLabel.ForeColor = isRunning ? Color.Green : Color.Red;

            ipAddressTxt.Enabled = !isRunning;
            portNoTxt.Enabled = !isRunning;

        }
        void connectToServer()
        {
            IPAddress serverIp;
            if (!IPAddress.TryParse(ipAddressTxt.Text.Trim(),out serverIp))
            {
                MessageBox.Show("Please, insert Ip Address first");
                ipAddressTxt.Focus();
                return;
            }
            int serverPortNo;
            if (!int.TryParse(portNoTxt.Text.Trim(),out serverPortNo))
            {
                MessageBox.Show("Please, insert port number in correct format");
                portNoTxt.Focus();
                return;

            }
            client = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            IPEndPoint serverAddress = new IPEndPoint(serverIp, serverPortNo);
            try
            {
                client.Connect(serverAddress);
                client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(onDataReceived), null);
                updateGUI(true);

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

         void onDataReceived(IAsyncResult ar)
        {
            try
            {
                if (client!=null&&client.Connected)
                {
                    int byteCount = client.EndReceive(ar);
                    if (byteCount == 0)
                    {
                        this.Invoke(new Action(delegate
                        {
                            DissConnectFromServer();
                        }));
                    }
                    else
                    {
                        string msg = Encoding.ASCII.GetString(buffer, 0, byteCount);
                        messegesVewerBox.Invoke(new Action(delegate
                        {
                            messegesVewerBox.AppendText(msg);

                        }));
                        client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(onDataReceived), null);
                    }
                }
                
            }
            catch (Exception e)
            {

                this.Invoke(new Action(delegate
                {
                    DissConnectFromServer();
                }
                    ));
            }
        }

        private void DissConnectFromServer()
        {
            if (client!=null&&client.Connected)
            {
                client.Disconnect(false);
                client.Close();
                client = null;
                updateGUI(false);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            connectToServer();
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            DissConnectFromServer();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DissConnectFromServer();
        }

        private void sendMessegeBtn_Click(object sender, EventArgs e)
        {
            if (messegeSenderBox.Text.Trim()=="")
            {
                MessageBox.Show("Please, insert messege first");
                messegeSenderBox.Focus();
                return;
            }
            byte[] bufferData = Encoding.ASCII.GetBytes("Client: " + messegeSenderBox.Text.Trim() + Environment.NewLine);
            if (client!=null&&client.Connected)
            {
                client.Send(bufferData);
                messegesVewerBox.AppendText("Client: " + messegeSenderBox.Text.Trim() + Environment.NewLine);
                messegeSenderBox.Text = "";

            }
        }
    }
}
