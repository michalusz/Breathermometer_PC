using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breathermometer
{
    public partial class Form1 : Form
    {
        Timer apppTick;
        double number = 0;
        double increment = 0.01;
        public Form1()
        {
            InitializeComponent();
            apppTick = new Timer();
            apppTick.Interval = 100;
            apppTick.Start();
            apppTick.Tick += new EventHandler(appTickEvent);
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Breathermometer application\nDorota Uszyńska 2017");
        }

        private void appTickEvent(Object myObject, EventArgs myEventArgs)
        {
            //chart1.Series[0] = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1.Series[0].Points.AddY(Math.Sin(number));
            textBox1.Text = number.ToString();
            number+=increment;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            apppTick.Interval = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            increment = (double)(trackBar2.Value)/1000;
        }
    }
}
