
using System.Windows.Forms;

namespace Sem3
{
    partial class SLAU
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SizeGenerateArray = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FinishGenerate = new System.Windows.Forms.TextBox();
            this.StartGenerate = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Methods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GaussCheck = new System.Windows.Forms.CheckBox();
            this.KramerCheck = new System.Windows.Forms.CheckBox();
            this.JordanCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxE = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label3.Location = new System.Drawing.Point(194, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Матрица";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(511, 354);
            this.dataGridView1.TabIndex = 29;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel|*.xlsx";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(12, 537);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 50);
            this.button2.TabIndex = 38;
            this.button2.Text = "Матрица из Excel";
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
            this.button3.Location = new System.Drawing.Point(12, 593);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 50);
            this.button3.TabIndex = 39;
            this.button3.Text = "Случайная матрица";
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
            this.button4.Location = new System.Drawing.Point(12, 481);
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
            this.SizeGenerateArray.Location = new System.Drawing.Point(93, 652);
            this.SizeGenerateArray.Name = "SizeGenerateArray";
            this.SizeGenerateArray.Size = new System.Drawing.Size(165, 29);
            this.SizeGenerateArray.TabIndex = 41;
            this.SizeGenerateArray.Text = "3";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 652);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 42;
            this.label1.Text = "Размер";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(2, 685);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 43;
            this.label2.Text = "Чисел от";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(158, 684);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 28);
            this.label4.TabIndex = 45;
            this.label4.Text = "до";
            // 
            // FinishGenerate
            // 
            this.FinishGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinishGenerate.Location = new System.Drawing.Point(199, 685);
            this.FinishGenerate.Name = "FinishGenerate";
            this.FinishGenerate.Size = new System.Drawing.Size(59, 29);
            this.FinishGenerate.TabIndex = 46;
            this.FinishGenerate.Text = "10";
            // 
            // StartGenerate
            // 
            this.StartGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGenerate.Location = new System.Drawing.Point(93, 685);
            this.StartGenerate.Name = "StartGenerate";
            this.StartGenerate.Size = new System.Drawing.Size(59, 29);
            this.StartGenerate.TabIndex = 47;
            this.StartGenerate.Text = "1";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.IndianRed;
            this.button5.Location = new System.Drawing.Point(548, 170);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 62);
            this.button5.TabIndex = 55;
            this.button5.Text = "Создать матрицу";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.IndianRed;
            this.button6.Location = new System.Drawing.Point(952, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(219, 47);
            this.button6.TabIndex = 60;
            this.button6.Text = "Главное меню";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(22, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(849, 46);
            this.label10.TabIndex = 59;
            this.label10.Text = "Системы линейных алгебраических уравнений";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Methods});
            this.dataGridView2.Location = new System.Drawing.Point(281, 481);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(751, 233);
            this.dataGridView2.TabIndex = 61;
            // 
            // Methods
            // 
            this.Methods.HeaderText = "Методы";
            this.Methods.Name = "Methods";
            this.Methods.ReadOnly = true;
            // 
            // InputN
            // 
            this.InputN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputN.Location = new System.Drawing.Point(642, 121);
            this.InputN.Name = "InputN";
            this.InputN.Size = new System.Drawing.Size(63, 29);
            this.InputN.TabIndex = 62;
            this.InputN.Text = "3";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label5.Location = new System.Drawing.Point(543, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 28);
            this.label5.TabIndex = 63;
            this.label5.Text = "Размер";
            // 
            // GaussCheck
            // 
            this.GaussCheck.AutoSize = true;
            this.GaussCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GaussCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GaussCheck.Location = new System.Drawing.Point(548, 263);
            this.GaussCheck.Name = "GaussCheck";
            this.GaussCheck.Size = new System.Drawing.Size(178, 28);
            this.GaussCheck.TabIndex = 66;
            this.GaussCheck.Text = "Методом Гаусса";
            this.GaussCheck.UseMnemonic = false;
            this.GaussCheck.UseVisualStyleBackColor = true;
            // 
            // KramerCheck
            // 
            this.KramerCheck.AutoSize = true;
            this.KramerCheck.Cursor = System.Windows.Forms.Cursors.Cross;
            this.KramerCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KramerCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.KramerCheck.Location = new System.Drawing.Point(548, 331);
            this.KramerCheck.Name = "KramerCheck";
            this.KramerCheck.Size = new System.Drawing.Size(196, 28);
            this.KramerCheck.TabIndex = 65;
            this.KramerCheck.Text = "Методом Крамера";
            this.KramerCheck.UseVisualStyleBackColor = true;
            // 
            // JordanCheck
            // 
            this.JordanCheck.AutoSize = true;
            this.JordanCheck.Cursor = System.Windows.Forms.Cursors.Cross;
            this.JordanCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JordanCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.JordanCheck.Location = new System.Drawing.Point(548, 297);
            this.JordanCheck.Name = "JordanCheck";
            this.JordanCheck.Size = new System.Drawing.Size(264, 28);
            this.JordanCheck.TabIndex = 64;
            this.JordanCheck.Text = "Методом Жордана Гаусса";
            this.JordanCheck.UseVisualStyleBackColor = true;
            this.JordanCheck.CheckedChanged += new System.EventHandler(this.TrapezeCheck_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(548, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 37);
            this.button1.TabIndex = 67;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label6.Location = new System.Drawing.Point(543, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 28);
            this.label6.TabIndex = 69;
            this.label6.Text = "Кол-во знаков после запятой";
            // 
            // textBoxE
            // 
            this.textBoxE.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.textBoxE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxE.Location = new System.Drawing.Point(867, 432);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(63, 29);
            this.textBoxE.TabIndex = 68;
            this.textBoxE.Text = "3";
            this.textBoxE.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SLAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1231, 718);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GaussCheck);
            this.Controls.Add(this.KramerCheck);
            this.Controls.Add(this.JordanCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InputN);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.StartGenerate);
            this.Controls.Add(this.FinishGenerate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SizeGenerateArray);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "SLAU";
            this.Text = "Сортировки";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialog1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox SizeGenerateArray;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox FinishGenerate;
        private TextBox StartGenerate;
        private Button button5;
        private Button button6;
        private Label label10;
    private DataGridView dataGridView2;
    private DataGridViewTextBoxColumn Methods;
    private TextBox InputN;
    private Label label5;
    private CheckBox GaussCheck;
    private CheckBox KramerCheck;
    private CheckBox JordanCheck;
    private Button button1;
    private Label label6;
    private TextBox textBoxE;
  }
}

