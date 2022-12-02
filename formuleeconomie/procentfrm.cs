using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace formuleeconomie
{
    public partial class procentfrm : Form
    {
        public procentfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float p = float.Parse(textBox2.Text);

            float r = (a  /  100) * p;
            float t = r + a;
            textBox3.Text = r.ToString();
            textBox4.Text = t.ToString();

        }
    }
}
