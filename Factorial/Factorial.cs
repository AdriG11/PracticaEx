using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] numbers = { 5, 6, 7, 8, 10, };
            foreach (int number in numbers)
            {
                Task<long> task = Task.Run(() => CalculateFactorial (number));
                long result = await task;

                MessageBox.Show($"Factorial de {number} : {result}");
            }
        }

        private long CalculateFactorial(int number)
        {
            long factorial = 1;
            for(int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
