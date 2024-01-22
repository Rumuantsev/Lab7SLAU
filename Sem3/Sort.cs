using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;

namespace Sem3
{
  public partial class Sort : Form
  {
    MainMenu MainForm;
    public Sort(MainMenu Form)
    {
      InitializeComponent();
      MainForm = Form;
    }
    private void button3_Click_1(object sender, EventArgs e)
    {
      this.Close();
      MainForm.Show();
    }
    private string fileName = string.Empty;
    private DataTableCollection tableCollection = null;
    double[] Array = null;

    private void button3_Click(object sender, EventArgs e)
    {
      start.Text = null;
      double[] DefultArray = { 8, 2, 1, 6, 3, 9, 7, 6, 8, 3, 1, 5 };
      Array = DefultArray;
      PrintStartArray(Array);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      bool Continue = true;
      if ((SizeGenerateArray.Text == String.Empty) &&
          (startNumber.Text == String.Empty) &&
          (finishNumber.Text == String.Empty))
      {
        MessageBox.Show("Укажите размер массива!");
        Continue = false;
      }

      if (Continue == true)
      {
        start.Text = null;
        double[] RandomArray = new double[Convert.ToInt32(SizeGenerateArray.Text)];
        var random = new Random();

        for (int ArrayIndex = 0; ArrayIndex < RandomArray.Length; ArrayIndex++)
        {
          RandomArray[ArrayIndex] = random.Next(Convert.ToInt32(startNumber.Text), Convert.ToInt32(finishNumber.Text));
        }

        Array = RandomArray;
        PrintStartArray(Array);
      }
    }

