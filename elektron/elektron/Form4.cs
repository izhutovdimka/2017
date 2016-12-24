using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elektron
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] xx = {  0.3, 0.33, 0.4, 1.1, 2.3, 4, 6 };
            double[] yy = {  0.19, 0.3, 0.8, 0.9, 0.92, 0.922, 0.923 };
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < xx.Length; i++)
                chart1.Series[0].Points.AddXY(xx[i], yy[i]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valU = textBox1.Text;
            //double x = Convert.ToDouble(valU);
            textBox2.AppendText(valU + "\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
    }
}
