using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSub01
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Create the outline geometry based on the formatted text.
        /// </summary>


        private void button1_Click(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "Access the appropriate setting via the Properties.Settings.Default member. The following example shows how to assign a setting named myColor to a BackColor property. It requires you to have previously created a Settings file containing a setting named myColor of type System.Drawing.Color.";
            float currentSize = 0.0F;
            currentSize = label1.Font.Size;
            currentSize += 24.0F;
            label1.Font = new System.Drawing.Font(this.Font.Name, currentSize);
            this.Height = 300;
            this.Width = 1280;
            label1.Location = new Point(this.Width / 2, this.Height / 2);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Location = new Point(40, 360);
            this.Height = 300;
            this.Width = 1280;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Size = new Size(this.Width - 25, this.Height - 50);
            textBox1.Location = new Point(10, 10);
            textBox1.Font = new System.Drawing.Font(this.Font.Name, 32.0F);
            textBox1.BackColor = this.BackColor;
            textBox1.ForeColor = Color.White;
            textBox1.Text = "Access the appropriate setting via the Properties.Settings.Default member. The following example shows how to assign a setting named myColor to a BackColor property. It requires you to have previously created a Settings file containing a setting named myColor of type System.Drawing.Color.";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //this.BackColor = Color.Turquoise;
            //this.TransparencyKey = Color.Turquoise;
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Blue;
            //this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            //this.TopMost = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            textBox1.Size = new Size(this.Width - 25, this.Height - 50);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
