using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a, b, s;
            a = float.Parse(textBox1.Text);
            b = float.Parse(textBox2.Text);
            if (this.comboBox1.SelectedItem.ToString() == "Somme")
            {
                s = a + b;
                textBox3.Text = s.ToString();
            }
            if (this.comboBox1.SelectedItem.ToString() == "Soustraction")
            {
                s = a - b;
                textBox3.Text = s.ToString();
            }
            if (this.comboBox1.SelectedItem.ToString() == "Multiplucation")
            {
                s = a * b;
                textBox3.Text = s.ToString();
            }
            if (this.comboBox1.SelectedItem.ToString() == "Division")
            {
                s = a / b;
                textBox3.Text = s.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
