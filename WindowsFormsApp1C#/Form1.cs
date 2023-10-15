using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class btnResult : Form
    {
        public btnResult()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(txtBox.Text);
                if(num %2==0)
                    { lblResult.Text  = num + " is an even number"; }
                else { lblResult.Text  = num + "is an odd number"; }
            txtBox.Text = " ";
            txtBox.Focus ();

        }
    }
}
