using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutLineApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(40, 360);
            this.Height = 300;
            this.Width = 1280;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            SolidBrush brushWhite = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(brushWhite, 0, 0,
            this.ClientSize.Width, this.ClientSize.Height);

            FontFamily fontFamily = new FontFamily("Arial");
            StringFormat strformat = new StringFormat();
            string szbuf = "Fortunately, I have a workaround for this problem. We can set the LineJoin property of GDI+ pen to LineJoinRound to avoid sharp edges and corners.";
            int mySize = szbuf.Length;
            for (int i = 0; i < mySize; i = i + 50)
            {
                szbuf.Insert(i,"\n");
            }


            GraphicsPath path = new GraphicsPath();
            path.AddString(szbuf, fontFamily,
            (int)FontStyle.Regular, 48.0f, new Point(10, 10), strformat);
            Pen pen = new Pen(Color.FromArgb(234, 137, 6), 6);
            pen.LineJoin = LineJoin.Round;
            e.Graphics.DrawPath(pen, path);
            SolidBrush brush = new SolidBrush(Color.FromArgb(128, 0, 255));
            e.Graphics.FillPath(brush, path);

            brushWhite.Dispose();
            fontFamily.Dispose();
            path.Dispose();
            pen.Dispose();
            brush.Dispose();
            e.Graphics.Dispose();
        }
    }
}
