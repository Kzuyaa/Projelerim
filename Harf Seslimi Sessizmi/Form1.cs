using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harf_Seslimi_Sessizmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string alfabe = comboBox1.Text;
            switch (alfabe)
            {
                case "A":
                case "E":
                case "I":
                case "İ":
                case "O":
                case "Ö":
                case "U":
                case "Ü":
                    label1.Text = comboBox1.SelectedItem + "Sesli Harftir";
                    break;
                case "B":
                case "C":
                case "Ç":
                case "D":
                case "F":
                case "G":
                case "Ğ":
                case "H":
                case "J":
                case "K":
                case "L":
                case "M":
                case "N":
                case "P":
                case "R":
                case "S":
                case "Ş":
                case "T":
                case "V":
                case "Y":
                case "Z":
                    label1.Text = comboBox1.SelectedItem + "Sessiz Harfdir";
                    break
                        ;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("A");
            comboBox1.Items.Add("B");
            comboBox1.Items.Add("C");
            comboBox1.Items.Add("Ç");
            comboBox1.Items.Add("D");
            comboBox1.Items.Add("E");
            comboBox1.Items.Add("F");
            comboBox1.Items.Add("G");
            comboBox1.Items.Add("Ğ");
            comboBox1.Items.Add("H");
            comboBox1.Items.Add("I");
            comboBox1.Items.Add("İ");
            comboBox1.Items.Add("J");
            comboBox1.Items.Add("K");
            comboBox1.Items.Add("L");
            comboBox1.Items.Add("M");
            comboBox1.Items.Add("N");
            comboBox1.Items.Add("O");
            comboBox1.Items.Add("Ö");
            comboBox1.Items.Add("P");
            comboBox1.Items.Add("R");
            comboBox1.Items.Add("S");
            comboBox1.Items.Add("Ş");
            comboBox1.Items.Add("T");
            comboBox1.Items.Add("U");
            comboBox1.Items.Add("Ü");
            comboBox1.Items.Add("V");
            comboBox1.Items.Add("Y");
            comboBox1.Items.Add("Z");
        }
    }
}
