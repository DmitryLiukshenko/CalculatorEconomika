using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Excel.Application excel = new Excel.Application();
            Object formula, result;
            formula = ()
          
        }

        private void txt_Year_TextChanged(object sender, EventArgs e)
        {
            txt_Year.MaxLength = 2;

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
    }
}
