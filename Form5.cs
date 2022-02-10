using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab07
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            label1.Text = "0";
            numericUpDown2.Text= "1";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                double value =(double)numericUpDown1.Value/ (double)numericUpDown2.Value;
                label1.Text=value.ToString();
            }catch(Exception ex)
            {
                label1.Text = "dzielenie przez zero";
            }

        }
    }
}
