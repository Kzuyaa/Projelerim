using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alfabedeki_Kaçıncı_Harf
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
                    label2.Text = "A Harfi alfabenin 1. harfidir.";
                    break;
                case "B":
                    label2.Text = "B Harfi alfabenin 2. harfidir.";
                    break;
                case "C":
                    label2.Text = "C Harfi alfabenin 3. harfidir.";
                    break;
                case "D":
                    label2.Text = "D Harfi alfabenin 4. harfidir.";
                    break;
                case "E":
                    label2.Text = "E Harfi alfabenin 5. harfidir.";
                    break;
                case "F":
                    label2.Text = "F Harfi alfabenin 6. harfidir.";
                    break;
                case "G":
                    label2.Text = "G Harfi alfabenin 7. harfidir.";
                    break;
                case "H":
                    label2.Text = "H Harfi alfabenin 8. harfidir.";
                    break;
                case "I":
                    label2.Text = "I Harfi alfabenin 9. harfidir.";
                    break;
                case "J":
                    label2.Text = "J Harfi alfabenin 10. harfidir.";
                    break;
                case "K":
                    label1.Text = "K Harfi alfabenin 11. harfidir.";
                    break;
                case "L":
                    label2.Text = "L Harfi alfabenin 12. harfidir.";
                    break;
                case "M":
                    label2.Text = "M Harfi alfabenin 13. harfidir.";
                    break;
                case "N":
                    label2.Text = "N Harfi alfabenin 14. harfidir.";
                    break;
                case "O":
                    label2.Text = "O Harfi alfabenin 15. harfidir.";
                    break;
                case "P":
                    label2.Text = "P Harfi alfabenin 16. harfidir.";
                    break;
                case "R":
                    label2.Text = "R Harfi alfabenin 17. harfidir.";
                    break;
                case "S":
                    label2.Text = "S Harfi alfabenin 18. harfidir.";
                    break;
                case "T":
                    label2.Text = "T Harfi alfabenin 19. harfidir.";
                    break;
                case "U":
                    label2.Text = "U Harfi alfabenin 20. harfidir.";
                    break;
                case "V":
                    label2.Text = "V Harfi alfabenin 21. harfidir.";
                    break;
                case "Y":
                    label2.Text = "Y Harfi alfabenin 22. harfidir.";
                    break;
                case "Z":
                    label2.Text = "Z Harfi alfabenin 23. harfidir.";
                    break;
                default:
                    label2.Text = "Hata Var";
                    break;
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
