// AppForm.cpp : main project file.

#include "MyForm.h"

using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;
using namespace AppForm;


[STAThreadAttribute]
int main(array<System::String ^> ^args)
{
	// Enabling Windows XP visual effects before any controls are created
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	AppForm::MyForm mainForm;
	// Create the main window and run it
	//Application::Run(gcnew MyForm());
	Application::Run(%mainForm);
	return 0;
}
