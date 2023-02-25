using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxelLagos
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            decimal cantidad_1 = Cantidad1textBox.Text == string.Empty ? 0 : Convert.ToDecimal(Cantidad1textBox.Text);
            decimal cantidad_2 = Cantidad2textBox.Text == string.Empty ? 0 : Convert.ToDecimal(Cantidad2textBox.Text);
            decimal cantidad_3 = Cantidad3textBox.Text == string.Empty ? 0 : Convert.ToDecimal(Cantidad3textBox.Text);
            decimal cantidad_4 = Cantidad4textBox.Text == string.Empty ? 0 : Convert.ToDecimal(Cantidad4textBox.Text);

            decimal precio_1 = Precio1textBox.Text == string.Empty ? 0 : Convert.ToDecimal(Precio1textBox.Text);
            decimal precio_2 = Precio2textBox.Text == string.Empty ? 0 : Convert.ToDecimal(Precio2textBox.Text);
            decimal precio_3 = Precio3textBox.Text == string.Empty ? 0 : Convert.ToDecimal(Precio3textBox.Text);
            decimal precio_4 = Precio4textBox.Text == string.Empty ? 0 : Convert.ToDecimal(Precio4textBox.Text);

            decimal Total1 = 0;
            decimal Total2 = 0;
            decimal Total3 = 0;
            decimal Total4 = 0;
            decimal Total = 0;

            Total1 = cantidad_1 * precio_1;
            Total2 = cantidad_2 * precio_2;
            Total3 = cantidad_3 * precio_3;
            Total4 = cantidad_4 * precio_4;

            Total = Total1 + Total2 + Total3 + Total4;

            decimal PagoFinal = await promedioAsync(Total1, Total2, Total3, Total4, Total);
            MessageBox.Show("El total a pagar es : " + PagoFinal);
            LimpiarBotones();
            Descripcion1textBox.Focus();

        }

        private async Task<decimal> promedioAsync(decimal t1, decimal t2, decimal t3, decimal t4, decimal TT)
        {
            decimal TotalantesdelISV = 0;
            decimal Pagofinal = await Task.Run(() =>
            {
                TotalantesdelISV = t1 + t2 + t3 + t4;
                return TT - (TotalantesdelISV * 0.15m);
            });
            return Pagofinal;
        }

        private void LimpiarBotones()
        {
            Cantidad1textBox.Clear();
            Cantidad2textBox.Clear();
            Cantidad3textBox.Clear();
            Cantidad4textBox.Clear();

            Precio1textBox.Clear();
            Precio2textBox.Clear();
            Precio3textBox.Clear();
            Precio4textBox.Clear();

            Descripcion1textBox.Clear();
            Descripcion2textBox.Clear();
            Descripcion4textBox.Clear();
            Descripcion3textBox.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
