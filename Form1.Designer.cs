namespace CalculatorEconomika
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_SumCredit = new System.Windows.Forms.TextBox();
            this.txt_Percent = new System.Windows.Forms.TextBox();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Equals = new System.Windows.Forms.Button();
            this.check_round = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_SumCredit
            // 
            this.txt_SumCredit.Location = new System.Drawing.Point(302, 90);
            this.txt_SumCredit.Name = "txt_SumCredit";
            this.txt_SumCredit.Size = new System.Drawing.Size(78, 20);
            this.txt_SumCredit.TabIndex = 0;
            this.txt_SumCredit.TextChanged += new System.EventHandler(this.txt_SumCredit_TextChanged);
            // 
            // txt_Percent
            // 
            this.txt_Percent.Location = new System.Drawing.Point(302, 131);
            this.txt_Percent.Name = "txt_Percent";
            this.txt_Percent.Size = new System.Drawing.Size(30, 20);
            this.txt_Percent.TabIndex = 1;
            // 
            // txt_Year
            // 
            this.txt_Year.Location = new System.Drawing.Point(302, 173);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(30, 20);
            this.txt_Year.TabIndex = 2;
            this.txt_Year.TextChanged += new System.EventHandler(this.txt_Year_TextChanged);
            this.txt_Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Year_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(83, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сумма кредита";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(83, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Процентная ставка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(83, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Срок в годах";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(83, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Срок в месяцах";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(83, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Выплата в месяц";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(83, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Общая сумма выплат";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(83, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Сумма переплаты";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(152, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Простой кредитный калькулятор";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(298, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "0";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(298, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(298, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(298, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "0";
            // 
            // btn_Equals
            // 
            this.btn_Equals.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Equals.Location = new System.Drawing.Point(188, 448);
            this.btn_Equals.Name = "btn_Equals";
            this.btn_Equals.Size = new System.Drawing.Size(217, 51);
            this.btn_Equals.TabIndex = 3;
            this.btn_Equals.Text = "Рассчитать";
            this.btn_Equals.UseVisualStyleBackColor = true;
            this.btn_Equals.Click += new System.EventHandler(this.button1_Click);
            // 
            // check_round
            // 
            this.check_round.AutoSize = true;
            this.check_round.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_round.Location = new System.Drawing.Point(245, 396);
            this.check_round.Name = "check_round";
            this.check_round.Size = new System.Drawing.Size(101, 22);
            this.check_round.TabIndex = 4;
            this.check_round.Text = "Округлять";
            this.check_round.UseVisualStyleBackColor = true;
            this.check_round.CheckedChanged += new System.EventHandler(this.check_round_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 529);
            this.Controls.Add(this.check_round);
            this.Controls.Add(this.btn_Equals);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Year);
            this.Controls.Add(this.txt_Percent);
            this.Controls.Add(this.txt_SumCredit);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кредит";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SumCredit;
        private System.Windows.Forms.TextBox txt_Percent;
        private System.Windows.Forms.TextBox txt_Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Equals;
        private System.Windows.Forms.CheckBox check_round;
    }
}

