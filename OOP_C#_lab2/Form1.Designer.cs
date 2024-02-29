namespace OOP_C__lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxRows = new TextBox();
            textBoxCols = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonCreate = new Button();
            textBoxMin = new TextBox();
            textBoxMax = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            labelWithoutNegetivRowsSum = new Label();
            labelMaxParallelDiagonalSum = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxRows
            // 
            textBoxRows.Location = new Point(105, 42);
            textBoxRows.Name = "textBoxRows";
            textBoxRows.Size = new Size(100, 23);
            textBoxRows.TabIndex = 0;
            // 
            // textBoxCols
            // 
            textBoxCols.Location = new Point(105, 87);
            textBoxCols.Name = "textBoxCols";
            textBoxCols.Size = new Size(100, 23);
            textBoxCols.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "К-сть рядків";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 90);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 3;
            label2.Text = "К-сть стовпців";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(169, 21);
            label3.TabIndex = 4;
            label3.Text = "Параметри матриці:";
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(13, 132);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(192, 43);
            buttonCreate.TabIndex = 5;
            buttonCreate.Text = "Створити матрицю";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // textBoxMin
            // 
            textBoxMin.Location = new Point(477, 42);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.Size = new Size(100, 23);
            textBoxMin.TabIndex = 6;
            // 
            // textBoxMax
            // 
            textBoxMax.Location = new Point(477, 82);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new Size(100, 23);
            textBoxMax.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(287, 45);
            label4.Name = "label4";
            label4.Size = new Size(184, 15);
            label4.TabIndex = 8;
            label4.Text = "Мінімальне значення елементів";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(275, 85);
            label5.Name = "label5";
            label5.Size = new Size(196, 15);
            label5.TabIndex = 9;
            label5.Text = "Максимальне значення елементів";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 321);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(565, 244);
            dataGridView1.TabIndex = 10;
            // 
            // labelWithoutNegetivRowsSum
            // 
            labelWithoutNegetivRowsSum.AutoSize = true;
            labelWithoutNegetivRowsSum.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelWithoutNegetivRowsSum.Location = new Point(13, 199);
            labelWithoutNegetivRowsSum.Name = "labelWithoutNegetivRowsSum";
            labelWithoutNegetivRowsSum.Size = new Size(439, 17);
            labelWithoutNegetivRowsSum.TabIndex = 11;
            labelWithoutNegetivRowsSum.Text = "Сума елементів в тих стовпцях, які не містять відємних елементів:";
            // 
            // labelMaxParallelDiagonalSum
            // 
            labelMaxParallelDiagonalSum.AutoSize = true;
            labelMaxParallelDiagonalSum.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMaxParallelDiagonalSum.Location = new Point(12, 279);
            labelMaxParallelDiagonalSum.Name = "labelMaxParallelDiagonalSum";
            labelMaxParallelDiagonalSum.Size = new Size(486, 17);
            labelMaxParallelDiagonalSum.TabIndex = 12;
            labelMaxParallelDiagonalSum.Text = "Максимум із суми елементів діагоналей, паралельних головній діагоналі:\r\n";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 219);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 574);
            Controls.Add(textBox1);
            Controls.Add(labelMaxParallelDiagonalSum);
            Controls.Add(labelWithoutNegetivRowsSum);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxMax);
            Controls.Add(textBoxMin);
            Controls.Add(buttonCreate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCols);
            Controls.Add(textBoxRows);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxRows;
        private TextBox textBoxCols;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonCreate;
        private TextBox textBoxMin;
        private TextBox textBoxMax;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private Label labelWithoutNegetivRowsSum;
        private Label labelMaxParallelDiagonalSum;
        private TextBox textBox1;
    }
}