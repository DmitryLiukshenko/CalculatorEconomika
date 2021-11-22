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
            MoneyTB.MaxLength = 8;
            txt_Year.MaxLength = 2;
            YearPerTB.MaxLength = 2;

        }
        bool Round;

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
            PLT();
            EX2();
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
                PLT();
            }
        }
        void PLT()
        {
            //double Percent = Convert.ToDouble(txt_Percent.Text);
            //double PM = Percent / 12 / 100;
            //double KA = (PM * Math.Pow(1 + PM, Convert.ToDouble(txt_Year.Text))) / (Math.Pow(1 + PM, Convert.ToDouble(txt_Year.Text)) - 1);
            //double PLT = Math.Round(KA * Convert.ToInt32(txt_SumCredit.Text), 2);
            //label10.Text = PLT.ToString();
            //label11.Text = Convert.ToString(PLT * Convert.ToDouble(label9.Text));
            //label12.Text = Convert.ToString(Convert.ToDouble(label11.Text) - Convert.ToInt32(txt_SumCredit.Text));
            double Money = Convert.ToDouble(MoneyTB.Text);
            int M = Convert.ToInt32(MonthTB.Text);
            double PM = Convert.ToDouble(YearPerTB.Text) / 12 / 100;
            
            double KA = (PM * (Math.Pow((1 + PM), M))) / ((Math.Pow((1 + PM), M)) - 1);
            KATB.Text = Convert.ToString(Rounding(KA));
            double PLT = KA * Money;
            PlatiTB.Text = Convert.ToString(Rounding(PLT));
        }
        public double Rounding(double obj)
        {
            if (Round)
            {
                return Math.Round(obj);
            }
            else
            {
                return obj;
            }

            void EX2()
        {
            int Month = Convert.ToInt32(label9.Text);
            double[,] ex2TB = new double[Month,4];
            double Percent = Convert.ToDouble(YearPerTB.Text);
            double PM = Percent / 12 / 100;
            double PLT = Convert.ToDouble(label10.Text);
            try
            {
                this.DB_Payment.Rows.Clear();
                for (int i = 0; i < Month; i++)
                {
                    ex2TB[i, 0] = (PLT - Convert.ToInt32(MoneyTB.Text) * PM) * Math.Pow(1 + PM, i - 1);
                    Trace.WriteLine(ex2TB[i, 0]);
                    this.DB_Payment.Rows.Add(ex2TB[i, 0]);
                    
                }
                
                //DB_Payment.Rows[i + 1].Cells[1].Value = ex2TB[i, 0];
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
            
        }
        private void DB_Payment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
