namespace OOP_C__lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text.Trim();
            string str2 = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(str1) || string.IsNullOrWhiteSpace(str2))
            {
                MessageBox.Show("Будь ласка, заповніть обидва поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!BitString.IsValidBitString(str1) || !BitString.IsValidBitString(str2))
            {
                MessageBox.Show("Введіть коректну бітову стрічку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BitString bs1 = new BitString(str1);
            BitString bs2 = new BitString(str2);

            BitString result = BitString.Add(bs1, bs2);

            textBox3.Text = result.ToString();
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text.Trim();
            string str2 = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(str1) || string.IsNullOrWhiteSpace(str2))
            {
                MessageBox.Show("Будь ласка, заповніть обидва поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!BitString.IsValidBitString(str1) || !BitString.IsValidBitString(str2))
            {
                MessageBox.Show("Введіть коректну бітову стрічку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BitString bs1 = new BitString(str1);
            BitString bs2 = new BitString(str2);

            bool isEqual = bs1.Equals(bs2);

            textBox3.Text = isEqual ? "Рівні" : "Не рівні";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.F1)
            {
                string str = textBox1.Text.Trim();

                if (!string.IsNullOrWhiteSpace(str) && BitString.IsValidBitString(str))
                {

                    BitString bs = new BitString(str);
                    bs.GetTwosComplement();

                    textBox1.Text = bs.ToString();

                    e.Handled = true;
                }
            }

            if (e.Shift && e.KeyCode == Keys.F2)
            {
                string str = textBox1.Text.Trim();

                if (!string.IsNullOrWhiteSpace(str) && BitString.IsValidBitString(str))
                {

                    BitString bs = new BitString(str);
                    int decimalValue = bs.ToDecimal();
                    MessageBox.Show($"Числове представлення бітової стрічки: {decimalValue}");

                    e.Handled = true;
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.F1)
            {
                string str = textBox2.Text.Trim();

                if (!string.IsNullOrWhiteSpace(str) && BitString.IsValidBitString(str))
                {

                    BitString bs = new BitString(str);
                    bs.GetTwosComplement();

                    textBox2.Text = bs.ToString();

                    e.Handled = true;
                }
            }

            if (e.Shift && e.KeyCode == Keys.F2)
            {
                string str = textBox2.Text.Trim();

                if (!string.IsNullOrWhiteSpace(str) && BitString.IsValidBitString(str))
                {

                    BitString bs = new BitString(str);
                    int decimalValue = bs.ToDecimal();
                    MessageBox.Show($"Числове представлення бітової стрічки: {decimalValue}");

                    e.Handled = true;
                }
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Shift && e.KeyCode == Keys.F1)
            {
                string str = textBox3.Text.Trim();

                if (!string.IsNullOrWhiteSpace(str) && BitString.IsValidBitString(str))
                {

                    BitString bs = new BitString(str);
                    bs.GetTwosComplement();

                    textBox3.Text = bs.ToString();

                    e.Handled = true;
                }
            }

            if (e.Shift && e.KeyCode == Keys.F2)
            {
                string str = textBox3.Text.Trim();

                if (!string.IsNullOrWhiteSpace(str) && BitString.IsValidBitString(str))
                {

                    BitString bs = new BitString(str);
                    int decimalValue = bs.ToDecimal();
                    MessageBox.Show($"Числове представлення бітової стрічки: {decimalValue}");

                    e.Handled = true;
                }
            }
        }

        
    }

}
