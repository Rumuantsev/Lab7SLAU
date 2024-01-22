using System;
using System.Windows.Forms;

namespace Sem3
{
  public partial class Integral : Form
  {
    MainMenu MainForm;

    public Integral(MainMenu Form)
    {
      InitializeComponent();
      MainForm = Form;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.Close();
      MainForm.Show();
    }

    double Fun(double x)
    {
      org.matheval.Expression expression = new org.matheval.Expression(InputFun.Text.ToLower());
      expression.Bind("x", x);
      decimal value = expression.Eval<decimal>();
      return (double)value;
    }

    void PrintFun(double a, double b)
    {
      double step = 0.1, x, y;
      if ((b - a) < 5)
      {
        step = 0.001;
      }
      this.chart1.Series[1].Points.Clear();
      x = a;
      while (x <= b)
      {
        y = Fun(x);
        this.chart1.Series[1].Points.AddXY(x, y);
        x += step;
      }
    }

    void PrintInterval(double a, double b)
    {
      double step = 1, x, y;
      if ((b - a) < 2)
      {
        step = 0.001;
      }
      this.chart1.Series[4].Points.Clear();
      x = a;
      y = 0;
      while (x <= b)
      {
        this.chart1.Series[4].Points.AddXY(x, y);
        x += step;
      }
      this.chart1.Series[2].Points.Clear();
      x = a;
      y = -10;
      while (y <= 10)
      {
        this.chart1.Series[2].Points.AddXY(x, y);
        y++;
      }
      this.chart1.Series[3].Points.Clear();
      x = b;
      y = -10;
      while (y <= 10)
      {
        this.chart1.Series[3].Points.AddXY(x, y);
        y++;
      }
    }

    double RectangleE(double a, double b, double e)
    {
      this.chart1.Series[0].Points.Clear();
      double Interval = b - a;
      int CountPartition = 1;
      double h = Interval / CountPartition;
      double CurrentResult = 0;
      double LastResult = 0;

      while (true)
      {
        this.chart1.Series[0].Points.Clear();
        double x;
        CurrentResult = Math.Abs(Fun(a)) * h;
        int index = 1;
        while (index < CountPartition)
        {
          x = a + index * h;
          CurrentResult += (h * Math.Abs(Fun(x)));
          this.chart1.Series[0].Points.AddXY(x, Fun(x));
          ++index;
        }
        this.chart1.Series[0].Points.AddXY(a, Fun(a));
        this.chart1.Series[0].Points.AddXY(b, Fun(b));
        if (Math.Abs(CurrentResult - LastResult) < e)
        {
          RectangleTime.Text = Convert.ToString(CountPartition);
          return CurrentResult;
        }
        LastResult = CurrentResult;
        CountPartition *= 2;
        h = Interval / CountPartition;
      }
    }

    double TrapezeE(double a, double b, double e)
    {
      chart1.Series[0]["PointWidth"] = "0.99";
      chart1.ChartAreas[0].AxisX.Minimum = a;
      chart1.ChartAreas[0].AxisX.Maximum = b;
      this.chart1.Series[0].Points.Clear();
      double Interval = b - a;
      int CountPartition = 1;
      double h = Interval / CountPartition;
      double CurrentResult = 0;
      double LastResult = 0;

      while (true)
      {
        this.chart1.Series[0].Points.Clear();
        double x;
        CurrentResult = Math.Abs(Fun(a)) + Math.Abs(Fun(b));
        int index = 1;
        while (index < CountPartition)
        {
          x = a + index * h;
          CurrentResult += (2 * Math.Abs(Fun(x)));
          this.chart1.Series[0].Points.AddXY(x, Fun(x));
          ++index;
        }
        this.chart1.Series[0].Points.AddXY(a, Fun(a));
        this.chart1.Series[0].Points.AddXY(b, Fun(b));
        CurrentResult *= (h / 2);
        if (Math.Abs(CurrentResult - LastResult) < e)
        {
          TrapezeTime.Text = Convert.ToString(CountPartition - 1);
          return CurrentResult;
        }
        LastResult = CurrentResult;
        CountPartition *= 2;
        h = Interval / CountPartition;
      }
    }

