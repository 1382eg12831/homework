using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var a = Convert.ToDouble(textBox1.Text);
            var b = Convert.ToDouble(textBox2.Text);
            var c = Convert.ToDouble(textBox3.Text);
            double hajm;
            hajm = a * b * c;
            MessageBox.Show(hajm.ToString());
        }
    }
}
