using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkceDogru, matDogru;
            double turkceYanlıs, matYanlıs;
            double turkceNet, matNet;
            turkceDogru = Convert.ToDouble(textBox1.Text);
            turkceYanlıs = Convert.ToDouble(textBox2.Text);
            turkceNet = (turkceDogru - (turkceYanlıs / 4));
            textBox3.Text = turkceNet.ToString();
            matDogru = Convert.ToDouble(textBox4.Text);
            matYanlıs = Convert.ToDouble(textBox5.Text);
            matNet = (matDogru - (matYanlıs / 4));
            textBox6.Text = matNet.ToString();


        }
    }
}
