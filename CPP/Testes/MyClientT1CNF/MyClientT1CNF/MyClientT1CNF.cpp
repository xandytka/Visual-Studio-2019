#include "pch.h"

#using <System.Drawing.dll>
#using <System.dll>
#using <System.Windows.Forms.dll>

using namespace System;
using namespace System::Windows::Forms;
using namespace System::Net;
using namespace System::Net::Sockets;

static void StartClient(String^ message);

int main(array<System::String^>^ args)
{
	String^ texto;
	do
	{
		Console::WriteLine("Enviar:");
		texto = Console::ReadLine();
		StartClient(texto);
	} while (texto->ToString() != ("bye"));
	return 0;
}

static void StartClient(String^ message) {

	array<Byte>^ bytes = gcnew array<Byte>(1024);

	try
	{
		IPAddress^ ipAddress = IPAddress::Parse("192.168.0.12");
		IPEndPoint^ remoteEP = gcnew IPEndPoint(ipAddress, 8910);

		// Create a TCP/IP  socket.    
		Socket^ sender = gcnew Socket(ipAddress->AddressFamily, SocketType::Stream,
			ProtocolType::Tcp);

		try
		{
			// Connect to Remote EndPoint  
			sender->Connect(remoteEP);

			Console::WriteLine("Socket connected to {0}",
				sender->RemoteEndPoint->ToString());

			// Encode the data string into a byte array.
			//array<Byte>^ msg = gcnew array<Byte>(1024);
			//msg = System::Text::Encoding::ASCII->GetBytes(message);
			array<Byte>^ msg = System::Text::Encoding::ASCII->GetBytes(message);

			// Send the data through the socket.    
			int bytesSent = sender->Send(msg);


			// Release the socket.    
			sender->Shutdown(SocketShutdown::Both);
			sender->Close();

		}
		catch (SocketException^ se)
		{
			MessageBox::Show(se->ToString());
		}

	}
	catch (Exception^ ex) {
		MessageBox::Show(ex->ToString());
	}

}
