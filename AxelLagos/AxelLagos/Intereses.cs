using System;
using System.Globalization;
using System.Windows.Forms;

namespace AxelLagos
{
    public partial class Intereses : Form
    {
        public Intereses()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal Capital = 200000;
            decimal interes = 0.015m;
            decimal Tirmpo = 1;
            decimal MostrarTotal = 0;

            int Contador = 0;

            for (int i = 1; i < 13; i++)
            {
                DateTimeFormatInfo dtfi = DateTimeFormatInfo.CurrentInfo;

                MostrarTotal = (Capital * interes) * Tirmpo;
                listBox1.Items.Add("Interesese Generados al mes " + dtfi.MonthNames[Contador++] + "            :" + MostrarTotal + "                      " + (MostrarTotal + Capital));

                Tirmpo++;

            }


        }
    }
}
