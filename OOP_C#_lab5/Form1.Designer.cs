namespace OOP_C__lab5
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
            groupBox1 = new GroupBox();
            createCollectionButton = new Button();
            label1 = new Label();
            collectionSizeTextBox = new TextBox();
            groupBox2 = new GroupBox();
            sortedListCheckBox = new CheckBox();
            hashtableCheckBox = new CheckBox();
            addElementButton = new Button();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            removeElementButton = new Button();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(createCollectionButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(collectionSizeTextBox);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Створення колекції";
            // 
            // createCollectionButton
            // 
            createCollectionButton.Location = new Point(260, 76);
            createCollectionButton.Name = "createCollectionButton";
            createCollectionButton.Size = new Size(147, 31);
            createCollectionButton.TabIndex = 3;
            createCollectionButton.Text = "Створити";
            createCollectionButton.UseVisualStyleBackColor = true;
            createCollectionButton.Click += createCollectionButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 84);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 2;
            label1.Text = "Кількість елементів";
            // 
            // collectionSizeTextBox
            // 
            collectionSizeTextBox.Location = new Point(132, 81);
            collectionSizeTextBox.Name = "collectionSizeTextBox";
            collectionSizeTextBox.Size = new Size(100, 23);
            collectionSizeTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(sortedListCheckBox);
            groupBox2.Controls.Add(hashtableCheckBox);
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(401, 48);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Тип колекції";
            // 
            // sortedListCheckBox
            // 
            sortedListCheckBox.AutoSize = true;
            sortedListCheckBox.Location = new Point(95, 22);
            sortedListCheckBox.Name = "sortedListCheckBox";
            sortedListCheckBox.Size = new Size(78, 19);
            sortedListCheckBox.TabIndex = 1;
            sortedListCheckBox.Text = "SortedList";
            sortedListCheckBox.UseVisualStyleBackColor = true;
            sortedListCheckBox.CheckedChanged += sortedListCheckBox_CheckedChanged;
            // 
            // hashtableCheckBox
            // 
            hashtableCheckBox.AutoSize = true;
            hashtableCheckBox.Location = new Point(6, 22);
            hashtableCheckBox.Name = "hashtableCheckBox";
            hashtableCheckBox.Size = new Size(79, 19);
            hashtableCheckBox.TabIndex = 0;
            hashtableCheckBox.Text = "Hashtable";
            hashtableCheckBox.UseVisualStyleBackColor = true;
            hashtableCheckBox.CheckedChanged += hashtableCheckBox_CheckedChanged;
            // 
            // addElementButton
            // 
            addElementButton.Location = new Point(12, 145);
            addElementButton.Name = "addElementButton";
            addElementButton.Size = new Size(151, 31);
            addElementButton.TabIndex = 1;
            addElementButton.Text = "Додати елемент";
            addElementButton.UseVisualStyleBackColor = true;
            addElementButton.Click += addElementButton_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(433, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(271, 155);
            dataGridView1.TabIndex = 3;
            // 
            // removeElementButton
            // 
            removeElementButton.Location = new Point(12, 182);
            removeElementButton.Name = "removeElementButton";
            removeElementButton.Size = new Size(151, 31);
            removeElementButton.TabIndex = 4;
            removeElementButton.Text = "Видалити елемент";
            removeElementButton.UseVisualStyleBackColor = true;
            removeElementButton.Click += removeElementButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 187);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 234);
            Controls.Add(textBox1);
            Controls.Add(removeElementButton);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(addElementButton);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Колекції";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button createCollectionButton;
        private Label label1;
        private TextBox collectionSizeTextBox;
        private GroupBox groupBox2;
        private CheckBox sortedListCheckBox;
        private CheckBox hashtableCheckBox;
        private Button addElementButton;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Button removeElementButton;
        private TextBox textBox1;
    }
}
