using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Sockets;

namespace MyVNR
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		[DllImport("User32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
		private IntPtr _ClipboardViewerNext;

		private void Form1_Load(object sender, EventArgs e)
		{
			backgroundWorker1.RunWorkerAsync();
			_ClipboardViewerNext = SetClipboardViewer(this.Handle);

		}
		protected override void WndProc(ref System.Windows.Forms.Message m)
		{
			IDataObject iData = Clipboard.GetDataObject();
			const int WM_DRAWCLIPBOARD = 0x308;

			switch (m.Msg)
			{
				case WM_DRAWCLIPBOARD:
					//Clipboard is Change 
					//your code..............
					if (iData.GetDataPresent(DataFormats.Text))
					{
						// Yes it is, so display it in a text box.
						//StartClient((String)(iData.GetData(DataFormats.Text)));
						//txtbView.Text = (String)(iData.GetData(DataFormats.Text));
						txtbView.Text = (String)iData.GetData(DataFormats.UnicodeText);
						//txtbView.Text = (String)(iData.GetData(DataFormats.Text));
						StartClient(txtbView.Text);
					}
					break;
				default:
					base.WndProc(ref m);
					break;
			}
		}
		private static void StartClient(String message)
		{
			//Client => Send Data
			byte[] bytes = new byte[1024];

			try
			{
				IPAddress ipAddress = IPAddress.Parse("192.168.0.2");
				IPEndPoint remoteEP = new IPEndPoint(ipAddress, 8911);

				// Create a TCP/IP  socket.    
				Socket sender = new Socket(ipAddress.AddressFamily,
					SocketType.Stream, ProtocolType.Tcp);

				// Connect the socket to the remote endpoint. Catch any errors.    
				try
				{
					// Connect to Remote EndPoint  
					sender.Connect(remoteEP);

					Console.WriteLine(sender.RemoteEndPoint.ToString());

					// Encode the data string into a byte array.    
					//byte[] msg = Encoding.ASCII.GetBytes(message);
					byte[] msg = Encoding.UTF8.GetBytes(message);
					//byte[] msg = Encoding.Unicode.GetBytes(message);

					// Send the data through the socket.    
					int bytesSent = sender.Send(msg);

					// Release the socket.    
					sender.Shutdown(SocketShutdown.Both);
					sender.Close();

				}
				catch (ArgumentNullException ane)
				{
					MessageBox.Show("ArgumentNullException : {0}", ane.ToString());
				}
				catch (SocketException se)
				{
					MessageBox.Show("SocketException : {0}", se.ToString());
				}
				catch (Exception e)
				{
					MessageBox.Show("Unexpected exception : {0}", e.ToString());
				}

			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString());
			}
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			// server <= receive data
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

					//Receivedata += "Waiting for a connection...\r\n";


					// Perform a blocking call to accept requests.
					// You could also use server.AcceptSocket() here.
					TcpClient client = server.AcceptTcpClient();
					//Receivedata += ("Connected!\r\n");


					// Get a stream object for reading and writing
					NetworkStream stream = client.GetStream();

					//data = System.Text.Encoding.ASCII.GetString(bytes, 0, stream.Read(bytes, 0, bytes.Length));
					data = System.Text.Encoding.UTF8.GetString(bytes, 0, stream.Read(bytes, 0, bytes.Length));
					//Console.WriteLine("Received: {0}", data);
					Receivedata = data;
					worker.ReportProgress(Receivedata.Length, Receivedata);

					// Shutdown and end connection
					client.Close();

				}
			}
			catch (SocketException se)
			{
				MessageBox.Show(se.ToString());
			}

		}

		private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			txtbTrans.Text = e.UserState as String;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//backgroundWorker1.RunWorkerAsync();

		}
	}
}