    double ParabolaE(double a, double b, double e)
    {
      this.chart1.Series[0].Points.Clear();
      int CountPartition = 1;
      double CurrentResult;
      double LastResult = 0;

      while (true)
      {
        this.chart1.Series[0].Points.Clear();
        CurrentResult = (2 * TrapezeN(a, b, CountPartition) + RectangleN(a, b, CountPartition)) / 3;
        this.chart1.Series[0].Points.AddXY(a, Fun(a));
        this.chart1.Series[0].Points.AddXY(b, Fun(b));
        if (Math.Abs(CurrentResult - LastResult) < e)
        {
          RectangleTime.Text = String.Empty;
          TrapezeTime.Text = String.Empty;
          ParabolaTime.Text = Convert.ToString(CountPartition);
          return CurrentResult;
        }
        LastResult = CurrentResult;
        CountPartition *= 2;
      }
    }

    double RectangleN(double a, double b, int n)
    {
      chart1.Series[0]["PointWidth"] = "0.99";
      chart1.ChartAreas[0].AxisX.Minimum = a;
      chart1.ChartAreas[0].AxisX.Maximum = b;
      this.chart1.Series[0].Points.Clear();
      double Interval = b - a;
      double h = Interval / n;
      double Result = 0;
      this.chart1.Series[0].Points.Clear();
      double x;
      int index = 0;
      while (index < n)
      {
        x = a + index * h;
        Result += (h * Math.Abs(Fun(x)));
        this.chart1.Series[0].Points.AddXY(x, Fun(x));
        ++index;
      }
      this.chart1.Series[0].Points.AddXY(a, Fun(a));
      this.chart1.Series[0].Points.AddXY(b, Fun(b));
      RectangleTime.Text = Convert.ToString(n);
      return Result;
    }

    double TrapezeN(double a, double b, int n)
    {
      chart1.Series[0]["PointWidth"] = "0.99";
      chart1.ChartAreas[0].AxisX.Minimum = a;
      chart1.ChartAreas[0].AxisX.Maximum = b;
      this.chart1.Series[0].Points.Clear();
      double Interval = b - a;
      double h = Interval / n;


      double Result = 0;
      this.chart1.Series[0].Points.Clear();
      double x;
      Result = Math.Abs(Fun(a)) + Math.Abs(Fun(b));
      int index = 1;
      while (index < n)
      {
        x = a + index * h;
        Result += (2 * Math.Abs(Fun(x)));
        this.chart1.Series[0].Points.AddXY(x, Fun(x));
        ++index;
      }
      this.chart1.Series[0].Points.AddXY(a, Fun(a));
      this.chart1.Series[0].Points.AddXY(b, Fun(b));
      Result *= (h / 2);
      TrapezeTime.Text = Convert.ToString(n);
      return Result;
    }

