using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem3
{
  public partial class Dichotomy : Form
  {
    MainMenu MainForm;

    public Dichotomy(MainMenu Form)
    {
      InitializeComponent();
      MainForm = Form;
    }
    private void button1_Click(object sender, EventArgs e)
    {
      this.Close();
      MainForm.Show();
    }

    double Fun(double x)
    {
      try
      {
        org.matheval.Expression expression = new org.matheval.Expression(textBoxY.Text.ToLower());
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
    private void button2_Click(object sender, EventArgs e)
    {
      textBoxY.Text = "(27 - 18 * x + 2 * x ^ 2) * e ^ -(x / 3)";
    }

    public double Dychotomy(double a, double b, double e, double x = default)
    {
      if (Fun(a) * Fun(b) >= 0)
      {
        MessageBox.Show("В указанном диапозоне либо нет корней, либо их несколько.");
      }

      while ((b - a) > e)
      {
        x = (b - a) / 2 + a;

        if (Fun(a) * Fun(x) < 0)
        {
          b = x;
        }
        else
        {
          a = x;
        }

        if (Fun(a) == 0)
        {
          return x;
        }
        if (Fun(b) == 0)
        {
          return x;
        }
      }

      return x;
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
      textBoxA.Clear();
      textBoxB.Clear();
      textBoxE.Clear();
      textBoxY.Clear();
      ResultX.Clear();
      //ResultY.Clear();
    }

    private void calculateButton_Click(object sender, EventArgs e)
    {
      double startChart = double.Parse(textBoxA.Text);
      double finishChart = double.Parse(textBoxB.Text);
      double step = 1, x, y;
      this.chart1.Series[0].Points.Clear();
      x = startChart;
      while (x <= finishChart)
      {
        y = Fun(x);
        this.chart1.Series[0].Points.AddXY(x, y);
        x += step;
      }

      try
      {
        if ((textBoxA.Text == String.Empty) | (textBoxB.Text == String.Empty) | (textBoxE.Text == String.Empty))
        {
          MessageBox.Show("Заполните все поля ввода!");
        }
        else
        {
          double A = double.Parse(textBoxA.Text);
          double B = double.Parse(textBoxB.Text);
          double E = double.Parse(textBoxE.Text);
          ResultX.Text = Convert.ToString(Dychotomy(A, B, E));
          //ResultY.Text = Convert.ToString(Fun(Dychotomy(A, B, E)));
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

    
  }
}