using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sem3
{
    public partial class Spusk : Form
    {
    MainMenu MainForm;
    public Spusk(MainMenu Form)
    {
      InitializeComponent();
      MainForm = Form;
    }
    private void button6_Click(object sender, EventArgs e)
    {
      this.Close();
      MainForm.Show();
    }
    int IterationCheck = 0;
        double Fun(double x)
        {
            org.matheval.Expression expression = new org.matheval.Expression(InputFunc.Text.ToLower());
            expression.Bind("x", x);
            decimal value = expression.Eval<decimal>();
            return (double)value;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            InputFunc.Text = "(27 - 18 * x + 2 * x ^ 2) * e^-(x / 3)";
        }

        double DisFun(double x)
        {
            return -Fun(x);
        }
        public void PrintChart(double a, double b)
        {
            
            double h = 0.1, x, y;
            this.chart1.Series[0].Points.Clear();
            x = a;
            while (x <= b)
            {
                y = Fun(x);
                this.chart1.Series[0].Points.AddXY(x, y);
                x += h;
            }
        }


        public double CoordinateDescent(double a, double b, int accuracy)
        {
           
            double delta = 1 / Math.Pow(10, accuracy);
            double x     = (a + b) / 2;
            IterationCheck = 0;
            while (!(x - delta <= a || x + delta >= b))
            {      
                if (Fun(x) > Fun(x - delta))
                {
                    x -= delta;
                }
                else if (Fun(x) > Fun(x + delta))
                {
                    x += delta;
                }
                else
                { 
                    break; 
                }
                ++IterationCheck;
                if (IterationCheck > 10000)
                {
                    MessageBox.Show("Превышено допустимое время работы программы!");
                    return 0;
                }
            }
            return Math.Round(x, accuracy);
        }
        public double DisCoordinateDescent(double a, double b, int accuracy)
        {
            //double delta = 1 / Math.Pow(10, accuracy);
            //double x = (a + b) / 2; // Инициализация начального значения x


            //while (b - a > delta) // Условие остановки
            //{
            //    if (DisFun(a) > DisFun(b))
            //        a = x; // Если значение функции в точке a больше, обновляем начальную границу
            //    else
            //        b = x; // Иначе обновляем конечную границу

            //    x = (a + b) / 2; // Вычисление нового значения x
            //}

            //return Math.Round(x, accuracy);
            double x = (a + b) / 2;
            double delta = 1 / Math.Pow(10, accuracy);           
            while (!(x - delta <= a || x + delta >= b))
            {
                if (DisFun(x) > DisFun(x - delta))
                {
                    x -= delta;
                }
                else if (DisFun(x) > DisFun(x + delta))
                {
                    x += delta;
                }
                else
                {
                    break;
                }
                if (IterationCheck > 10000)
                {
                    return 0;
                }
            }
            return Math.Round(x, accuracy);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputFunc.Clear();
        }
        
        private void clearButton_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxE.Clear();          
            Max.Clear();
            Min.Clear();
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {       
                try
                {
                    if ((textBoxA.Text == String.Empty) | (textBoxB.Text == String.Empty) | (textBoxE.Text == String.Empty))
                    {
                        MessageBox.Show("Заполните все поля ввода!");
                    }
                    else
                    {
                        Min.Text = String.Empty;
                        Max.Text = String.Empty;
                        double A = double.Parse(textBoxA.Text);
                        double B = double.Parse(textBoxB.Text);
                        int E = int.Parse(textBoxE.Text);
                        PrintChart(A, B);
                        Min.Text = Convert.ToString(CoordinateDescent(A, B, E));
                        Max.Text = Convert.ToString(DisCoordinateDescent(A, B, E));
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Можно вводить только цифры!");
                }          
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        

        private void InputFunc_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    
  }
}
