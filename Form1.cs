using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CalculatorEconomika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_SumCredit.MaxLength = 8;
            txt_Year.MaxLength = 2;
            txt_Percent.MaxLength = 2;
        }

        private void txt_Year_TextChanged(object sender, EventArgs e)
        {
            

            if (txt_Year.TextLength > 0)
            {
                int YearNumber = Convert.ToInt32(txt_Year.Text);
                label9.Text = Convert.ToString(YearNumber * 12);
            }
            else
                label9.Text = "0";
        }

        private void txt_Year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Equals();
        }

        private void txt_SumCredit_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void check_round_CheckedChanged(object sender, EventArgs e)
        {
            if (check_round.Checked)
            {
                label10.Text = Convert.ToString(Math.Round(Convert.ToDouble(label10.Text)));
                label11.Text = Convert.ToString(Math.Round(Convert.ToDouble(label11.Text)));
                label12.Text = Convert.ToString(Math.Round(Convert.ToDouble(label12.Text)));
            }
            else
            {
                Equals();
            }
        }
        void Equals()
        {
            double z = Convert.ToDouble(txt_Percent.Text);
            double Y = z / 12 / 100;
            double x = (Y * Math.Pow(1 + Y, Convert.ToDouble(txt_Year.Text))) / (Math.Pow(1 + Y, Convert.ToDouble(txt_Year.Text)) - 1);
            double P = Math.Round(x * Convert.ToInt32(txt_SumCredit.Text), 2);
            label10.Text = P.ToString();
            label11.Text = Convert.ToString(P * Convert.ToDouble(label9.Text));
            label12.Text = Convert.ToString(Convert.ToDouble(label11.Text) - Convert.ToInt32(txt_SumCredit.Text));
        }
    }
}