    public void button2_Click_1(object sender, EventArgs e)
    {
      try
      {
        if (dataGridView1.ColumnCount > 0)
        {
          dataGridView1.Columns.Clear();
        }

        DialogResult res = openFileDialog1.ShowDialog();

        if (res == DialogResult.OK)
        {
          fileName = openFileDialog1.FileName;
          Text = fileName;
          OpenExcelFile(fileName);
        }
        else
        {
          throw new Exception("Файл не выбран!");
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      GetArray();
      PrintArray(Array);
    }

    private void GetArray() // получение чисел из gridViev в NumberArray
    {
      try
      {
        Array = new double[dataGridView1.Rows.Count];

        for (int index = 0; index < dataGridView1.RowCount - 1; ++index)
        {
          Array[index] = Convert.ToInt32(dataGridView1[0, index + 1].Value);
        }
      }
      catch
      {
        MessageBox.Show("Не удалось преобразовать данные из Excel", "Ошибка конвертации!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void OpenExcelFile(string path)
    {
      FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);
      IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);
      DataSet db = reader.AsDataSet(new ExcelDataSetConfiguration()
      {
        ConfigureDataTable = (x) => new ExcelDataTableConfiguration()
        {
          UseHeaderRow = true
        }
      });

      tableCollection = db.Tables;

      comboBox1.Items.Clear();

      foreach (DataTable tebe in tableCollection)
      {
        comboBox1.Items.Add(tebe.TableName);
      }

      comboBox1.SelectedIndex = 0;
    }

    void PrintStartArray(double[] Array)
    {
      foreach (int index in Array)
      {
        start.Text += (index + " ");
      }
    }

    void PrintChart(double[] Array)
    {
      foreach (double val in Array)
      {
        chart1.Series["Series1"].Points.Add(val);
      }
    }

    void PrintDisChart(double[] Array)
    {
      for (int index = Array.Length - 1; index >= 0; index--)
      {
        chart1.Series["Series1"].Points.Add(Array[index]);
      }
    }

    void PrintArray(double[] Array)
    {
      foreach (int index in Array)
      {
        result.Text += (index + " ");
      }
    }

    void PrintDisArray(double[] Array)
    {
      for (int index = Array.Length - 1; index >= 0; index--)
      {
        result.Text += (Array[index] + " ");
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      bool Continue = true;

      if ((BubbleCheck.Checked == false) &&
          (InsertCheck.Checked == false) &&
          (ShakerCheck.Checked == false) &&
          (FastCheck.Checked == false) &&
          (BogoCheck.Checked == false))
      {
        MessageBox.Show("Выберите метод сортировки!");
        Continue = false;
      }

      if ((UpCheck.Checked == false) &&
         (DownCheck.Checked == false))
      {
        MessageBox.Show("Выберите вид сортировки!");
        Continue = false;
      }

      if (Array == null)
      {
        MessageBox.Show("Выберите массив!");
        Continue = false;
      }

      if (Continue == true)
      {
        time1.Text = null; time2.Text = null; time3.Text = null; 
        time4.Text = null; time5.Text = null; result.Text = null;
        chart1.Series["Series1"].Points.Clear();
        var sw = new Stopwatch();

        if (BubbleCheck.Checked)
        {
          sw.Start();

          double[] ThisArray = SortMethods.BubbleSort(Array);

          if (UpCheck.Checked == true)
          {
            result.Text = null;
            chart1.Series["Series1"].Points.Clear();
            PrintArray(ThisArray);
            PrintChart(ThisArray);
          }
          else
          {
            result.Text = null;
            chart1.Series["Series1"].Points.Clear();
            PrintDisArray(ThisArray);
            PrintDisChart(ThisArray);
          }

          sw.Stop();
          double time = sw.ElapsedTicks / 10;
          time1.Text = Convert.ToString(time);
        }

        if (InsertCheck.Checked)
        {
          sw.Restart();
          sw.Start();
          double[] ThisArray = SortMethods.InsertSort(Array);

          if (UpCheck.Checked == true)
          {
            result.Text = null;
            chart1.Series["Series1"].Points.Clear();
            PrintArray(ThisArray);
            PrintChart(ThisArray);
          }
          else
          {
            result.Text = null;
            chart1.Series["Series1"].Points.Clear();
            PrintDisArray(ThisArray);
            PrintDisChart(ThisArray);
          }

          sw.Stop();
          double time = sw.ElapsedTicks / 10;
          time2.Text = Convert.ToString(time);
        }

        if (ShakerCheck.Checked)
        {
          sw.Restart();
          sw.Start();
          double[] ThisArray = SortMethods.ShakerSort(Array);

          if (UpCheck.Checked == true)
          {
            result.Text = null;
            chart1.Series["Series1"].Points.Clear();
            PrintArray(ThisArray);
            PrintChart(ThisArray);
          }
          else
          {
            result.Text = null;
            chart1.Series["Series1"].Points.Clear();
            PrintDisArray(ThisArray);
            PrintDisChart(ThisArray);
          }

          double time = sw.ElapsedTicks / 10;
          time3.Text = Convert.ToString(time);
        }

        if (FastCheck.Checked)
        {
          sw.Restart();
          sw.Start();
          double[] ThisArray = SortMethods.FastSort(Array, 0, Array.Length - 1);

          if (UpCheck.Checked == true)
          {
            result.Text = null;
            chart1.Series["Series1"].Points.Clear();
            PrintArray(ThisArray);
            PrintChart(ThisArray);
          }
          else
          {
            result.Text = null;
            chart1.Series["Series1"].Points.Clear();
            PrintDisArray(ThisArray);
            PrintDisChart(ThisArray);
          }

          double time = sw.ElapsedTicks / 10;
          time4.Text = Convert.ToString(time);
        }

        if (BogoCheck.Checked)
        {
          sw.Restart();
          sw.Start();
          double[] ThisArray = SortMethods.BogoSort(Array);

          if (UpCheck.Checked == true)
          {
            result.Text = null;
            chart1.Series["Series1"].Points.Clear();
            PrintArray(ThisArray);
            PrintChart(ThisArray);
          }
          else
          {
            result.Text = null;
            chart1.Series["Series1"].Points.Clear();
            PrintDisArray(ThisArray);
            PrintDisChart(ThisArray);
          }

          double time = sw.ElapsedTicks / 10;
          time5.Text = Convert.ToString(time);
        }
      }
    }

    private void BubbleCheck_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
    {

    }

    private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
    {

    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void InsertCheck_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void ShakerCheck_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void FastCheck_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void BubbleCheck_CheckedChanged_1(object sender, EventArgs e)
    {

    }

    private void BogoChack_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void DownCheck_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      DataTable table = tableCollection[Convert.ToString(comboBox1.SelectedItem)];
      dataGridView1.DataSource = table;
    }

    private void label7_Click(object sender, EventArgs e)
    {

    }

    
  }
}
