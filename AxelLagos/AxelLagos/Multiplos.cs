using System;
using System.Windows.Forms;

namespace AxelLagos
{
    public partial class Multiplos : Form
    {
        public Multiplos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 1; i < 101; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    listBox1.Items.Add("Axel Lagos ");
                }
                else if (i % 5 == 0)
                {
                    listBox1.Items.Add("Lagos ");
                }
                else if (i % 3 == 0)
                {
                    listBox1.Items.Add("Axel ");
                }
                else
                {
                    listBox1.Items.Add(i);
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
