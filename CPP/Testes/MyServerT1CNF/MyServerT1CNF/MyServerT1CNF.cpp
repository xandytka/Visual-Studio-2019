#include "pch.h"
//#include <windows.h>

#using <System.Drawing.dll>
#using <System.dll>
#using <System.Windows.Forms.dll>

using namespace System;
using namespace System::Collections;
using namespace System::ComponentModel;
using namespace System::Drawing;
using namespace System::Threading;
using namespace System::Windows::Forms;
using namespace System::Net;
using namespace System::Net::Sockets;




static void StartServer();

int main(array<System::String ^> ^args)
{
    try {
        StartServer();
    }
    catch (Exception^ ex) {
        MessageBox::Show(ex->ToString());
    }

    return 0;
}

 static void StartServer() {

    IPAddress^ iPAddress = IPAddress::Parse("192.168.0.12");
    IPEndPoint^ localEndPoint = gcnew IPEndPoint(iPAddress, 8910);

    Int32 port = 8910; // Set the TcpListener on port 8910.
    TcpListener^ server = nullptr;

    try
    {

        // TcpListener server = new TcpListener(port);
        server = gcnew TcpListener(iPAddress, port);

        // Start listening for client requests.
        server->Start();

        // Buffer for reading data

        array<Byte>^ bytes = gcnew array<Byte>(256);
        //String^ data = nullptr;
        String^ data = "";

        // Enter the listening loop.
        while (data->ToString() != "bye\r\n")
        {
            Console::Write("Waiting for a connection... ");

            // Perform a blocking call to accept requests.
            // You could also use server.AcceptSocket() here.
            TcpClient^ client = server->AcceptTcpClient();
            Console::WriteLine("Connected!");


            // Get a stream object for reading and writing
            NetworkStream^ stream = client->GetStream();
            
              data = System::Text::Encoding::ASCII->GetString(bytes, 0, stream->Read(bytes, 0, bytes->Length));
            //data = System::Text::Encoding::ASCII::GetString(bytes, 0, stream->Read(bytes, 0, bytes->Length ));
            Console::WriteLine("Received: {0}", data);

            // Shutdown and end connection
            client->Close();
        }
    }
    catch (SocketException^ e)
    {
        Console::WriteLine("SocketException: {0}", e);
    }
    finally
    {
        // Stop listening for new clients.
        server->Stop();
    }

    Console::WriteLine("\nHit enter to continue...");
    Console::Read();
}

