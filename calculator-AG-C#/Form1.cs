using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorAG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            int six;
            Convert.ToInt32(six = 6);
            resultBox.Text = resultBox.Text + six + "";

        }
        private void Button8_Click(object sender, EventArgs e)
        {
            int eight;
            Convert.ToInt32(eight = 8);
            resultBox.Text = resultBox.Text + eight + "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {

        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            int one;
            Convert.ToInt32(one = 1);
            resultBox.Text = resultBox.Text + one  + "";
            
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            int seven;
            Convert.ToInt32(seven = 7);
            resultBox.Text =resultBox.Text + seven +"";
        }

        private void IntoBtn_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + " x ";
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + " / ";
        }

        private void PerBtn_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + " % ";
        }

        private void totalDelBtn_Click(object sender, EventArgs e)
        {
            resultBox.Text = " ";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int two;
            Convert.ToInt32(two = 2);
            resultBox.Text = resultBox.Text + two + "";

        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            int three;
            Convert.ToInt32(three = 3);
            resultBox.Text = resultBox.Text + three + "";

        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            int four;
            Convert.ToInt32(four = 4);
            resultBox.Text = resultBox.Text + four + "";
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            int five;
            Convert.ToInt32(five = 5);
            resultBox.Text = resultBox.Text + five + "";
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            int eight;
            Convert.ToInt32(eight = 8);
            resultBox.Text = resultBox.Text + eight + "";
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            int nine;
            Convert.ToInt32(nine = 9);
            resultBox.Text = resultBox.Text + nine + "";
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + " - ";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + " + ";
            if (oneBtn || twoBtn||threeBtn  fourBtn )
        }
        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            int zero;
            Convert.ToInt32(zero = 0);
            resultBox.Text = resultBox.Text + zero + "";
        }

    }
}

