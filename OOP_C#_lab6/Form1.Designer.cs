namespace OOP_C__lab6
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
            dataGridView1 = new DataGridView();
            AliasTextBox = new TextBox();
            BreedTextBox = new TextBox();
            CostTextBox = new TextBox();
            AgeTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            GenderComboBox = new ComboBox();
            AddElementButton = new Button();
            DeleteElementButton = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            saveFileDialog1 = new SaveFileDialog();
            SavaCollectionButton = new Button();
            LoadFromFileButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(355, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(584, 292);
            dataGridView1.TabIndex = 0;
            // 
            // AliasTextBox
            // 
            AliasTextBox.Location = new Point(163, 34);
            AliasTextBox.Name = "AliasTextBox";
            AliasTextBox.Size = new Size(137, 23);
            AliasTextBox.TabIndex = 1;
            // 
            // BreedTextBox
            // 
            BreedTextBox.Location = new Point(163, 63);
            BreedTextBox.Name = "BreedTextBox";
            BreedTextBox.Size = new Size(137, 23);
            BreedTextBox.TabIndex = 2;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(163, 121);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(137, 23);
            CostTextBox.TabIndex = 4;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(163, 150);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(137, 23);
            AgeTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(626, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 6;
            label1.Text = "Список";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 37);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 7;
            label2.Text = "Кличка";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 66);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 8;
            label3.Text = "Порода";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 95);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 9;
            label4.Text = "Стать";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 124);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 10;
            label5.Text = "Ціна";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(119, 153);
            label6.Name = "label6";
            label6.Size = new Size(23, 15);
            label6.TabIndex = 11;
            label6.Text = "Вік";
            // 
            // GenderComboBox
            // 
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Location = new Point(163, 92);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(137, 23);
            GenderComboBox.TabIndex = 12;
            // 
            // AddElementButton
            // 
            AddElementButton.Location = new Point(12, 194);
            AddElementButton.Name = "AddElementButton";
            AddElementButton.Size = new Size(130, 49);
            AddElementButton.TabIndex = 13;
            AddElementButton.Text = "Додати";
            AddElementButton.UseVisualStyleBackColor = true;
            AddElementButton.Click += AddElementButton_Click;
            // 
            // DeleteElementButton
            // 
            DeleteElementButton.Location = new Point(170, 194);
            DeleteElementButton.Name = "DeleteElementButton";
            DeleteElementButton.Size = new Size(130, 49);
            DeleteElementButton.TabIndex = 14;
            DeleteElementButton.Text = "Видалити";
            DeleteElementButton.UseVisualStyleBackColor = true;
            DeleteElementButton.Click += DeleteElementButton_Click;
            // 
            // SavaCollectionButton
            // 
            SavaCollectionButton.Location = new Point(170, 277);
            SavaCollectionButton.Name = "SavaCollectionButton";
            SavaCollectionButton.Size = new Size(130, 49);
            SavaCollectionButton.TabIndex = 15;
            SavaCollectionButton.Text = "Зберегти";
            SavaCollectionButton.UseVisualStyleBackColor = true;
            SavaCollectionButton.Click += SavaCollectionButton_Click;
            // 
            // LoadFromFileButton
            // 
            LoadFromFileButton.Location = new Point(12, 277);
            LoadFromFileButton.Name = "LoadFromFileButton";
            LoadFromFileButton.Size = new Size(130, 49);
            LoadFromFileButton.TabIndex = 16;
            LoadFromFileButton.Text = "Завантажити";
            LoadFromFileButton.UseVisualStyleBackColor = true;
            LoadFromFileButton.Click += LoadFromFileButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 342);
            Controls.Add(LoadFromFileButton);
            Controls.Add(SavaCollectionButton);
            Controls.Add(DeleteElementButton);
            Controls.Add(AddElementButton);
            Controls.Add(GenderComboBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AgeTextBox);
            Controls.Add(CostTextBox);
            Controls.Add(BreedTextBox);
            Controls.Add(AliasTextBox);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox AliasTextBox;
        private TextBox BreedTextBox;
        private TextBox CostTextBox;
        private TextBox AgeTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox GenderComboBox;
        private Button AddElementButton;
        private Button DeleteElementButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button SavaCollectionButton;
        private Button LoadFromFileButton;
    }
}
