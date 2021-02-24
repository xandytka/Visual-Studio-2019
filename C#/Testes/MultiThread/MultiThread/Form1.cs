using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread thread1;
        private void btnThread1_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(t =>
            {
                for(int i = 0; i < 100; i++)
                {
                    int with = rd.Next(0,this.Width);
                    int height = rd.Next(50, this.Height);
                    this.CreateGraphics().DrawEllipse(new Pen(Brushes.Red, 1), new Rectangle(with, height, 10, 10));
                    label1.Text = i.ToString();
                    //Delay
                    Thread.Sleep(100);
                }
            })
            { IsBackground = true };
            thread1.Start();
        }

        Random rd;

        private void Form1_Load(object sender, EventArgs e)
        {
            rd = new Random();
        }

        Thread thread2;
        private void btnThread2_Click(object sender, EventArgs e)
        {
            thread2 = new Thread(t =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int with = rd.Next(0, this.Width);
                    int height = rd.Next(50, this.Height);
                    this.CreateGraphics().DrawEllipse(new Pen(Brushes.Blue, 1), new Rectangle(with, height, 10, 10));
                    label2.Text = i.ToString();
                    //Delay
                    Thread.Sleep(100);
                }
            })
            { IsBackground = true };
            thread2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thread1.Abort();
        }

        private void btnTh1Suspend_Click(object sender, EventArgs e)
        {
            thread1.Suspend();

        }

        private void btnTh1Resume_Click(object sender, EventArgs e)
        {
            thread1.Resume();
        }

        private void btnTh2Suspend_Click(object sender, EventArgs e)
        {
            thread2.Suspend();
        }

        private void btnTh2Resume_Click(object sender, EventArgs e)
        {
            thread2.Resume();
        }

        private void btnTh2Abort_Click(object sender, EventArgs e)
        {
            thread2.Abort();
        }
    }
}
