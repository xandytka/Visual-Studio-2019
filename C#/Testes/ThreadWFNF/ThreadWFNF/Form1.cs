using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace ThreadWFNF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int contador = 41;


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = contador.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quadrado caixa = new Quadrado();
            caixa.setLado_a(4);
            caixa.setLado_b(3);

            label2.Text = caixa.MostraArea().ToString();
        }
        //-------------------------------------------------------------------------------------
        Thread Th1Teste = new Thread(new ThreadStart(contador1));

        private static void contador1()
        {
            for (int i = 0; i <= 100000; i++)
            {

            }
        }


        //-------------------------------------------------------------------------------------

        //-------------------------------------------------------------------------------------

        //-------------------------------------------------------------------------------------


    }
}
