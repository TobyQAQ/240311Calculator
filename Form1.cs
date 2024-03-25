using System;
using System.Globalization;
using System.Windows.Forms;

namespace _240311Calculator
{
    public partial class Form1 : Form
    {
        string strInput;
        double douOutput;
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

        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYard_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtCM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtM.Text = string.Format("{0:0.##########}", douOutput / 100);
                txtKM.Text = string.Format("{0:0.##########}", douOutput / 100000);
                txtIn.Text = string.Format("{0:0.##########}", douOutput / 2.54);
                txtFt.Text = string.Format("{0:0.##########}", douOutput / 30.48);
                txtYard.Text = string.Format("{0:0.##########}", douOutput / 91.44);
            }
            else
            {
                txtEX.Text = "請輸入數字";
                txtCM.Text = "";
            }
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douOutput * 100);
            txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.001);
            txtIn.Text = string.Format("{0:0.##########}", douOutput * 39.37);
            txtFt.Text = string.Format("{0:0.##########}", douOutput * 3.28);
            txtYard.Text = string.Format("{0:0.##########}", douOutput * 1.09);
            }
            else
            {
                txtEX.Text = "請輸入數字";
                txtM.Text = "";
            }
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtKM.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
            txtCM.Text = string.Format("{0:0.##########}", douOutput * 100);
            txtM.Text = string.Format("{0:0.##########}", douOutput * 1000);
            txtIn.Text = string.Format("{0:0.##########}", douOutput * 39370.1);
            txtFt.Text = string.Format("{0:0.##########}", douOutput * 3280.84);
            txtYard.Text = string.Format("{0:0.##########}", douOutput * 1093.61);
            }
            else
            {
                txtEX.Text = "請輸入數字";
                txtKM.Text = "";
            }
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtIn.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
            txtCM.Text = string.Format("{0:0.##########}", douOutput * 2.54);
            txtM.Text = string.Format("{0:0.##########}", douOutput * 0.0254);
            txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.0000254);
            txtFt.Text = string.Format("{0:0.##########}", douOutput * 0.0833);
            txtYard.Text = string.Format("{0:0.##########}", douOutput * 0.0278);
            }
            else
            {
                txtEX.Text = "請輸入數字";
                txtIn.Text = "";
            }
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtFt.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douOutput * 30.48);
            txtM.Text = string.Format("{0:0.##########}", douOutput * 0.3048);
            txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.0003048);
            txtIn.Text = string.Format("{0:0.##########}", douOutput * 12);
            txtYard.Text = string.Format("{0:0.##########}", douOutput * 0.3333);
            }
            else
            {
                txtEX.Text = "請輸入數字";
                txtFt.Text = "";
            }
        }

        private void txtYard_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtYard.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtCM.Text = string.Format("{0:0.##########}", douOutput * 91.44);
            txtM.Text = string.Format("{0:0.##########}", douOutput * 0.9144);
            txtKM.Text = string.Format("{0:0.##########}", douOutput * 0.0009144);
            txtIn.Text = string.Format("{0:0.##########}", douOutput * 36);
            txtFt.Text = string.Format("{0:0.##########}", douOutput * 3);
            }
            else
            {
                txtEX.Text = "請輸入數字";
                txtYard.Text = "";
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtCM.Text = "";
            txtM.Text = "";
            txtKM.Text = "";
            txtIn.Text = "";
            txtFt.Text = "";
            txtYard.Text = "";
        }
    }
}
