
namespace CalMicroCredit
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
            this.sumZayma = new System.Windows.Forms.TextBox();
            this.sumZaymlb = new System.Windows.Forms.Label();
            this.txPeriod = new System.Windows.Forms.TextBox();
            this.lbPeriod = new System.Windows.Forms.Label();
            this.btnRachet = new System.Windows.Forms.Button();
            this.txProc = new System.Windows.Forms.TextBox();
            this.laSrockData = new System.Windows.Forms.Label();
            this.lbsumObVyp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sumZayma
            // 
            this.sumZayma.Location = new System.Drawing.Point(63, 108);
            this.sumZayma.Name = "sumZayma";
            this.sumZayma.Size = new System.Drawing.Size(132, 20);
            this.sumZayma.TabIndex = 0;
            // 
            // sumZaymlb
            // 
            this.sumZaymlb.AutoSize = true;
            this.sumZaymlb.Location = new System.Drawing.Point(63, 89);
            this.sumZaymlb.Name = "sumZaymlb";
            this.sumZaymlb.Size = new System.Drawing.Size(123, 13);
            this.sumZaymlb.TabIndex = 1;
            this.sumZaymlb.Text = "Сумма Займа в рублях";
            // 
            // txPeriod
            // 
            this.txPeriod.Location = new System.Drawing.Point(63, 162);
            this.txPeriod.Name = "txPeriod";
            this.txPeriod.Size = new System.Drawing.Size(132, 20);
            this.txPeriod.TabIndex = 2;
            // 
            // lbPeriod
            // 
            this.lbPeriod.AutoSize = true;
            this.lbPeriod.Location = new System.Drawing.Point(63, 143);
            this.lbPeriod.Name = "lbPeriod";
            this.lbPeriod.Size = new System.Drawing.Size(103, 13);
            this.lbPeriod.TabIndex = 3;
            this.lbPeriod.Text = "Срок Займа в днях";
            // 
            // btnRachet
            // 
            this.btnRachet.Location = new System.Drawing.Point(241, 307);
            this.btnRachet.Name = "btnRachet";
            this.btnRachet.Size = new System.Drawing.Size(160, 57);
            this.btnRachet.TabIndex = 7;
            this.btnRachet.Text = "Расчитать";
            this.btnRachet.UseVisualStyleBackColor = true;
            this.btnRachet.Click += new System.EventHandler(this.btnRachet_Click);
            // 
            // txProc
            // 
            this.txProc.Location = new System.Drawing.Point(63, 226);
            this.txProc.Multiline = true;
            this.txProc.Name = "txProc";
            this.txProc.Size = new System.Drawing.Size(132, 138);
            this.txProc.TabIndex = 8;
            // 
            // laSrockData
            // 
            this.laSrockData.AutoSize = true;
            this.laSrockData.Location = new System.Drawing.Point(63, 206);
            this.laSrockData.Name = "laSrockData";
            this.laSrockData.Size = new System.Drawing.Size(135, 13);
            this.laSrockData.TabIndex = 9;
            this.laSrockData.Text = "Процент на каждый день";
            // 
            // lbsumObVyp
            // 
            this.lbsumObVyp.AutoSize = true;
            this.lbsumObVyp.Location = new System.Drawing.Point(462, 89);
            this.lbsumObVyp.Name = "lbsumObVyp";
            this.lbsumObVyp.Size = new System.Drawing.Size(128, 13);
            this.lbsumObVyp.TabIndex = 11;
            this.lbsumObVyp.Text = "Общая Сумма Выплаты";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(462, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbsumObVyp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.laSrockData);
            this.Controls.Add(this.txProc);
            this.Controls.Add(this.btnRachet);
            this.Controls.Add(this.lbPeriod);
            this.Controls.Add(this.txPeriod);
            this.Controls.Add(this.sumZaymlb);
            this.Controls.Add(this.sumZayma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sumZayma;
        private System.Windows.Forms.Label sumZaymlb;
        private System.Windows.Forms.TextBox txPeriod;
        private System.Windows.Forms.Label lbPeriod;
        private System.Windows.Forms.Button btnRachet;
        private System.Windows.Forms.TextBox txProc;
        private System.Windows.Forms.Label laSrockData;
        private System.Windows.Forms.Label lbsumObVyp;
        private System.Windows.Forms.TextBox textBox1;
    }
}

