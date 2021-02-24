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

namespace MyServerT1WFNF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            IPAddress iPAddress = IPAddress.Parse("192.168.0.12");
            IPEndPoint localEndPoint = new IPEndPoint(iPAddress, 8910);

            Int32 port = 8910; // Set the TcpListener on port 8910.
            TcpListener server = null;

            try
            {

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(iPAddress, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = "";
                String Receivedata = "";

                // Enter the listening loop.
                BackgroundWorker worker = sender as BackgroundWorker;
                while (data.ToString() != "bye")
                {

                    Receivedata += "Waiting for a connection...\r\n";


                    // Perform a blocking call to accept requests.
                    // You could also use server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    Receivedata += ("Connected!\r\n");


                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, stream.Read(bytes, 0, bytes.Length));
                    //data = System.Text.Encoding.UTF8.GetString(bytes, 0, stream.Read(bytes, 0, bytes.Length));
                    //Console.WriteLine("Received: {0}", data);
                    Receivedata += data + "\r\n";
                    worker.ReportProgress(Receivedata.Length, Receivedata);

                    // Shutdown and end connection
                    client.Close();

                }
            }
            catch (SocketException se)
            {
                MessageBox.Show("SocketException: {0}", se.ToString());
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }

            MessageBox.Show("Fim de programa");

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            txtbReceive.Text = e.UserState as String;
        }
    }
}
