namespace OOP_C__lab1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            createRoomButton = new Button();
            label1 = new Label();
            lengthTextBox = new TextBox();
            widthTextBox = new TextBox();
            ceilingHeightTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numberOfWindowsTextBox = new TextBox();
            calculateAreaButton = new Button();
            calculateVolumButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // createRoomButton
            // 
            createRoomButton.Location = new Point(448, 232);
            createRoomButton.Name = "createRoomButton";
            createRoomButton.Size = new Size(100, 34);
            createRoomButton.TabIndex = 1;
            createRoomButton.Text = "Створити";
            createRoomButton.UseVisualStyleBackColor = true;
            createRoomButton.Click += createRoomButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(410, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 21);
            label1.TabIndex = 3;
            label1.Text = "Інформація про кімнату";
            // 
            // lengthTextBox
            // 
            lengthTextBox.Location = new Point(448, 86);
            lengthTextBox.Name = "lengthTextBox";
            lengthTextBox.Size = new Size(100, 23);
            lengthTextBox.TabIndex = 4;
            // 
            // widthTextBox
            // 
            widthTextBox.Location = new Point(448, 42);
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(100, 23);
            widthTextBox.TabIndex = 5;
            // 
            // ceilingHeightTextBox
            // 
            ceilingHeightTextBox.Location = new Point(448, 135);
            ceilingHeightTextBox.Name = "ceilingHeightTextBox";
            ceilingHeightTextBox.Size = new Size(100, 23);
            ceilingHeightTextBox.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.clock_14087550__1_;
            pictureBox1.Location = new Point(90, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(385, 89);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 8;
            label2.Text = "Довжина";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 45);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 9;
            label3.Text = "Ширина";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 138);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "Висота";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(354, 192);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 12;
            label5.Text = "Кількість вікон";
            // 
            // numberOfWindowsTextBox
            // 
            numberOfWindowsTextBox.Location = new Point(448, 189);
            numberOfWindowsTextBox.Name = "numberOfWindowsTextBox";
            numberOfWindowsTextBox.Size = new Size(100, 23);
            numberOfWindowsTextBox.TabIndex = 11;
            // 
            // calculateAreaButton
            // 
            calculateAreaButton.Location = new Point(48, 232);
            calculateAreaButton.Name = "calculateAreaButton";
            calculateAreaButton.Size = new Size(100, 34);
            calculateAreaButton.TabIndex = 13;
            calculateAreaButton.Text = "Площа";
            calculateAreaButton.UseVisualStyleBackColor = true;
            calculateAreaButton.Click += calculateAreaButton_Click;
            // 
            // calculateVolumButton
            // 
            calculateVolumButton.Location = new Point(221, 232);
            calculateVolumButton.Name = "calculateVolumButton";
            calculateVolumButton.Size = new Size(100, 34);
            calculateVolumButton.TabIndex = 14;
            calculateVolumButton.Text = "Об'єм";
            calculateVolumButton.UseVisualStyleBackColor = true;
            calculateVolumButton.Click += calculateVolumButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 309);
            Controls.Add(calculateVolumButton);
            Controls.Add(calculateAreaButton);
            Controls.Add(label5);
            Controls.Add(numberOfWindowsTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(ceilingHeightTextBox);
            Controls.Add(widthTextBox);
            Controls.Add(lengthTextBox);
            Controls.Add(label1);
            Controls.Add(createRoomButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Кімната";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button createRoomButton;
        private Label label1;
        private TextBox lengthTextBox;
        private TextBox widthTextBox;
        private TextBox ceilingHeightTextBox;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox numberOfWindowsTextBox;
        private Button calculateAreaButton;
        private Button calculateVolumButton;
    }
}