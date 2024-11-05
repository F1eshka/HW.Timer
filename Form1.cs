using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace HW.Timer
{
    public partial class Form1 : Form
    {
        private static Stopwatch stopwatch;
        private static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer(); // Статический таймер

        public Form1()
        {
            InitializeComponent();

            stopwatch = new Stopwatch();
            stopwatch.Start();

          
            myTimer.Interval = 1; 
            myTimer.Tick += Timer_Tick; 
            myTimer.Start(); 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Text = $"Прошло миллисекунд: {stopwatch.ElapsedMilliseconds}";
        }
    }
}
