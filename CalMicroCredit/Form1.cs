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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRachet_Click(object sender, EventArgs e)
        {

            int zaym = Int32.Parse(sumZayma.Text);
            if (zaym > 500000 || zaym < 0)
            {
                MessageBox.Show("Сумма займа введена неверно");
                return;
            }

            int period = Int32.Parse(txPeriod.Text);
            if (period > 365 || period < 1)
            {
                MessageBox.Show("Период введ неверно");
                return;
            }


            for (int i = 0; i <= Convert.ToInt32(txPeriod.Text); i++)
            {
                dataDays.Items.Add(10);
            }


        }
    }
}
