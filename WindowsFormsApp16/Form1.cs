using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
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
        {
            DateTime birthDay = new DateTime();
            DateTime today = DateTime.Today;
            birthDay = Convert.ToDateTime(textBox1.Text);
            TimeSpan age = today.Subtract(birthDay);
            MessageBox.Show("Your Day Passed Is: " + age);
            int year = age.Days / 365;
            int month = (age.Days % 365) / 30;
            int day = (age.Days % 365) % 30;
            MessageBox.Show("yea:"+year + "month:"+ month + "day:"+day);







        }
    }
}
