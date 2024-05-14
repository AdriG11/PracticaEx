using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaExamen
{
    public partial class NumerosPrimos : Form
    {
        public NumerosPrimos()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int inicio = Convert.ToInt32(txtInicio.Text);
            int fin = Convert.ToInt32(txtFin.Text);

            Thread t = new Thread(() => CalcularPrimos(inicio, fin));
            t.Start();
        }

        private void CalcularPrimos(int inicio, int fin)
        {
            List<int> primos = new List<int>();
            for (int i = inicio; i <= fin; i++)
            {
                if (EsPrimo(i))
                {
                    primos.Add(i);
                }
            }
            MostrarResultado(string.Join(",", primos));
        }
        private bool EsPrimo(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void MostrarResultado(string resultado)
        {
            if (txtPrimos.InvokeRequired)
            {
                txtPrimos.Invoke(new MethodInvoker(delegate
                {
                    MostrarResultado(resultado);
                }));
            }
            else
            {
                txtPrimos.Text = resultado;
            }
        }
    }
}
