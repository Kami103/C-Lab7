using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        double result = 0;
        double wsp = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
                MessageBox.Show("podaj wzrost!");
            if (checkBox1.Checked)
            {
                result = Double.Parse(textBox1.Text) - 100;
                label4.Text = result + " kg";
            }
            else if (checkBox2.Checked)
            {
                if (radioButton1.Checked)
                    wsp = 0.85;
                else if (radioButton2.Checked)
                    wsp = 0.9;
                else
                    MessageBox.Show("zaznacz plec!");
                result = (Double.Parse(textBox1.Text) - 100) * wsp;
                label4.Text = result + " kg";
            }
            else
                MessageBox.Show("wybierz jedna z dostepnych opcji wagi!");
        }
    }
}
