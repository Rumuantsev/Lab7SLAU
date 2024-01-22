
using System.Windows.Forms;

namespace Sem3
{
    partial class Sort
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
      System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.button1 = new System.Windows.Forms.Button();
      this.InsertCheck = new System.Windows.Forms.CheckBox();
      this.FastCheck = new System.Windows.Forms.CheckBox();
      this.ShakerCheck = new System.Windows.Forms.CheckBox();
      this.BogoCheck = new System.Windows.Forms.CheckBox();
      this.BubbleCheck = new System.Windows.Forms.CheckBox();
      this.result = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.UpCheck = new System.Windows.Forms.RadioButton();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.DownCheck = new System.Windows.Forms.RadioButton();
      this.randomArrayButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.start = new System.Windows.Forms.Label();
      this.SizeGenerateArray = new System.Windows.Forms.TextBox();
      this.defaultArrayButton = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.time1 = new System.Windows.Forms.Label();
      this.time3 = new System.Windows.Forms.Label();
      this.time2 = new System.Windows.Forms.Label();
      this.time4 = new System.Windows.Forms.Label();
      this.time5 = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.button2 = new System.Windows.Forms.Button();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.startNumber = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.finishNumber = new System.Windows.Forms.TextBox();
      this.button3 = new System.Windows.Forms.Button();
      this.label10 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Black;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.ForeColor = System.Drawing.Color.IndianRed;
      this.button1.Location = new System.Drawing.Point(812, 659);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(159, 49);
      this.button1.TabIndex = 2;
      this.button1.Text = "Отсортировать массив";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // InsertCheck
      // 
      this.InsertCheck.AutoSize = true;
      this.InsertCheck.Cursor = System.Windows.Forms.Cursors.Cross;
      this.InsertCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.InsertCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.InsertCheck.Location = new System.Drawing.Point(12, 153);
      this.InsertCheck.Name = "InsertCheck";
      this.InsertCheck.Size = new System.Drawing.Size(237, 28);
      this.InsertCheck.TabIndex = 7;
      this.InsertCheck.Text = "Сортировка вставками";
      this.InsertCheck.UseVisualStyleBackColor = true;
      this.InsertCheck.CheckedChanged += new System.EventHandler(this.InsertCheck_CheckedChanged);
      // 
      // FastCheck
      // 
      this.FastCheck.AutoSize = true;
      this.FastCheck.Cursor = System.Windows.Forms.Cursors.Cross;
      this.FastCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.FastCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.FastCheck.Location = new System.Drawing.Point(12, 244);
      this.FastCheck.Name = "FastCheck";
      this.FastCheck.Size = new System.Drawing.Size(216, 28);
      this.FastCheck.TabIndex = 8;
      this.FastCheck.Text = "Быстрая сортировка";
      this.FastCheck.UseVisualStyleBackColor = true;
      this.FastCheck.CheckedChanged += new System.EventHandler(this.FastCheck_CheckedChanged);
      // 
      // ShakerCheck
      // 
      this.ShakerCheck.AutoSize = true;
      this.ShakerCheck.Cursor = System.Windows.Forms.Cursors.Cross;
      this.ShakerCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ShakerCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.ShakerCheck.Location = new System.Drawing.Point(12, 197);
      this.ShakerCheck.Name = "ShakerCheck";
      this.ShakerCheck.Size = new System.Drawing.Size(237, 28);
      this.ShakerCheck.TabIndex = 9;
      this.ShakerCheck.Text = "Шейкерная сортировка";
      this.ShakerCheck.UseVisualStyleBackColor = true;
      this.ShakerCheck.CheckedChanged += new System.EventHandler(this.ShakerCheck_CheckedChanged);
      // 
      // BogoCheck
      // 
      this.BogoCheck.AutoSize = true;
      this.BogoCheck.Cursor = System.Windows.Forms.Cursors.Cross;
      this.BogoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.BogoCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.BogoCheck.Location = new System.Drawing.Point(12, 290);
      this.BogoCheck.Name = "BogoCheck";
      this.BogoCheck.Size = new System.Drawing.Size(225, 28);
      this.BogoCheck.TabIndex = 10;
      this.BogoCheck.Text = "Болотная сортировка";
      this.BogoCheck.UseVisualStyleBackColor = true;
      this.BogoCheck.CheckedChanged += new System.EventHandler(this.BogoChack_CheckedChanged);
      // 
      // BubbleCheck
      // 
      this.BubbleCheck.AutoSize = true;
      this.BubbleCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.BubbleCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.BubbleCheck.Location = new System.Drawing.Point(12, 106);
      this.BubbleCheck.Name = "BubbleCheck";
      this.BubbleCheck.Size = new System.Drawing.Size(257, 28);
      this.BubbleCheck.TabIndex = 11;
      this.BubbleCheck.Text = "Пузырьковая сортировка";
      this.BubbleCheck.UseMnemonic = false;
      this.BubbleCheck.UseVisualStyleBackColor = true;
      this.BubbleCheck.CheckedChanged += new System.EventHandler(this.BubbleCheck_CheckedChanged_1);
      // 
      // result
      // 
      this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.result.ForeColor = System.Drawing.SystemColors.Control;
      this.result.Location = new System.Drawing.Point(277, 375);
      this.result.Name = "result";
      this.result.Size = new System.Drawing.Size(529, 27);
      this.result.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.ForeColor = System.Drawing.Color.NavajoWhite;
      this.label2.Location = new System.Drawing.Point(8, 374);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(261, 28);
      this.label2.TabIndex = 0;
      this.label2.Text = "Отсортированный массив:";
      // 
      // UpCheck
      // 
      this.UpCheck.AutoSize = true;
      this.UpCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.UpCheck.ForeColor = System.Drawing.SystemColors.Control;
      this.UpCheck.Location = new System.Drawing.Point(812, 579);
      this.UpCheck.Name = "UpCheck";
      this.UpCheck.Size = new System.Drawing.Size(176, 28);
      this.UpCheck.TabIndex = 12;
      this.UpCheck.TabStop = true;
      this.UpCheck.Text = "По возрастанию";
      this.UpCheck.UseVisualStyleBackColor = true;
      // 
      // chart1
      // 
      chartArea3.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea3);
      this.chart1.Location = new System.Drawing.Point(12, 415);
      this.chart1.Name = "chart1";
      series3.ChartArea = "ChartArea1";
      series3.Name = "Series1";
      this.chart1.Series.Add(series3);
      this.chart1.Size = new System.Drawing.Size(774, 300);
      this.chart1.TabIndex = 14;
      this.chart1.Text = "chart1";
      // 
      // DownCheck
      // 
      this.DownCheck.AutoSize = true;
      this.DownCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.DownCheck.ForeColor = System.Drawing.SystemColors.Control;
      this.DownCheck.Location = new System.Drawing.Point(812, 613);
      this.DownCheck.Name = "DownCheck";
      this.DownCheck.Size = new System.Drawing.Size(147, 28);
      this.DownCheck.TabIndex = 15;
      this.DownCheck.TabStop = true;
      this.DownCheck.Text = "По убыванию";
      this.DownCheck.UseVisualStyleBackColor = true;
      this.DownCheck.CheckedChanged += new System.EventHandler(this.DownCheck_CheckedChanged);
      // 
      // randomArrayButton
      // 
      this.randomArrayButton.BackColor = System.Drawing.Color.Black;
      this.randomArrayButton.FlatAppearance.BorderSize = 0;
      this.randomArrayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.randomArrayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.randomArrayButton.ForeColor = System.Drawing.Color.IndianRed;
      this.randomArrayButton.Location = new System.Drawing.Point(462, 144);
      this.randomArrayButton.Name = "randomArrayButton";
      this.randomArrayButton.Size = new System.Drawing.Size(223, 50);
      this.randomArrayButton.TabIndex = 16;
      this.randomArrayButton.Text = "Случайный массив";
      this.randomArrayButton.UseVisualStyleBackColor = true;
      this.randomArrayButton.Click += new System.EventHandler(this.button2_Click);
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
      this.label1.Location = new System.Drawing.Point(8, 332);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(179, 28);
      this.label1.TabIndex = 17;
      this.label1.Text = "Исходный массив:";
      // 
      // start
      // 
      this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.start.ForeColor = System.Drawing.SystemColors.Control;
      this.start.Location = new System.Drawing.Point(195, 333);
      this.start.Name = "start";
      this.start.Size = new System.Drawing.Size(611, 27);
      this.start.TabIndex = 18;
      // 
      // SizeGenerateArray
      // 
      this.SizeGenerateArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.SizeGenerateArray.Location = new System.Drawing.Point(860, 155);
      this.SizeGenerateArray.Name = "SizeGenerateArray";
      this.SizeGenerateArray.Size = new System.Drawing.Size(149, 29);
      this.SizeGenerateArray.TabIndex = 19;
      // 
      // defaultArrayButton
      // 
      this.defaultArrayButton.BackColor = System.Drawing.Color.Black;
      this.defaultArrayButton.FlatAppearance.BorderSize = 0;
      this.defaultArrayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.defaultArrayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.defaultArrayButton.ForeColor = System.Drawing.Color.IndianRed;
      this.defaultArrayButton.Location = new System.Drawing.Point(462, 75);
      this.defaultArrayButton.Name = "defaultArrayButton";
      this.defaultArrayButton.Size = new System.Drawing.Size(547, 50);
      this.defaultArrayButton.TabIndex = 20;
      this.defaultArrayButton.Text = "Использовать массив по-умолчанию";
      this.defaultArrayButton.UseVisualStyleBackColor = true;
      this.defaultArrayButton.Click += new System.EventHandler(this.button3_Click);
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.ForeColor = System.Drawing.SystemColors.Control;
      this.label4.Location = new System.Drawing.Point(691, 144);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(163, 50);
      this.label4.TabIndex = 21;
      this.label4.Text = "Размер массива \r\nдля генерации:";
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.ForeColor = System.Drawing.Color.NavajoWhite;
      this.label3.Location = new System.Drawing.Point(23, 75);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(205, 28);
      this.label3.TabIndex = 22;
      this.label3.Text = "Методы сортировки";
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label5.ForeColor = System.Drawing.Color.NavajoWhite;
      this.label5.Location = new System.Drawing.Point(808, 548);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(180, 28);
      this.label5.TabIndex = 23;
      this.label5.Text = "Виды сортировки";
      // 
      // time1
      // 
      this.time1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.time1.ForeColor = System.Drawing.Color.NavajoWhite;
      this.time1.Location = new System.Drawing.Point(275, 106);
      this.time1.Name = "time1";
      this.time1.Size = new System.Drawing.Size(162, 28);
      this.time1.TabIndex = 24;
      // 
      // time3
      // 
      this.time3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.time3.ForeColor = System.Drawing.Color.NavajoWhite;
      this.time3.Location = new System.Drawing.Point(275, 197);
      this.time3.Name = "time3";
      this.time3.Size = new System.Drawing.Size(162, 28);
      this.time3.TabIndex = 25;
      // 
      // time2
      // 
      this.time2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.time2.ForeColor = System.Drawing.Color.NavajoWhite;
      this.time2.Location = new System.Drawing.Point(275, 153);
      this.time2.Name = "time2";
      this.time2.Size = new System.Drawing.Size(162, 28);
      this.time2.TabIndex = 26;
      // 
      // time4
      // 
      this.time4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.time4.ForeColor = System.Drawing.Color.NavajoWhite;
      this.time4.Location = new System.Drawing.Point(275, 244);
      this.time4.Name = "time4";
      this.time4.Size = new System.Drawing.Size(162, 28);
      this.time4.TabIndex = 27;
      // 
      // time5
      // 
      this.time5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.time5.ForeColor = System.Drawing.Color.NavajoWhite;
      this.time5.Location = new System.Drawing.Point(275, 291);
      this.time5.Name = "time5";
      this.time5.Size = new System.Drawing.Size(162, 28);
      this.time5.TabIndex = 28;
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(812, 238);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(159, 305);
      this.dataGridView1.TabIndex = 29;
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.Black;
      this.button2.FlatAppearance.BorderSize = 0;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button2.ForeColor = System.Drawing.Color.IndianRed;
      this.button2.Location = new System.Drawing.Point(462, 275);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(324, 50);
      this.button2.TabIndex = 30;
      this.button2.Text = "Открыть";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click_1);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.Filter = "Excel|*.xlsx";
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(613, 244);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 21);
      this.comboBox1.TabIndex = 31;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label6.ForeColor = System.Drawing.Color.NavajoWhite;
      this.label6.Location = new System.Drawing.Point(459, 238);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(139, 28);
      this.label6.TabIndex = 32;
      this.label6.Text = "Выбрать лист";
      // 
      // label7
      // 
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label7.ForeColor = System.Drawing.Color.NavajoWhite;
      this.label7.Location = new System.Drawing.Point(228, 75);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(228, 28);
      this.label7.TabIndex = 33;
      this.label7.Text = "Время в микросекундах";
      this.label7.Click += new System.EventHandler(this.label7_Click);
      // 
      // label8
      // 
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label8.ForeColor = System.Drawing.SystemColors.Control;
      this.label8.Location = new System.Drawing.Point(458, 197);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(295, 29);
      this.label8.TabIndex = 34;
      this.label8.Text = "Генерировать массив чисел от";
      // 
      // startNumber
      // 
      this.startNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.startNumber.Location = new System.Drawing.Point(753, 197);
      this.startNumber.Name = "startNumber";
      this.startNumber.Size = new System.Drawing.Size(101, 29);
      this.startNumber.TabIndex = 35;
      // 
      // label9
      // 
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label9.ForeColor = System.Drawing.SystemColors.Control;
      this.label9.Location = new System.Drawing.Point(866, 197);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(47, 26);
      this.label9.TabIndex = 36;
      this.label9.Text = "до";
      // 
      // finishNumber
      // 
      this.finishNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.finishNumber.Location = new System.Drawing.Point(908, 197);
      this.finishNumber.Name = "finishNumber";
      this.finishNumber.Size = new System.Drawing.Size(101, 29);
      this.finishNumber.TabIndex = 37;
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.Black;
      this.button3.FlatAppearance.BorderSize = 0;
      this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button3.ForeColor = System.Drawing.Color.IndianRed;
      this.button3.Location = new System.Drawing.Point(796, 15);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(213, 47);
      this.button3.TabIndex = 44;
      this.button3.Text = "Главное меню";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new System.EventHandler(this.button3_Click_1);
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.ForeColor = System.Drawing.Color.White;
      this.label10.Location = new System.Drawing.Point(344, 9);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(242, 47);
      this.label10.TabIndex = 43;
      this.label10.Text = "Сортировка\r\n";
      // 
      // Sort
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.DarkRed;
      this.ClientSize = new System.Drawing.Size(1021, 727);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.finishNumber);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.startNumber);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.time5);
      this.Controls.Add(this.time4);
      this.Controls.Add(this.time2);
      this.Controls.Add(this.time3);
      this.Controls.Add(this.time1);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.defaultArrayButton);
      this.Controls.Add(this.SizeGenerateArray);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.start);
      this.Controls.Add(this.randomArrayButton);
      this.Controls.Add(this.DownCheck);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.UpCheck);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.result);
      this.Controls.Add(this.BubbleCheck);
      this.Controls.Add(this.BogoCheck);
      this.Controls.Add(this.ShakerCheck);
      this.Controls.Add(this.FastCheck);
      this.Controls.Add(this.InsertCheck);
      this.Controls.Add(this.button1);
      this.Name = "Sort";
      this.Text = "Сортировки";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private Button button1;
        private CheckBox InsertCheck;
        private CheckBox FastCheck;
        private CheckBox ShakerCheck;
        private CheckBox BogoCheck;
        private CheckBox BubbleCheck;
        private Label result;
        private Label label2;
        private RadioButton UpCheck;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private RadioButton DownCheck;
        private Button randomArrayButton;
        private Label label1;
        private Label start;
        private TextBox SizeGenerateArray;
        private Button defaultArrayButton;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label time1;
        private Label time3;
        private Label time2;
        private Label time4;
        private Label time5;
        private DataGridView dataGridView1;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private ComboBox comboBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox startNumber;
        private Label label9;
        private TextBox finishNumber;
    private Button button3;
    private Label label10;
  }
}

