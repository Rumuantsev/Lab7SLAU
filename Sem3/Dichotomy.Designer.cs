using System;
using System.Windows.Forms;


namespace Sem3
{
    partial class Dichotomy
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.labelA = new System.Windows.Forms.Label();
      this.labelE = new System.Windows.Forms.Label();
      this.labelB = new System.Windows.Forms.Label();
      this.textBoxA = new System.Windows.Forms.TextBox();
      this.textBoxB = new System.Windows.Forms.TextBox();
      this.textBoxE = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.clearButton = new System.Windows.Forms.Button();
      this.calculateButton = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.ResultX = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.textBoxY = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // labelA
      // 
      this.labelA.AutoSize = true;
      this.labelA.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelA.ForeColor = System.Drawing.Color.White;
      this.labelA.Location = new System.Drawing.Point(6, 142);
      this.labelA.Name = "labelA";
      this.labelA.Size = new System.Drawing.Size(57, 34);
      this.labelA.TabIndex = 0;
      this.labelA.Text = "a =";
      // 
      // labelE
      // 
      this.labelE.AutoSize = true;
      this.labelE.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelE.ForeColor = System.Drawing.Color.White;
      this.labelE.Location = new System.Drawing.Point(409, 141);
      this.labelE.Name = "labelE";
      this.labelE.Size = new System.Drawing.Size(57, 34);
      this.labelE.TabIndex = 1;
      this.labelE.Text = "e =";
      this.labelE.Click += new System.EventHandler(this.label1_Click);
      // 
      // labelB
      // 
      this.labelB.AutoSize = true;
      this.labelB.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelB.ForeColor = System.Drawing.Color.White;
      this.labelB.Location = new System.Drawing.Point(210, 141);
      this.labelB.Name = "labelB";
      this.labelB.Size = new System.Drawing.Size(59, 34);
      this.labelB.TabIndex = 2;
      this.labelB.Text = "b =";
      // 
      // textBoxA
      // 
      this.textBoxA.BackColor = System.Drawing.SystemColors.ControlText;
      this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxA.ForeColor = System.Drawing.SystemColors.Window;
      this.textBoxA.Location = new System.Drawing.Point(69, 146);
      this.textBoxA.Name = "textBoxA";
      this.textBoxA.Size = new System.Drawing.Size(100, 31);
      this.textBoxA.TabIndex = 3;
      this.textBoxA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // textBoxB
      // 
      this.textBoxB.BackColor = System.Drawing.SystemColors.ControlText;
      this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxB.ForeColor = System.Drawing.SystemColors.Window;
      this.textBoxB.Location = new System.Drawing.Point(275, 144);
      this.textBoxB.Name = "textBoxB";
      this.textBoxB.Size = new System.Drawing.Size(100, 31);
      this.textBoxB.TabIndex = 4;
      // 
      // textBoxE
      // 
      this.textBoxE.BackColor = System.Drawing.SystemColors.ControlText;
      this.textBoxE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxE.ForeColor = System.Drawing.SystemColors.Window;
      this.textBoxE.Location = new System.Drawing.Point(472, 145);
      this.textBoxE.Name = "textBoxE";
      this.textBoxE.Size = new System.Drawing.Size(100, 31);
      this.textBoxE.TabIndex = 5;
      this.textBoxE.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(104, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(362, 47);
      this.label1.TabIndex = 6;
      this.label1.Text = "Метод Дихотомии";
      this.label1.Click += new System.EventHandler(this.label1_Click_1);
      // 
      // clearButton
      // 
      this.clearButton.BackColor = System.Drawing.Color.Black;
      this.clearButton.FlatAppearance.BorderSize = 0;
      this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.clearButton.ForeColor = System.Drawing.Color.IndianRed;
      this.clearButton.Location = new System.Drawing.Point(602, 144);
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(146, 35);
      this.clearButton.TabIndex = 7;
      this.clearButton.Text = "Очистить";
      this.clearButton.UseVisualStyleBackColor = false;
      this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
      // 
      // calculateButton
      // 
      this.calculateButton.BackColor = System.Drawing.Color.Black;
      this.calculateButton.FlatAppearance.BorderSize = 0;
      this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.calculateButton.ForeColor = System.Drawing.Color.IndianRed;
      this.calculateButton.Location = new System.Drawing.Point(602, 678);
      this.calculateButton.Name = "calculateButton";
      this.calculateButton.Size = new System.Drawing.Size(159, 35);
      this.calculateButton.TabIndex = 8;
      this.calculateButton.Text = "Рассчитать\r\n";
      this.calculateButton.UseVisualStyleBackColor = false;
      this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(22, 679);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(160, 34);
      this.label2.TabIndex = 9;
      this.label2.Text = "Результат:";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // ResultX
      // 
      this.ResultX.BackColor = System.Drawing.SystemColors.ControlText;
      this.ResultX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ResultX.ForeColor = System.Drawing.SystemColors.Window;
      this.ResultX.Location = new System.Drawing.Point(216, 682);
      this.ResultX.Name = "ResultX";
      this.ResultX.ReadOnly = true;
      this.ResultX.Size = new System.Drawing.Size(356, 31);
      this.ResultX.TabIndex = 10;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.White;
      this.label5.Location = new System.Drawing.Point(6, 93);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(196, 34);
      this.label5.TabIndex = 14;
      this.label5.Text = "Ввод данных:";
      this.label5.Click += new System.EventHandler(this.label5_Click);
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Black;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.ForeColor = System.Drawing.Color.IndianRed;
      this.button1.Location = new System.Drawing.Point(569, 19);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(219, 47);
      this.button1.TabIndex = 15;
      this.button1.Text = "Главное меню";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // chart1
      // 
      chartArea2.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea2);
      this.chart1.Location = new System.Drawing.Point(12, 195);
      this.chart1.Name = "chart1";
      series2.BorderWidth = 3;
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      series2.Name = "Series1";
      series2.ShadowColor = System.Drawing.Color.Black;
      this.chart1.Series.Add(series2);
      this.chart1.Size = new System.Drawing.Size(736, 459);
      this.chart1.TabIndex = 16;
      this.chart1.Text = "chart1";
      // 
      // textBoxY
      // 
      this.textBoxY.BackColor = System.Drawing.SystemColors.ControlText;
      this.textBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxY.ForeColor = System.Drawing.SystemColors.Window;
      this.textBoxY.Location = new System.Drawing.Point(275, 96);
      this.textBoxY.Name = "textBoxY";
      this.textBoxY.Size = new System.Drawing.Size(297, 31);
      this.textBoxY.TabIndex = 18;
      // 
      // label3
      // 
      this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(210, 93);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(56, 34);
      this.label3.TabIndex = 17;
      this.label3.Text = "y =";
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.Black;
      this.button2.FlatAppearance.BorderSize = 0;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button2.ForeColor = System.Drawing.Color.IndianRed;
      this.button2.Location = new System.Drawing.Point(602, 90);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(146, 48);
      this.button2.TabIndex = 19;
      this.button2.Text = "Функция \r\nпо-умолчанию";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // DichotomyForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.DarkRed;
      this.ClientSize = new System.Drawing.Size(800, 741);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.textBoxY);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.ResultX);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.calculateButton);
      this.Controls.Add(this.clearButton);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxE);
      this.Controls.Add(this.textBoxB);
      this.Controls.Add(this.textBoxA);
      this.Controls.Add(this.labelB);
      this.Controls.Add(this.labelE);
      this.Controls.Add(this.labelA);
      this.Name = "DichotomyForm";
      this.Text = "Дихотомия";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
        private Button calculateButton;
        private Label label2;
        private TextBox ResultX;
        private Label label5;
        private Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private TextBox textBoxY;
    private Label label3;
    private Button button2;
  }
}

