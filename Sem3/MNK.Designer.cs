﻿
using System.Windows.Forms;

namespace Sem3
{
    partial class MNK
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MNK));
            this.button1 = new System.Windows.Forms.Button();
            this.LineCheck = new System.Windows.Forms.RadioButton();
            this.defaultArrayButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ParabolaCheck = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LineFun = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InaccuracyLine = new System.Windows.Forms.Label();
            this.InaccuracyParabola = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SizeGenerateArray = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FinishGenerate = new System.Windows.Forms.TextBox();
            this.StartGenerate = new System.Windows.Forms.TextBox();
            this.ParabolaFun = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PrognosisN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(1056, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Найти коэффициенты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LineCheck
            // 
            this.LineCheck.AutoSize = true;
            this.LineCheck.Checked = true;
            this.LineCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LineCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.LineCheck.Location = new System.Drawing.Point(548, 164);
            this.LineCheck.Name = "LineCheck";
            this.LineCheck.Size = new System.Drawing.Size(53, 28);
            this.LineCheck.TabIndex = 12;
            this.LineCheck.TabStop = true;
            this.LineCheck.Text = "y =\r\n";
            this.LineCheck.UseVisualStyleBackColor = true;
            // 
            // defaultArrayButton
            // 
            this.defaultArrayButton.BackColor = System.Drawing.Color.Black;
            this.defaultArrayButton.FlatAppearance.BorderSize = 0;
            this.defaultArrayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultArrayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.defaultArrayButton.ForeColor = System.Drawing.Color.IndianRed;
            this.defaultArrayButton.Location = new System.Drawing.Point(30, 582);
            this.defaultArrayButton.Name = "defaultArrayButton";
            this.defaultArrayButton.Size = new System.Drawing.Size(246, 50);
            this.defaultArrayButton.TabIndex = 20;
            this.defaultArrayButton.Text = "Готовое множество";
            this.defaultArrayButton.UseVisualStyleBackColor = true;
            this.defaultArrayButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label3.Location = new System.Drawing.Point(49, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Выборка данных\r\n";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label5.Location = new System.Drawing.Point(538, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Виды функций\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnY});
            this.dataGridView1.Location = new System.Drawing.Point(30, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 354);
            this.dataGridView1.TabIndex = 29;
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.Name = "ColumnX";
            // 
            // ColumnY
            // 
            this.ColumnY.HeaderText = "Y";
            this.ColumnY.Name = "ColumnY";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel|*.xlsx";
            // 
            // ParabolaCheck
            // 
            this.ParabolaCheck.AutoSize = true;
            this.ParabolaCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParabolaCheck.ForeColor = System.Drawing.SystemColors.Control;
            this.ParabolaCheck.Location = new System.Drawing.Point(548, 197);
            this.ParabolaCheck.Name = "ParabolaCheck";
            this.ParabolaCheck.Size = new System.Drawing.Size(58, 28);
            this.ParabolaCheck.TabIndex = 30;
            this.ParabolaCheck.Text = "y = \r\n";
            this.ParabolaCheck.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(299, 395);
            this.chart1.Name = "chart1";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series7.Name = "Series2";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.Color = System.Drawing.Color.Indigo;
            series8.Name = "Series1";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series9.Color = System.Drawing.Color.Blue;
            series9.Name = "Series3";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(938, 420);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            // 
            // LineFun
            // 
            this.LineFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LineFun.ForeColor = System.Drawing.SystemColors.Control;
            this.LineFun.Location = new System.Drawing.Point(597, 166);
            this.LineFun.Name = "LineFun";
            this.LineFun.Size = new System.Drawing.Size(453, 28);
            this.LineFun.TabIndex = 32;
            this.LineFun.Text = "a * x + b";
            this.LineFun.Click += new System.EventHandler(this.LineA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(273, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 64);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // InaccuracyLine
            // 
            this.InaccuracyLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InaccuracyLine.ForeColor = System.Drawing.SystemColors.Control;
            this.InaccuracyLine.Location = new System.Drawing.Point(295, 166);
            this.InaccuracyLine.Name = "InaccuracyLine";
            this.InaccuracyLine.Size = new System.Drawing.Size(234, 28);
            this.InaccuracyLine.TabIndex = 36;
            // 
            // InaccuracyParabola
            // 
            this.InaccuracyParabola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InaccuracyParabola.ForeColor = System.Drawing.SystemColors.Control;
            this.InaccuracyParabola.Location = new System.Drawing.Point(295, 199);
            this.InaccuracyParabola.Name = "InaccuracyParabola";
            this.InaccuracyParabola.Size = new System.Drawing.Size(234, 28);
            this.InaccuracyParabola.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(30, 638);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 50);
            this.button2.TabIndex = 38;
            this.button2.Text = "Множество из Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.IndianRed;
            this.button3.Location = new System.Drawing.Point(30, 694);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 50);
            this.button3.TabIndex = 39;
            this.button3.Text = "Случайное множество ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.DarkRed;
            this.button4.Location = new System.Drawing.Point(30, 526);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(246, 50);
            this.button4.TabIndex = 40;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SizeGenerateArray
            // 
            this.SizeGenerateArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SizeGenerateArray.Location = new System.Drawing.Point(111, 753);
            this.SizeGenerateArray.Name = "SizeGenerateArray";
            this.SizeGenerateArray.Size = new System.Drawing.Size(165, 29);
            this.SizeGenerateArray.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(26, 753);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 42;
            this.label1.Text = "Размер";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(20, 786);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 43;
            this.label2.Text = "Чисел от";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(176, 785);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 28);
            this.label4.TabIndex = 45;
            this.label4.Text = "до";
            // 
            // FinishGenerate
            // 
            this.FinishGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinishGenerate.Location = new System.Drawing.Point(217, 786);
            this.FinishGenerate.Name = "FinishGenerate";
            this.FinishGenerate.Size = new System.Drawing.Size(59, 29);
            this.FinishGenerate.TabIndex = 46;
            // 
            // StartGenerate
            // 
            this.StartGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGenerate.Location = new System.Drawing.Point(111, 786);
            this.StartGenerate.Name = "StartGenerate";
            this.StartGenerate.Size = new System.Drawing.Size(59, 29);
            this.StartGenerate.TabIndex = 47;
            // 
            // ParabolaFun
            // 
            this.ParabolaFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParabolaFun.ForeColor = System.Drawing.SystemColors.Control;
            this.ParabolaFun.Location = new System.Drawing.Point(597, 199);
            this.ParabolaFun.Name = "ParabolaFun";
            this.ParabolaFun.Size = new System.Drawing.Size(640, 26);
            this.ParabolaFun.TabIndex = 48;
            this.ParabolaFun.Text = "a * x ^ 2 + b * x + c";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label6.Location = new System.Drawing.Point(543, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 28);
            this.label6.TabIndex = 49;
            this.label6.Text = "Прогнозирование";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(544, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 30);
            this.label8.TabIndex = 51;
            this.label8.Text = "Проихвести прогнозирования";
            // 
            // PrognosisN
            // 
            this.PrognosisN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrognosisN.Location = new System.Drawing.Point(574, 315);
            this.PrognosisN.Name = "PrognosisN";
            this.PrognosisN.Size = new System.Drawing.Size(165, 29);
            this.PrognosisN.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(745, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 26);
            this.label7.TabIndex = 53;
            this.label7.Text = "точек";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.IndianRed;
            this.button5.Location = new System.Drawing.Point(1056, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 78);
            this.button5.TabIndex = 55;
            this.button5.Text = "Произвести прогноз\r\n";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(544, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 29);
            this.label9.TabIndex = 56;
            this.label9.Text = "на";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(184, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(578, 46);
            this.label10.TabIndex = 57;
            this.label10.Text = "Метод наименьших квадратов";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.IndianRed;
            this.button6.Location = new System.Drawing.Point(939, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(219, 47);
            this.button6.TabIndex = 58;
            this.button6.Text = "Главное меню";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MNK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1260, 827);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PrognosisN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ParabolaFun);
            this.Controls.Add(this.StartGenerate);
            this.Controls.Add(this.FinishGenerate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SizeGenerateArray);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.InaccuracyParabola);
            this.Controls.Add(this.InaccuracyLine);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LineFun);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.ParabolaCheck);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.defaultArrayButton);
            this.Controls.Add(this.LineCheck);
            this.Controls.Add(this.button1);
            this.Name = "MNK";
            this.Text = "Сортировки";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private RadioButton LineCheck;
        private Button defaultArrayButton;
        private Label label3;
        private Label label5;
        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialog1;
        private RadioButton ParabolaCheck;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn ColumnY;
        private Label LineFun;
        private PictureBox pictureBox1;
        private Label InaccuracyLine;
        private Label InaccuracyParabola;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox SizeGenerateArray;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox FinishGenerate;
        private TextBox StartGenerate;
        private Label ParabolaFun;
        private Label label6;
        private Label label8;
        private TextBox PrognosisN;
        private Label label7;
        private Button button5;
        private Label label9;
        private Label label10;
        private Button button6;
    }
}

