using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalMicroCredit
{
    public partial class Calkulator : Form
    {
        public double obchaySumVyp = 0;
        public double sumProc = 0;
        public double effStavka = 0;
        public Calkulator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRachet_Click(object sender, EventArgs e)
        {

            double zaym = Convert.ToDouble(sumZayma.Text);
            if (zaym > 500000 || zaym < 0)
            {
                MessageBox.Show("Сумма займа введена неверно");
                return;
            }

            double period = Convert.ToDouble(txPeriod.Text);
            if (period > 365 || period < 1)
            {
                MessageBox.Show("Период введ неверно");
                return;
            }

            var data = txProc.Text.Split(' ');

            for(int i = 0; i < period; i++)
            {
                sumProc += Convert.ToDouble(data[i])/100 * zaym;
            }

            tbSumProc.Text = sumProc.ToString();

            obchaySumVyp = zaym + sumProc;
            tbSumVyp.Text = obchaySumVyp.ToString();

            effStavka = sumProc / zaym / period * 100;
            tbEfStav.Text = effStavka.ToString();
        }
    }
}
