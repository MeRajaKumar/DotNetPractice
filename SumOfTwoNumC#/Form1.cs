using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumOfTwoNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SumBtn_Click(object sender, EventArgs e)
        {
            int first,second,total;
            first = Convert.ToInt32(txt1.Text);
            second = Convert.ToInt32(txt2.Text);
            total = first + second;
            sumLbl.Text ="sum of "+ first + " and " + second + " = "+  total.ToString();
            txt1.Text = "";
            txt2.Text = "";
            txt1.Focus();

        }
    }
}
