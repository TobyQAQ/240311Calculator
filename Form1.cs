using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _240311Calculator
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

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCM_TextChanged(object sender, EventArgs e)
        {
            double douCM;
            douCM = Convert.ToDouble(txtCM.Text);
            txtM.Text = string.Format("{0:0.##########}", douCM / 100);
            txtKM.Text = string.Format("{0:0.##########}", douCM / 100000);
        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {
            double douM;

            douM = Convert.ToDouble(txtM.Text);

            txtKM.Text = string.Format("{0:0.##########}", douM / 1000);
            txtCM.Text = string.Format("{0:0.##########}", douM * 100);

        }

        private void txtKM_TextChanged(object sender, EventArgs e)
        {
            double douKM;

            douKM = Convert.ToDouble(txtKM.Text);
            txtCM.Text = string.Format("{0:0.##########}", douKM * 100000);
            txtM.Text = string.Format("{0:0.##########}", douKM * 1000);
        }
    }
}
