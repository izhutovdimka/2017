using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace elektron
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            /*ZedGraphControl zgcont = new ZedGraphControl();
            zgcont.Location = new Point(400, 400);
            zgcont.Name = "Graphik";
            zgcont.Size = new Size(200, 200);*/
            
        }

        private void Draw()
        {
            double[] arrX = {2, 4, 6, 8, 10 };
            double[] arrY = new double[10];
            arrY[0] = 0.9;
            arrY[1] = 1.1;
            arrY[2] = 1.19;
            arrY[3] = 1.33;
            arrY[4] = 1.7;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] arrY = { 0, 0.01, 0.03, 0.06, 0.13, 0.37};
            double[] arrX = { 0, 0.4, 0.6, 0.7, 0.9, 1 };

            //double[] xx = {  0.3, 0.33, 0.4, 1.1, 2.3, 4, 6 };
            //double[] yy = {  0.19, 0.3, 0.8, 0.9, 0.92, 0.922, 0.99 };
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < arrX.Length; i++)
                chart1.Series[0].Points.AddXY(arrX[i], arrY[i]);
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
