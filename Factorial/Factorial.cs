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
            List<int> numbers = new List<int>();
            string input = txtNumbers.Text;
            foreach (string number in input.Split(","))
            {
               numbers.Add(int.Parse(number));
            }
            Task<long>[] tasks = new Task<long>[numbers.Count];
            
            for(int i = 0; i < numbers.Count; i++)
            {
                int num = numbers[i];
                tasks[i] = Task.Run(() => CalculateFactorial(num));
            }
            long[] result = await Task.WhenAll(tasks);

            for(int i=0; i < result.Length; i++)
            {
                MessageBox.Show($"El Factorial de {numbers[i]} es {result[i]}");
            }
        }

        private long CalculateFactorial(int number)
        {
            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
