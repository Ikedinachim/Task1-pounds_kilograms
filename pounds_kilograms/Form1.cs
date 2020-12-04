using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pounds_kilograms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) {
                textBox2.Text = Convert.ToString(kilogramsToPounds(Convert.ToDouble(textBox1.Text)));
            }else if(comboBox1.SelectedIndex == 1)
            {
                textBox2.Text = Convert.ToString(PoundsToKilograms(Convert.ToDouble(textBox1.Text)));
            }

        }
        private double kilogramsToPounds(double kilogram)
        {
            double pounds = 4.54 * kilogram;
            return pounds;
        }
        private double PoundsToKilograms(double pounds)
        {
            double kilogram = 0.454 * pounds;
            return kilogram;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
