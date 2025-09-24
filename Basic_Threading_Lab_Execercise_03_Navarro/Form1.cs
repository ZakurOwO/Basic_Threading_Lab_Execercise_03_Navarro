using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Basic_Threading_Lab_Execercise_03_Navarro
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();

        public Form1()
        {
            InitializeComponent();
            AllocConsole();
        }

        private void btnStartandStop_Click(object sender, EventArgs e)
        {
            btnStartandStop.Text = "Stop";

            Console.WriteLine("-Before starting thread-");

            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            Thread ThreadB = new Thread(MyThreadClass.Thread1);

            ThreadA.Name = "Thread A";
            ThreadB.Name = "Thread B";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End of Thread-");
            lblStatus.Text = "-End Of Thread-";
        }
    }
}
