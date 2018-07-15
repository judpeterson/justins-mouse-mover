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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
        }

        private static void TimerEventProcessor(Object myObject,
                                        EventArgs myEventArgs)
        {
            Cursor.Position = new Point(Cursor.Position.X - 3, Cursor.Position.Y - 3);
            SendKeys.Send("{RIGHT}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 50000;
            myTimer.Start();
            Application.DoEvents();
            pictureBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myTimer.Stop();
            pictureBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
