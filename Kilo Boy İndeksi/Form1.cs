using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kilo_Boy_İndeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kilo;
            double boy;
            kilo = Convert.ToDouble(textBox1.Text);
            boy = Convert.ToDouble(textBox2.Text);
            double indeks = kilo / (boy * boy);
            if (indeks < 18)
            {
                MessageBox.Show("Underweight");

            }
            else if (indeks > 18 && indeks < 25)
            {
                MessageBox.Show("Normal");
            }
            else if (indeks > 25 && indeks < 30)
            {
                MessageBox.Show("Overweight");
            }
            else if (indeks > 30 && indeks < 35)
            {
                MessageBox.Show("Obese");
            }
            else
            {
                MessageBox.Show("Exteremly Obese");
            }
        }

        /*private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }*/
    }
}
