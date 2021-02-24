using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyServerT1CNF
{
    class Program
    {
        static int Main(string[] args)
        {
            StartServer();
            return 0;
        }

        public static void StartServer()
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

                // Enter the listening loop.
                while (data.ToString() != "bye")
                {
                    Console.Write("Waiting for a connection... ");

                    // Perform a blocking call to accept requests.
                    // You could also use server.AcceptSocket() here.
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");


                    // Get a stream object for reading and writing
                    NetworkStream stream = client.GetStream();

                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, stream.Read(bytes, 0, bytes.Length));
                    //data = System.Text.Encoding.UTF8.GetString(bytes, 0, stream.Read(bytes, 0, bytes.Length));
                    Console.WriteLine("Received: {0}", data);

                    // Shutdown and end connection
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }

            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }

    }






}


