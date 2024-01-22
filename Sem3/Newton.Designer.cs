
using System.Windows.Forms;

namespace Sem3
{
    partial class Newton
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.GoldenMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InputFunc = new System.Windows.Forms.TextBox();
            this.DefultFunc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GoldenMin = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.NewtonX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ExMin = new System.Windows.Forms.Label();
            this.ExMax = new System.Windows.Forms.Label();
            this.Intersection = new System.Windows.Forms.Label();
            this.Counter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.ForeColor = System.Drawing.Color.White;
            this.labelA.Location = new System.Drawing.Point(19, 141);
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
            this.textBoxA.Location = new System.Drawing.Point(82, 141);
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
            this.textBoxE.Text = "0,001";
            this.textBoxE.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(690, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "Метод Ньютона и Золотого сечения\r\n";
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
            this.clearButton.Size = new System.Drawing.Size(159, 35);
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
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.ForeColor = System.Drawing.Color.IndianRed;
            this.calculateButton.Location = new System.Drawing.Point(849, 99);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(213, 76);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Рассчитать\r\n";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(861, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Результат:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // GoldenMax
            // 
            this.GoldenMax.BackColor = System.Drawing.SystemColors.ControlText;
            this.GoldenMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoldenMax.ForeColor = System.Drawing.SystemColors.Window;
            this.GoldenMax.Location = new System.Drawing.Point(997, 421);
            this.GoldenMax.Name = "GoldenMax";
            this.GoldenMax.ReadOnly = true;
            this.GoldenMax.Size = new System.Drawing.Size(201, 31);
            this.GoldenMax.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 34);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ввод данных:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(25, 225);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.LabelBorderWidth = 3;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(736, 382);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // InputFunc
            // 
            this.InputFunc.BackColor = System.Drawing.SystemColors.ControlText;
            this.InputFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputFunc.ForeColor = System.Drawing.SystemColors.Window;
            this.InputFunc.Location = new System.Drawing.Point(224, 92);
            this.InputFunc.Name = "InputFunc";
            this.InputFunc.Size = new System.Drawing.Size(361, 31);
            this.InputFunc.TabIndex = 16;
            // 
            // DefultFunc
            // 
            this.DefultFunc.BackColor = System.Drawing.Color.Black;
            this.DefultFunc.FlatAppearance.BorderSize = 0;
            this.DefultFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DefultFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DefultFunc.ForeColor = System.Drawing.Color.IndianRed;
            this.DefultFunc.Location = new System.Drawing.Point(602, 92);
            this.DefultFunc.Name = "DefultFunc";
            this.DefultFunc.Size = new System.Drawing.Size(159, 35);
            this.DefultFunc.TabIndex = 17;
            this.DefultFunc.Text = "Функция по-умолчанию";
            this.DefultFunc.UseVisualStyleBackColor = false;
            this.DefultFunc.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(777, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 30);
            this.label3.TabIndex = 18;
            this.label3.Text = "Метод золотого сечения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(778, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Точка минимума:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(778, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "Точка максимума:";
            // 
            // GoldenMin
            // 
            this.GoldenMin.BackColor = System.Drawing.SystemColors.ControlText;
            this.GoldenMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoldenMin.ForeColor = System.Drawing.SystemColors.Window;
            this.GoldenMin.Location = new System.Drawing.Point(997, 351);
            this.GoldenMin.Name = "GoldenMin";
            this.GoldenMin.ReadOnly = true;
            this.GoldenMin.Size = new System.Drawing.Size(201, 31);
            this.GoldenMin.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(777, 490);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(201, 30);
            this.label14.TabIndex = 33;
            this.label14.Text = "Метод Ньютона:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(778, 549);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(190, 24);
            this.label17.TabIndex = 35;
            this.label17.Text = "Точка пересечения:";
            // 
            // NewtonX
            // 
            this.NewtonX.BackColor = System.Drawing.SystemColors.ControlText;
            this.NewtonX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewtonX.ForeColor = System.Drawing.SystemColors.Window;
            this.NewtonX.Location = new System.Drawing.Point(997, 549);
            this.NewtonX.Name = "NewtonX";
            this.NewtonX.ReadOnly = true;
            this.NewtonX.Size = new System.Drawing.Size(201, 31);
            this.NewtonX.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1206, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 36;
            // 
            // ExMin
            // 
            this.ExMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExMin.ForeColor = System.Drawing.Color.NavajoWhite;
            this.ExMin.Location = new System.Drawing.Point(1206, 351);
            this.ExMin.Name = "ExMin";
            this.ExMin.Size = new System.Drawing.Size(146, 28);
            this.ExMin.TabIndex = 37;
            // 
            // ExMax
            // 
            this.ExMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExMax.ForeColor = System.Drawing.Color.NavajoWhite;
            this.ExMax.Location = new System.Drawing.Point(1206, 421);
            this.ExMax.Name = "ExMax";
            this.ExMax.Size = new System.Drawing.Size(146, 28);
            this.ExMax.TabIndex = 38;
            // 
            // Intersection
            // 
            this.Intersection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Intersection.ForeColor = System.Drawing.Color.NavajoWhite;
            this.Intersection.Location = new System.Drawing.Point(1206, 552);
            this.Intersection.Name = "Intersection";
            this.Intersection.Size = new System.Drawing.Size(221, 28);
            this.Intersection.TabIndex = 39;
            // 
            // Counter
            // 
            this.Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Counter.ForeColor = System.Drawing.Color.NavajoWhite;
            this.Counter.Location = new System.Drawing.Point(782, 598);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(424, 28);
            this.Counter.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(136, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 35);
            this.button1.TabIndex = 41;
            this.button1.Text = "От PI до PI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(849, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 47);
            this.button2.TabIndex = 42;
            this.button2.Text = "Главное меню";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Newton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1209, 635);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.Intersection);
            this.Controls.Add(this.ExMax);
            this.Controls.Add(this.ExMin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.NewtonX);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GoldenMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DefultFunc);
            this.Controls.Add(this.InputFunc);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GoldenMax);
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
            this.Name = "Newton";
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
        private TextBox GoldenMax;
        private Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TextBox InputFunc;
        private Button DefultFunc;
        private Label label3;
        private Label label4;
        private Label label10;
        private TextBox GoldenMin;
        private Label label14;
        private Label label17;
        private TextBox NewtonX;
        private Label label6;
        private Label ExMin;
        private Label ExMax;
        private Label Intersection;
        private Label Counter;
        private Button button1;
        private Button button2;
    }
}

