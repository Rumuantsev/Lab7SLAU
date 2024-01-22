using OfficeOpenXml;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Sem3
{
  public partial class SLAU : Form
  {
    MainMenu MainForm;

    public SLAU(MainMenu Form)
    {
      InitializeComponent();
      MainForm = Form;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
      
    double[,] MatrixA = null;
    double[] FreeItem = null;
    int E;

    private void button1_Click(object sender, EventArgs e)
    {

      E = Convert.ToInt32(textBoxE.Text);
      dataGridView2.Rows.Clear();
      dataGridView2.Columns.Clear();
      GetArrayFromGrid();

      if (GaussCheck.Checked)
      {
        double[] resultGauss = MethodGauss(MatrixA, FreeItem, MatrixA.GetLength(0));
        try
        {
          PrintResult(resultGauss, 0);
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);

          return;
        }
      }
      if (JordanCheck.Checked)
      {
        double[] resultJordan = MethodGaussJordan(MatrixA, FreeItem);

        try
        {
          PrintResult(resultJordan, 1);
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);

          return;
        }
      }
      if (KramerCheck.Checked)
      {
        double[] resultKramer = MethodKramer(MatrixA, FreeItem, MatrixA.GetLength(0));

        try
        {
          PrintResult(resultKramer, 2);
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message);

          return;
        }
      }
    }
    

    private void button4_Click(object sender, EventArgs e)
    {
      dataGridView1.Rows.Clear();
      dataGridView1.Columns.Clear();
    }

    
    private void PrintResult(double[] Result, int row)
    {
      dataGridView2.RowCount = 3;
      dataGridView2.ColumnCount = Result.Length + 1;
      dataGridView2.Columns[0].HeaderCell.Value = "Методы";
      dataGridView2[0, 0].Value = "Метод Гаусса";
      dataGridView2[0, 1].Value = "Метод Жордана-Гаусса";
      dataGridView2[0, 2].Value = "Метод Крамера";
      try
      {
        for (int index = 1; index <= Result.Length; ++index)
        {
          dataGridView2[index, row].Value = Math.Round(Result[index - 1], E);
        }
        for (int i = 1; i <= Result.Length; i++)
        {
          dataGridView2.Columns[i].HeaderCell.Value = $"X{i}";
        }
      }
      catch
      {
        MessageBox.Show("Ошибка при заполнении сетки!", "Ошибка конвертации!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    private void GetArrayFromGrid()
    {
      try
      {
        if ((dataGridView1.RowCount == 0) && (dataGridView1.ColumnCount == 0))
        {
          throw new Exception("Сначала создайте матрицу!");
        }
        bool Correct = true;
        bool NotNull = true;
        MatrixA = new double[dataGridView1.ColumnCount - 1, dataGridView1.RowCount];
        FreeItem = new double[dataGridView1.Rows.Count];        
        for (int column = 0; column < dataGridView1.ColumnCount - 1; ++column)          
        {
          for (int row = 0; row < dataGridView1.RowCount; ++row)
          {
            if (dataGridView1[column, row].Value == null)
            {
              NotNull = false;
            }
            double ItemMatrix;
            org.matheval.Expression expression = new org.matheval.Expression(Convert.ToString(dataGridView1[row, column].Value).ToLower());         
            decimal value = expression.Eval<decimal>();
            Correct = double.TryParse(Convert.ToString(value), out ItemMatrix);
            MatrixA[column, row] = ItemMatrix;
          }
        }

        for (int index = 0; index < dataGridView1.RowCount; ++index)
        {
          if (dataGridView1[dataGridView1.ColumnCount - 1, index].Value == null)
          {
            NotNull = false;
          }
          double ItemB;
          Correct = double.TryParse(Convert.ToString(dataGridView1[dataGridView1.ColumnCount - 1, index].Value), out ItemB);
          FreeItem[index] = ItemB;
        }

        if (!NotNull)
        {
          throw new Exception("В матрице отсутствуют данные!");
        }

        if (!Correct)
        {
          throw new Exception("Некорректный ввод данных!");
        }  
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      dataGridView1.AllowUserToAddRows = false;
      dataGridView1.Rows.Clear();
      dataGridView1.Columns.Clear();
      OpenFileDialog openFileDialog = new OpenFileDialog
      {
        Title = "Выберите файл Excel",
        Filter = "Файлы Excel (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*",
        Multiselect = false
      };

      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        string filePath = openFileDialog.FileName;

        try
        {
          LoadDataFromExcel(filePath);         
        }
        catch (Exception ex)
        {
          MessageBox.Show($"Ошибка при загрузке данных из Excel: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void LoadDataFromExcel(string filePath)
    {
      ExcelPackage.LicenseContext = LicenseContext.Commercial;

      using (var package = new ExcelPackage(new FileInfo(filePath)))
      {
        var worksheet = package.Workbook.Worksheets.FirstOrDefault();

        if (worksheet != null)
        {
          dataGridView1.ColumnCount = worksheet.Dimension.End.Column;
          dataGridView1.RowCount = worksheet.Dimension.End.Row;
          for (int row = 1; row <= worksheet.Dimension.End.Row; row++)         
          {
            for (int column = 1; column <= worksheet.Dimension.End.Column; column++)
            {
              string cellValue = worksheet.Cells[row, column].Text;

              if (double.TryParse(cellValue, out double Value))               
              {
                dataGridView1[column - 1, row - 1].Value = Value;
              }
              else
              {
                MessageBox.Show($"Некорректное значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
              }
            }
          }
          for (int i = 0; i < worksheet.Dimension.End.Column-1; i++)
          {
            dataGridView1.Columns[i].HeaderCell.Value = $"X{i + 1}";
          }

          dataGridView1.Columns[worksheet.Dimension.End.Column-1].HeaderCell.Value = "B";
        }
      }
    }

    private void button3_Click_1(object sender, EventArgs e)
    {
      try
      {
        dataGridView1.AllowUserToAddRows = false;
        if (Int32.TryParse(SizeGenerateArray.Text, out int N) == false)
        {
          throw new Exception("Некорректный ввод размера!");
        }

        if (Convert.ToInt32(SizeGenerateArray.Text) <= 0)
        {
          throw new Exception("Размер столбца должен быть больше нуля!");
        }

        dataGridView1.Rows.Clear();
        dataGridView1.Columns.Clear();      
        dataGridView1.ColumnCount = N + 1;
        dataGridView1.RowCount = N;

            
        Random random = new Random();

        if (Convert.ToInt32(StartGenerate.Text) > Convert.ToInt32(FinishGenerate.Text))
        {
          throw new Exception("Минимальная граница генерации должна быть меньше максимальной");
        }
        for (int i = 0; i < N; i++)
        {
          for (int j = 0; j <= N; j++)
          {
            dataGridView1.Rows[i].Cells[j].Value = random.Next(Convert.ToInt32(StartGenerate.Text), Convert.ToInt32(FinishGenerate.Text));
          }
          dataGridView1.Columns[i].HeaderCell.Value = $"X{i + 1}";
        }
        dataGridView1.Columns[N].HeaderCell.Value = "B";
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {
      try
      {
        int n;
        dataGridView1.Rows.Clear();
        dataGridView1.Columns.Clear();

        if (!int.TryParse(InputN.Text, out n))
        {
          throw new ArgumentException("Некорректные значения входных данных");
        }

        dataGridView1.ColumnCount = n + 1;
        dataGridView1.RowCount = n;
        var RandomNumber = new Random((int)Stopwatch.GetTimestamp());

        for (int i = 0; i < n; i++)
        {
          dataGridView1.Columns[i].HeaderCell.Value = $"X{i + 1}";
        }

        dataGridView1.Columns[n].HeaderCell.Value = "B";
        dataGridView1.AllowUserToAddRows = false;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    public  double Determinant(double[,] matrix)
    {
      int n = matrix.GetLength(0);
      double det = 0;

      if (n == 1)
      {
        return matrix[0, 0];
      }
      else if (n == 2)
      {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
      }
      else
      {
        for (int k = 0; k < n; k++)
        {
          double[,] subMatrix = new double[n - 1, n - 1];

          for (int i = 1; i < n; i++)
          {
            int jNew = 0;

            for (int j = 0; j < n; j++)
            {
              if (j == k)
              {
                continue;
              }

              subMatrix[i - 1, jNew] = matrix[i, j];
              jNew++;
            }
          }

          det += Math.Pow(-1, k) * matrix[0, k] * Determinant(subMatrix);
        }
      }

      return det;
    }
    public double[] MethodGauss(double[,] matrixParam, double[] resSlau, int countParam)
    {
      try
      {
        double[]result1 = new double[countParam];
        double[,] matrix = matrixParam.Clone() as double[,];
        double[] res = resSlau.Clone() as double[];
        double[] det = new double[countParam];
        double delta = Determinant(matrix);

        if (delta == 0)
        {
          throw new Exception("Система не имеет единственного решения!");
        }

        if (matrix[0, 0] == 0)
        {
          for (int indexRow = 1; indexRow < countParam; ++indexRow)
          {
            if (matrix[indexRow, 0] != 0)
            {
              double[] buffRow = new double[countParam + 1];
              for (int i = 0; i < countParam; i++)
              {
                buffRow[i] = matrix[0, i];
              }
              buffRow[buffRow.Length - 1] = res[0];
              for (int i = 0; i < countParam; i++)
              {
                matrix[0, i] = matrix[indexRow, i];
              }
              res[0] = res[indexRow];
              for (int i = 0; i < countParam; i++)
              {
                matrix[indexRow, i] = buffRow[i];
              }
              res[indexRow] = buffRow[buffRow.Length - 1];
            }
          }
        }

        for (int indexRow = 1; indexRow < countParam; ++indexRow)
        {
          if (matrix[indexRow - 1, indexRow - 1] != 1)
          {      
            double del = matrix[indexRow - 1, indexRow - 1];

            for (int index = 0; index < countParam; ++index)
            {
              matrix[indexRow - 1, index] /= del;
            }

            res[indexRow - 1] /= del;
          }

          for (int index = 0; index < indexRow - 1; ++index)
          {
            double element = matrix[indexRow, index];

            for (int indexColumn = 0; indexColumn < countParam; ++indexColumn)
            {
              matrix[indexRow, indexColumn] = matrix[index, indexColumn] * (-element) + matrix[indexRow, indexColumn];
            }

            res[indexRow] = res[index] * (-element) + res[indexRow];
          }

          double el = matrix[indexRow, indexRow - 1];

          for (int index = indexRow - 1; index < countParam; ++index)
          {
            matrix[indexRow, index] = matrix[indexRow - 1, index] * (-el) + matrix[indexRow, index];
          }

          res[indexRow] = res[indexRow - 1] * (-el) + res[indexRow];
        }

        result1[countParam - 1] = res[countParam - 1] / matrix[countParam - 1, countParam - 1];

        for (int indexRow = countParam - 2; indexRow >= 0; --indexRow)
        {
          double sum = 0;

          for (int indexRes = countParam - 1; indexRes >= indexRow + 1; --indexRes)
          {
            sum += matrix[indexRow, indexRes] * result1[indexRes];
          }

          result1[indexRow] = (res[indexRow] - sum) / matrix[indexRow, indexRow];
        }

        return result1;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        double[] ErrorResult = new double[3];
        return ErrorResult;
      }
}

    public double[] MethodGaussJordan(double[,] matrixParam, double[] resSlau)
    {
      try
      {
        int countParam = matrixParam.GetLength(0);
        double[] result2 = new double[countParam];

        double[,] matrix = matrixParam.Clone() as double[,];
        double[] res = resSlau.Clone() as double[];
        double[] det = new double[countParam];
        double delta = Determinant(matrix);

        if (delta == 0)
        {
          throw new Exception("Система не имеет единственного решения!");
        }
        if (matrix[0, 0] == 0)
        {
          for (int indexRow = 1; indexRow < countParam; ++indexRow)
          {
            if (matrix[indexRow, 0] != 0)
            {
              double[] buffRow = new double[countParam + 1];
              for (int i = 0; i < countParam; i++)
              {
                buffRow[i] = matrix[0, i];
              }
              buffRow[buffRow.Length - 1] = res[0];
              for (int i = 0; i < countParam; i++)
              {
                matrix[0, i] = matrix[indexRow, i];
              }
              res[0] = res[indexRow];
              for (int i = 0; i < countParam; i++)
              {
                matrix[indexRow, i] = buffRow[i];
              }
              res[indexRow] = buffRow[buffRow.Length - 1];
            }
          }
        }

        for (int indexRow = 1; indexRow < countParam; ++indexRow)
        {
          if (matrix[indexRow - 1, indexRow - 1] != 1)
          {    
            double del = matrix[indexRow - 1, indexRow - 1];

            for (int index = 0; index < countParam; ++index)
            {
              matrix[indexRow - 1, index] /= del;
            }

            res[indexRow - 1] /= del;
          }

          for (int index = 0; index < indexRow - 1; ++index)
          {
            double element = matrix[indexRow, index];

            for (int indexColumn = 0; indexColumn < countParam; ++indexColumn)
            {
              matrix[indexRow, indexColumn] = matrix[index, indexColumn] * (-element) + matrix[indexRow, indexColumn];
            }

            res[indexRow] = res[index] * (-element) + res[indexRow];
          }

          double el = matrix[indexRow, indexRow - 1];

          for (int index = indexRow - 1; index < countParam; ++index)
          {
            matrix[indexRow, index] = matrix[indexRow - 1, index] * (-el) + matrix[indexRow, index];
          }

          res[indexRow] = res[indexRow - 1] * (-el) + res[indexRow];
        }

        if (matrix[countParam - 1, countParam - 1] != 1)
        {      
          double del = matrix[countParam - 1, countParam - 1];

          matrix[countParam - 1, countParam - 1] /= del;
          res[countParam - 1] /= del;
        }

        result2[countParam - 1] = res[countParam - 1] / matrix[countParam - 1, countParam - 1];

        for (int indexRow = countParam - 2; indexRow >= 0; --indexRow)
        {
          if (matrix[indexRow + 1, indexRow + 1] != 1)
          {      
            double del = matrix[indexRow + 1, indexRow + 1];

            for (int index = 0; index < countParam; ++index)
            {
              matrix[indexRow + 1, index] /= del;
            }

            res[indexRow + 1] /= del;
          }

          for (int index = countParam - 1; index > indexRow; --index)
          {
            double element = matrix[indexRow, index];

            for (int indexColumn = countParam - 1; indexColumn >= 0; --indexColumn)
            {
              matrix[indexRow, indexColumn] = matrix[index, indexColumn] * (-element) + matrix[indexRow, indexColumn];
            }

            res[indexRow] = res[index] * (-element) + res[indexRow];
          }

          //double el = matrix[indexRow, indexRow + 1];

          //for (int index = countParam - 1; index >= indexRow + 1; --index) {
          //  matrix[indexRow, index] = matrix[indexRow + 1, index] * (-el) + matrix[indexRow, index];
          //}

          //res[indexRow] = res[indexRow + 1] * (-el) + res[indexRow];
        }

        for (int index = 0; index < countParam; ++index)
        {
          result2[index] = res[index];
        }

        return result2;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        double[] ErrorResult = new double[3];
        return ErrorResult;
      }
    }

    public double[] MethodKramer(double[,] matrixParam, double[] resSlau, int countParam)
    {
      try
      {
        double[] result3 = new double[countParam];

        double[,] matrix = matrixParam.Clone() as double[,];
        double[] res = resSlau.Clone() as double[];
        double[] det = new double[countParam];
        double delta = Determinant(matrix);

        if (delta == 0)
        {
          throw new Exception("Система не имеет единственного решения!");
        }

        for (int indexColumn = 0; indexColumn < countParam; ++indexColumn)
        {
          matrix = matrixParam.Clone() as double[,];

          for (int indexRow = 0; indexRow < countParam; ++indexRow)
          {
            matrix[indexRow, indexColumn] = res[indexRow];
          }

          result3[indexColumn] = Determinant(matrix) / delta;
        }

        return result3;

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        double[] ErrorResult = new double[3];
        return ErrorResult;
      }
      
    }
    private void LineA_Click(object sender, EventArgs e)
    {

    }

    private void button6_Click(object sender, EventArgs e)
    {
      this.Close();
      MainForm.Show();
    }

    private void TrapezeCheck_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
