using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
          
                

        }

        private void Button1_Click(object sender, EventArgs e)
        {  double x = Convert.ToDouble(textBox1.Text);
            double result;
            result = Math.Abs(Math.Pow(x, 2) + (Math.Pow(2, x) + Math.Sqrt(x)));
            MessageBox.Show(result.ToString());

        }
    }
}
