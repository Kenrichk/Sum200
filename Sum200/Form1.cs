using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sum200
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int i,  topNum, sum=0;
            topNum = Convert.ToInt32(txtTopNum.Text);
            for (i = 0; i <= topNum; i++)
            {
                sum += i;
                if (i == topNum / 2) txtMidSum.Text = Convert.ToString(sum);
            }
            txtSum.Text = Convert.ToString(sum);
        }
    }
}
