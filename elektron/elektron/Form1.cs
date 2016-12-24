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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void theoriyaTSMI_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutForm = new AboutBox1();
            aboutForm.Show();
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valueUser;
            valueUser = listBox1.SelectedItem.ToString();
            Transistor KT315 = new Transistor();
            Transistor KT501 = new Transistor();
            Transistor KT502 = new Transistor();
            Transistor KT807 = new Transistor();
            Transistor KT815 = new Transistor();

            if (valueUser == "КТ315" || valueUser=="КТ808" || valueUser=="КТ818" || valueUser=="КТ819") //819 808 818
            {
                KT315.Uip = 12;
                KT315.Pmax = 150;
                KT315.H21 = 50;
                KT315.Imax = 150;
                KT315.Ube = 0.66;
                KT315.proc = 0.8;
                double Ppm = KT315.proc * KT315.Pmax;

                double Ik0 = Ppm / (KT315.Uip / 2);
                double R = ((KT315.Uip / 2) / Ik0) * 1000;
                double R1 = 270, R2 = 27;

                double Uk0 = (KT315.Uip - Ik0 * R2);
                double Ik = KT315.Uip / (R1 + R2);
                double Ib = Ik / KT315.H21;

                double R3 = KT315.Uip / Ib;
                textBox4.Text = R3.ToString();
                double Ik02 = Ik0 / 1000;
                double Ue = Ik02 * R2;
                textBox5.Text = Ue.ToString();
                double Ub = Ue + KT315.Ube;
                textBox6.Text = Ub.ToString();

            }
            else if (valueUser == "КТ501" || valueUser=="КТ506" || valueUser=="КТ816" || valueUser=="КТ812") //506 816 812
            {
                KT501.H21 = 40;
                KT501.Pmax = 300;
                KT501.Uip = 12;
                KT501.proc = 0.8;
                KT501.Ube = 15;
                KT501.Imax = 300;

                double Ppm = KT501.proc * KT501.Pmax;

                double Ik0 = Ppm / (KT501.Uip / 2);
                double R = ((KT501.Uip / 2) / Ik0) * 1000;
                double R1 = 270, R2 = 27;

                double Uk0 = (KT501.Uip - Ik0 * R2);
                double Ik = KT501.Uip / (R1 + R2);
                double Ib = Ik / KT501.H21;

                double R3 = KT501.Uip / Ib;
                textBox4.Text = R3.ToString();
                double Ik02 = Ik0 / 1000;
                double Ue = Ik02 * R2;
                textBox5.Text = Ue.ToString();
                double Ub = Ue + KT501.Ube;
                textBox6.Text = Ub.ToString();
            }

            else if (valueUser == "КТ502" || valueUser=="КТ805" || valueUser=="КТ814") //805 814
            {
                KT502.H21 = 120;
                KT502.Ube = 5;
                KT502.Imax = 150;
                KT502.Uip = 12;
                KT502.proc = 0.8;
                KT502.Pmax = 350;

                double Ppm = KT502.proc * KT502.Pmax;

                double Ik0 = Ppm / (KT502.Uip / 2);
                double R = ((KT502.Uip / 2) / Ik0) * 1000;
                double R1 = 270, R2 = 27;

                double Uk0 = (KT502.Uip - Ik0 * R2);
                double Ik = KT502.Uip / (R1 + R2);
                double Ib = Ik / KT502.H21;

                double R3 = KT502.Uip / Ib;
                textBox4.Text = R3.ToString();
                double Ik02 = Ik0 / 1000;
                double Ue = Ik02 * R2;
                textBox5.Text = Ue.ToString();
                double Ub = Ue + KT502.Ube;
                textBox6.Text = Ub.ToString();
            }

            else if (valueUser == "КТ807" || valueUser=="КТ504" || valueUser=="КТ817") //504 817
            {
                KT807.proc = 0.8;
                KT807.Uip = 12;
                KT807.H21 = 45;
                KT807.Pmax = 10;
                KT807.Ube = 4;
                KT807.Imax = 0.5;

                double Ppm = KT807.proc * KT807.Pmax;

                double Ik0 = Ppm / (KT807.Uip / 2);
                double R = ((KT807.Uip / 2) / Ik0) * 1000;
                double R1 = 270, R2 = 27;

                double Uk0 = (KT807.Uip - Ik0 * R2);
                double Ik = KT807.Uip / (R1 + R2);
                double Ib = Ik / KT807.H21;

                double R3 = KT807.Uip / Ib;
                textBox4.Text = R3.ToString();
                double Ik02 = Ik0 / 1000;
                double Ue = Ik02 * R2;
                textBox5.Text = Ue.ToString();
                double Ub = Ue + KT807.Ube;
                textBox6.Text = Ub.ToString();
            }

            else if(valueUser=="КТ815"|| valueUser=="КТ503" || valueUser=="КТ805") //503 805
            {
                KT815.proc = 0.8;
                KT815.Uip = 12;
                KT815.H21 = 40;
                KT815.Pmax = 10;
                KT815.Ube = 5;
                KT815.Imax = 1.5;

                double Ppm = KT815.proc * KT815.Pmax;

                double Ik0 = Ppm / (KT815.Uip / 2);
                double R = ((KT815.Uip / 2) / Ik0) * 1000;
                double R1 = 270, R2 = 27;

                double Uk0 = (KT815.Uip - Ik0 * R2);
                double Ik = KT815.Uip / (R1 + R2);
                double Ib = Ik / KT815.H21;

                double R3 = KT815.Uip / Ib;
                textBox4.Text = R3.ToString();
                double Ik02 = Ik0 / 1000;
                double Ue = Ik02 * R2;
                textBox5.Text = Ue.ToString();
                double Ub = Ue + KT815.Ube;
                textBox6.Text = Ub.ToString();
            }
          
        }

        private void VahTSMI_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.Show();
        }

        private void входнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 VahForm = new Form3();
            VahForm.Show();
        }

        private void выходнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 setCharacter = new Form4();
            setCharacter.Show();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 helpForm = new Form5();
            helpForm.Show();
        }
    }
}
