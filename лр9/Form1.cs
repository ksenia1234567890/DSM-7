using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр9
{
    public partial class Form1 : Form
    {
        public string line_2 = "Возведение в квадрат положительных чисел: ";
        public string line_3 = "Возведение в куб отрицательных чисел: ";
        public Form1()
        {
            InitializeComponent();
        }

        public void Pow()
        {
            int[] array = new int[21];
            int j = -10;
            for(int i=0; i<array.Length;i++, j++)
            {
                array[i] = j;
            }
            int h = 0;
            for(int i=array.Length-11; h<11; i++,h++)
            {
                double num = Convert.ToDouble(Math.Pow(array[i], 2));
                line_2 += Convert.ToString(num) + ", ";

            }
            int k = -10;
            for(int i=0; k<0;i++,k++)
            {
                double num = Convert.ToDouble(Math.Pow(array[i], 3));
                line_3 += Convert.ToString(num) + ", ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pow();
            textBox1.Text = line_2 + ". " + line_3;
        }
    }
}