    double ParabolaN(double a, double b, int n)
    {
      chart1.Series[0]["PointWidth"] = "0.99";
      chart1.ChartAreas[0].AxisX.Minimum = a;
      chart1.ChartAreas[0].AxisX.Maximum = b;
      this.chart1.Series[0].Points.Clear();
      double Interval = b - a;
      double h = Interval / n;
      double Result;
      this.chart1.Series[0].Points.Clear();
      Result = (2 * TrapezeN(a, b, n) + RectangleN(a, b, n)) / 3;
      this.chart1.Series[0].Points.AddXY(a, Fun(a));
      this.chart1.Series[0].Points.AddXY(b, Fun(b));
      RectangleTime.Text = String.Empty;
      TrapezeTime.Text = String.Empty;
      ParabolaTime.Text = Convert.ToString(n);
      return Result;
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      RectangleResult.Text = String.Empty;
      TrapezeResult.Text = String.Empty;
      ParabolaResult.Text = String.Empty;
      RectangleTime.Text = String.Empty;
      TrapezeTime.Text = String.Empty;
      ParabolaTime.Text = String.Empty;

      bool Continue = true;

      if ((RectangleCheck.Checked == false) &&
          (TrapezeCheck.Checked == false) &&
          (ParabolaCheck.Checked == false))
      {
        MessageBox.Show("Выберите метод!");
        Continue = false;
      }

      if ((CheckE.Checked == false) &&
          (CheckN.Checked == false))
      {
        MessageBox.Show("Выберите способ нахождения результата!");
        Continue = false;
      }

      if ((InputFun.Text == String.Empty) ||
          (InputA.Text == String.Empty) ||
          (InputB.Text == String.Empty))
      {
        MessageBox.Show("Введите функцию и интервал!");
        Continue = false;
      }

      while (Continue == true)
      {
        double A = Convert.ToDouble(InputA.Text);
        double B = Convert.ToDouble(InputB.Text);

        if (CheckE.Checked == true)
        {
          if (InputE.Text == String.Empty)
          {
            MessageBox.Show("Введите точность!");
            break;
          }

          double E = Convert.ToDouble(InputE.Text);
          int Accuracy = Convert.ToInt32(Math.Abs(Math.Log10(E)));

          if (ParabolaCheck.Checked)
          {
            ParabolaResult.Text = Convert.ToString(Math.Round(ParabolaE(A, B, E), Accuracy));
          }

          if (RectangleCheck.Checked)
          {
            RectangleResult.Text = Convert.ToString(Math.Round(RectangleE(A, B, E), Accuracy));
          }

          if (TrapezeCheck.Checked)
          {
            TrapezeResult.Text = Convert.ToString(Math.Round(TrapezeE(A, B, E), Accuracy));
          }

          PrintFun(A, B);
          PrintInterval(A, B);
          break;
        }

        if (CheckN.Checked == true)
        {
          if (InputN.Text == String.Empty)
          {
            MessageBox.Show("Введите кол-во разбиений!");
            break;
          }

          int N = Convert.ToInt32(InputN.Text);

          if (ParabolaCheck.Checked == true)
          {
            ParabolaResult.Text = Convert.ToString(ParabolaN(A, B, N));
          }

          if (RectangleCheck.Checked == true)
          {
            RectangleResult.Text = Convert.ToString(RectangleN(A, B, N));
          }

          if (TrapezeCheck.Checked == true)
          {
            TrapezeResult.Text = Convert.ToString(TrapezeN(A, B, N));
          }

          PrintFun(A, B);
          PrintInterval(A, B);
          break;
        }
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      int N = 1;
      double E = Convert.ToDouble(InputE.Text);
      int Accuracy = Convert.ToInt32(Math.Abs(Math.Log10(E)));
      double A = Convert.ToDouble(InputA.Text);
      double B = Convert.ToDouble(InputB.Text);

      while (true)
      {
        if ((Math.Round(RectangleN(A, B, N), Accuracy) == Math.Round(TrapezeN(A, B, N), Accuracy)) &&
            (Math.Round(RectangleN(A, B, N), Accuracy) == Math.Round(ParabolaN(A, B, N), Accuracy)))
        {
          PrintFun(A, B);
          PrintInterval(A, B);

          while ((Math.Round(RectangleN(A, B, N), Accuracy) == Math.Round(TrapezeN(A, B, N), Accuracy)) &&
              (Math.Round(RectangleN(A, B, N), Accuracy) == Math.Round(ParabolaN(A, B, N), Accuracy)))
          {
            N -= 1;
          }

          N += 1;

          RectangleResult.Text = Convert.ToString(Math.Round(RectangleN(A, B, N), Accuracy));
          TrapezeResult.Text = Convert.ToString(Math.Round(TrapezeN(A, B, N), Accuracy));
          ParabolaResult.Text = Convert.ToString(Math.Round(ParabolaN(A, B, N), Accuracy));
          RectangleTime.Text = Convert.ToString(N);
          TrapezeTime.Text = Convert.ToString(N);
          ParabolaTime.Text = Convert.ToString(N);
          break;
        }

        if (N > 10000)
        {
          MessageBox.Show("Слишком долго!");
          break;
        }

        N *= 2;
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void chart1_Click(object sender, EventArgs e)
    {

    }

    private void TrapezeCheck_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void RectangleCheck_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void ParabolaCheck_CheckedChanged(object sender, EventArgs e)
    {

    }
  }
}