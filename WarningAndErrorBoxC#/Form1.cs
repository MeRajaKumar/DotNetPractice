using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarningAndErrorBox
{
    public partial class Form1 : Form
    {
        Form2 obj = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnshow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to c#", "hello", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            obj.Show();
        }
    }
}
