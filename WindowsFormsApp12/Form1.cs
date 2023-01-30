using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt1.Text);
            double b = Convert.ToDouble(txt2.Text);
            double c = Convert.ToDouble(txt3.Text);
            double mohit = a + b + c;
            if (a+b>c&&a+c>b&&c+b>a)

            {
                MessageBox.Show(mohit.ToString());
            }
            else
            {
                MessageBox.Show("no");
            }
        }
    }
}
