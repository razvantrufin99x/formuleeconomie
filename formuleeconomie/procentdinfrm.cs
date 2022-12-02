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
    public partial class procentdinfrm : Form
    {
        public procentdinfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float t = float.Parse(textBox1.Text);
            float p = float.Parse(textBox2.Text);

            float r = (p / t)*100;
            float a = t - r ;
            textBox3.Text = r.ToString();
            textBox4.Text = a.ToString();

            // 100 + 19  =119
            // 19 % din 119 = 19

            //100 = v + 19%
            //19% = x

            //84 + 19% = 99.96
            //99.96 - 19% = 19

            //100 + 19% = 119
            //119 - 19% = 96
            //119 - 15.5% = 100
            //15.5% = (19/(119))*100


        }
    }
}
