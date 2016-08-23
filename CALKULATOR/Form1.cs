using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALKULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static double plus (double a, double b)
        {
            return a + b;
        }
        static double minus(double a, double b)
        {
            return a - b;
        }
        static double ymnoz(double a, double b)
        {
            return a * b;
        }
        static double delit(double a, double b)
        {
            return a / b;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(plus(Convert.ToDouble(textBox2.Text),Convert.ToDouble(textBox1.Text)));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(minus(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox1.Text)));
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(ymnoz(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox1.Text)));
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(delit(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox1.Text)));
        }

    }
}
