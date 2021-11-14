using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server_
{
    public partial class Form1 : Form
    {
        Socket mainSocket;
        List<Socket> workerSockets = new List<Socket>();

        public Form1()
        {
            InitializeComponent();
            //get a vail local ip 
            ipAddressBox.Text = GetLocalIp();
            portNOBox.Text = "8000";
        }
        String GetLocalIp()
        {
            String hostName = Dns.GetHostName();
            IPHostEntry ipHost = Dns.GetHostByName(hostName);
            //return the last member on the list
            return ipHost.AddressList[ipHost.AddressList.Length-1].ToString();
        }
        void updateGUI(bool isRunning)
        {
            startButton.Enabled = !isRunning;
            stopButton.Enabled = isRunning;
            sendMessegeButton.Enabled = isRunning;
            statusLabel.Text = isRunning ? "Start" : "Stop";
            statusLabel.ForeColor = isRunning ? Color.Green : Color.Red;
            ipAddressBox.Enabled = !isRunning;
            portNOBox.Enabled = !isRunning;
        }
        void startServer()
        {
            IPAddress serverIp;
            if(!IPAddress.TryParse(ipAddressBox.Text.Trim(),out serverIp))
            {
                MessageBox.Show("Please , Insert ip address in correct format");
                ipAddressBox.Focus();
                return;
            }
            int serverportNo;
            if(!int.TryParse(portNOBox.Text.Trim(),out serverportNo))
            {
                MessageBox.Show("Please , Insert port number in correct format");
                portNOBox.Focus();
                return;
            }
            //create socket 
            mainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //server address
            IPEndPoint serverAddress = new IPEndPoint(serverIp, serverportNo);
            mainSocket.Bind(serverAddress);
            mainSocket.Listen(5);
            mainSocket.BeginAccept(new AsyncCallback(onClientConnect),null);
            updateGUI(true);
        }
        void onClientConnect(IAsyncResult ar)
        {
            try
            {
                if (mainSocket!=null)
                {
                    //Asynchronously accepts an incoming connection attempt and creates a new Socketto handle remote host communication.

                    Socket worker = mainSocket.EndAccept(ar);
                    workerSockets.Add(worker);
                    waitingForData(worker);

                    mainSocket.BeginAccept(new AsyncCallback(onClientConnect), null);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
        void waitingForData(Socket worker)
        {
            if (worker != null && worker.Connected)
            {
                SocketPacket socketPacket = new SocketPacket(worker);
            
               IAsyncResult ar = worker.BeginReceive(socketPacket.buffer, 0, socketPacket.buffer.length, SocketFlags.None, new AsyncCallback(onDataRecieved), socketPacket);
                
            
            }
        }
        void onDataRecieved(IAsyncResult ar)
        {
            SocketPacket socketPacket = (SocketPackte)ar.AsyncState;
            if (socketPacket.Socket != null && socketPacket.Socket.connected)
            {
                //messege received
                int byteCount = socketPacket.Socket.EndReceive(ar);
                if (byteCount == 0)
                {
                    socketPacket.Socket.Close();

                }
                else
                {
                    string msg = Encoding.ASCII.GetString(socketPacket.buffer, 0, byteCount);
                    messegeShowBox.Invoke(new Action(delegate
                    {
                        messegeShowBox.AppendText(msg);
                    }));
                    socketPacket.Socket.BeginReceive(socketPacket.buffer, 0, byteCount, SocketFlags.None, new AsyncCallback(onDataRecieved), socketPacket);

                }
            }
        }
        void stopServer()
        {
            if (mainSocket != null)
            {
                mainSocket.Close();
                mainSocket = null;
                foreach (Socket worker in workerSockets)
                {
                    worker.Close();
                }
                workerSockets.Clear();
                updateGUI(false);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopServer();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startServer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            stopServer();
        }

        private void sendMessegeButton_Click(object sender, EventArgs e)
        {
            
        }
        void sendMessege()
        {
            if (messegeSend.Text.Trim()=="")
            {
                MessageBox.Show("Please, insert messege first");
                messegeSend.Focus();
                return;
            }
            byte[] buffer = Encoding.ASCII.GetBytes("Server: " + messegeSend.Text.Trim() + Environment.NewLine);
            foreach (Socket worker in workerSockets)
            {
                if (worker!=null&&worker.Connected)
                {
                    worker.Send(buffer);
                    messegeShowBox.AppendText("Server: " + messegeSend.Text.Trim() + Environment.NewLine);
                    messegeSend.Text = "";

                }
            }
        }
    }
}
