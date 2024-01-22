using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sem3
{
    public partial class Newton : Form
    {
        MainMenu MainForm;
        public Newton(MainMenu Form)
        {
            InitializeComponent();
            MainForm = Form;
        }
        public Newton()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.Show();
        }
        double Fun(double x)
        {
            try
            {          
            org.matheval.Expression expression = new org.matheval.Expression(InputFunc.Text.ToLower());
            expression.Bind("x", x);
            decimal value = expression.Eval<decimal>();
            return (double)value;
            }
            catch
            {
                MessageBox.Show("Ошибка ввода функции!");
                return 0;
            }
        }

        double DerivativeFun(double x)
        {
            double h = 0.01;
            return (Fun(x + h) - Fun(x - h)) / (2 * h);
        }


        private double NewtonMethod(double a, double b, double accuracy)
        {
            try
            {
                Intersection.Text = String.Empty;
                if (Fun(a) * Fun(b) > 0)
                {
                    MessageBox.Show("На отрезке нет точек пересечения с осью X, либо таких точек несколько");
                }
                double x0;

                x0 = (a + b) / 2;

                double x1 = x0;
                int c = 0;
                do
                {
                    x0 = x1;
                    x1 = x0 - (Fun(x0) / DerivativeFun(x0));
                    if (x1 < a)
                    {
                        x1 = b;
                    }
                    else if (x1 > b) {
                        x1 = a;
                    } 
                    ++c;
                } while (Math.Abs(Fun(x0) / DerivativeFun(x0)) >= accuracy);
                //Counter.Text = Convert.ToString(c);
                if (c == 2)
                {
                    throw new Exception("Введите другую функцию!");
                }
                return x1;
            } catch(Exception ex)
            {                       
                MessageBox.Show(ex.Message);
                return Convert.ToDouble(String.Empty);
            }
           
        }
        public void GoldenSectionSearchMin(double a, double b, double accuracy)
        {
            double phi = (1 + Math.Sqrt(5)) / 2;
            double h = b - a;
            double c = b - h / phi;
            double d = a + h / phi;
            double fc = Fun(c);
            double fd = Fun(d);
            int tochnost = Convert.ToInt32(Math.Abs(Math.Log10(accuracy)));

            while (Math.Abs(fc - fd) > accuracy)
            {
                if (fc < fd)
                {
                    b = d;
                    d = c;
                    c = b - (b - a) / phi;
                    fd = fc;
                    fc = Fun(c);
                }
                else
                {
                    a = c;
                    c = d;
                    d = a + (b - a) / phi;
                    fc = fd;
                    fd = Fun(d);
                }
            }

            double result = (a + b) / 2;
            GoldenMin.Text = Convert.ToString(Math.Round(result, tochnost));
            if ((Fun(result + 1) > Fun(result)) & ((Fun(result - 1) > Fun(result))))
            {
                ExMin.Text = String.Empty;            
            }
            else
            {
                ExMin.Text = "Не экстремум";
            }
        }
        public void GoldenSectionSearchMax(double a, double b, double accuracy)
        {
            double phi = (1 + Math.Sqrt(5)) / 2;
            double h = b - a;
            double c = b - h / phi;
            double d = a + h / phi;
            double fc = -Fun(c);
            double fd = -Fun(d);
            int tochnost = Convert.ToInt32(Math.Abs(Math.Log10(accuracy)));
            while (Math.Abs(fc - fd) > accuracy)
            {
                if (fc < fd)
                {
                    b = d;
                    d = c;
                    c = b - (b - a) / phi;
                    fd = fc;
                    fc = -Fun(c);
                }
                else
                {
                    a = c;
                    c = d;
                    d = a + (b - a) / phi;
                    fc = fd;
                    fd = -Fun(d);
                }
            }

            double result = (a + b) / 2;
            GoldenMax.Text = Convert.ToString(Math.Round(result, tochnost));
            if ((Fun(result + 2) < Fun(result)) & ((Fun(result - 2) < Fun(result))))
            {
                ExMax.Text = String.Empty;              
            }
            else
            {
                ExMax.Text = "Не экстремум";
            }
        }
        

        
        private void clearButton_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxE.Clear();
            //ResultY.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputFunc.Text = "(27 - 18 * x + 2 * x ^ 2) * e ^ -(x / 3)";
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBoxA.Text == String.Empty) || (textBoxB.Text == String.Empty) || (textBoxE.Text == String.Empty))
                {
                    MessageBox.Show("Заполните все поля ввода!");
                }
                else
                {
                    double A = double.Parse(textBoxA.Text);
                    double B = double.Parse(textBoxB.Text);
                    if (A >= B) 
                    {
                        throw new Exception("B должно быть больше А!");
                    }
                    double E = double.Parse(textBoxE.Text);
                    int tochnost = Convert.ToInt32(Math.Abs(Math.Log10(E)));
                    double step = 0.1, x, y;
                    this.chart1.Series[0].Points.Clear();
                    x = A;
                    while (x <= B)
                    {
                        y = Fun(x);
                        this.chart1.Series[0].Points.AddXY(x, y);
                        x += step;
                    }                  
                    double NX = NewtonMethod(A, B, E);
                    double NY = Fun(NX);
                    NewtonX.Text = Convert.ToString(Math.Round(NX, tochnost));
                    GoldenSectionSearchMin(A, B, E);
                    GoldenSectionSearchMax(A, B, E);
                    //NewtonY.Text = Convert.ToString(NY);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxA.Text = Convert.ToString(-Math.PI);
            textBoxB.Text = Convert.ToString(Math.PI);
        }

        
    }
}
