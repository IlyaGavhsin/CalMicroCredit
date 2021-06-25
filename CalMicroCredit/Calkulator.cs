using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
            try
            {
                double zaym = Convert.ToDouble(sumZayma.Text);
                double period = Convert.ToDouble(txPeriod.Text);

                if (zaym > 500000 || zaym < 0)
                {
                    MessageBox.Show("Сумма займа введена неверно");
                    throw new ArgumentNullException();
                }

                
                if (period > 365 || period < 1)
                {
                    MessageBox.Show("Период введен неверно");
                    throw new ArgumentNullException();
                }

                var data = txProc.Text.Split(' ');

                for (int i = 0; i < period; i++)
                {
                    sumProc += Convert.ToDouble(data[i]) / 100 * zaym;
                }

                tbSumProc.Text = sumProc.ToString();

                obchaySumVyp = zaym + sumProc;
                tbSumVyp.Text = obchaySumVyp.ToString();

                effStavka = sumProc / zaym / period * 100;
                tbEfStav.Text = effStavka.ToString();

                sumProc = 0;

            }
            catch
            {
                MessageBox.Show("Подставтье корекктные значения");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = "file.txt";

            try
            {
                double zaym = Convert.ToDouble(sumZayma.Text);
                double period = Convert.ToDouble(txPeriod.Text);
                if (zaym > 500000 || zaym < 0)
                {
                    MessageBox.Show("Сумма займа введена неверно");
                    throw new ArgumentNullException();
                }


                if (period > 365 || period < 1)
                {
                    MessageBox.Show("Период введ неверно");
                    throw new ArgumentNullException();
                }
                // write new file
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine($"Общая сумма выплаты: {obchaySumVyp}\n" +
                        $"Сумма процентов {sumProc}\n" +
                        $"Эфеективная ставка {effStavka}");
                }
            }
            catch
            {
                MessageBox.Show("Подставтье корекктные значения");
            }
            

        }
    }
}
;