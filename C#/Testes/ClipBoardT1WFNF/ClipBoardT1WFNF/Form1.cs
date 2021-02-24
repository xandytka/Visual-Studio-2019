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




namespace ClipBoardT1WFNF
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _ClipboardViewerNext = SetClipboardViewer(this.Handle);
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            IDataObject  iData = Clipboard.GetDataObject();
            const int WM_DRAWCLIPBOARD = 0x308;

            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    //Clipboard is Change 
                    //your code..............
                    if (iData.GetDataPresent(DataFormats.Text))
                    {
                        // Yes it is, so display it in a text box.
                        txtbView.Text = (String )(iData.GetData(DataFormats.Text));
                    }
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }


    }
}
