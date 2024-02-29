using System;
using System.Data;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace OOP_C__lab2
{
    public partial class Form1 : Form
    {
        CharacteristicMatrix matrix;
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(608, 231);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = int.Parse(textBoxRows.Text);
                int cols = int.Parse(textBoxCols.Text);
                matrix = new CharacteristicMatrix(rows, cols);
                int max = int.Parse(textBoxMax.Text);
                int min = int.Parse(textBoxMin.Text);
                matrix.FillElementsRandom(max, min);

                string concatenatedArray = string.Join(",", matrix.WithoutNegetivRowsSum);

                textBox1.Text = concatenatedArray;

                labelMaxParallelDiagonalSum.Text = "Максимум із суми елементів діагоналей, паралельних головній діагоналі: " +
                    matrix.MaxParallelDiagonalSum().ToString();

                this.Size = new Size(601, 613);
                Print(matrix);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неправельно введені дані: {ex.Message}");
            }
        }

        private void Print(CharacteristicMatrix matrix)
        {

            DataTable dt = new DataTable();
            int columns = matrix.ColCount;
            int rows = matrix.RowCount;
            for (int i = 0; i < columns; i++)
            {
                dt.Columns.Add(i.ToString(), typeof(double));
            }
            for (int row = 0; row < rows; row++)
            {
                DataRow dr = dt.NewRow();
                for (int col = 0; col < columns; col++)
                {
                    dr[col] = matrix[row, col];
                }
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt.DefaultView;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
        }
    }
}