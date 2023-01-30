using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double avg;
            avg = (a * 0.35) + (b * 0.65);
            if (a>0 && a<=20&& b>0&& b<=20)
            {
                MessageBox.Show(avg.ToString());
            }
            else
            {
                MessageBox.Show("no");
            }
        }
    }
}
