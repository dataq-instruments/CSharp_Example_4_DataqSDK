using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataqSDKCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axDataqSdk1.DeviceDriver=textBox1.Text;

            axDataqSdk1.DeviceID=textBox2.Text;


            axDataqSdk1.SampleRate=Convert.ToDouble(textBox3.Text);

            axDataqSdk1.EventPoint=1;

            timer1.Interval=10;

            timer1.Enabled = true;

            axDataqSdk1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            axDataqSdk1.Stop();
        }

        private void axDataqSdk1_NewData(object sender, AxDATAQSDKLib._DDataqSdkEvents_NewDataEvent e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axDataqSdk1.AvailableData > 0)
            {
                object V;
                short[,] intArray;
                V = axDataqSdk1.GetData();
                
                intArray = (short[,])V;
                label4.Text = intArray[0, 0].ToString();
            }

        }


        private void axDataqSdk1_ControlError(object sender, AxDATAQSDKLib._DDataqSdkEvents_ControlErrorEvent e)
        {
            timer1.Enabled = false;
            axDataqSdk1.Stop();
            MessageBox.Show("Error: Please check DeviceDriver and DeviceID");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
