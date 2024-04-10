using System.Collections;
using System.Windows.Forms;

namespace OOP_C__lab5
{
    public partial class Form1 : Form
    {
        private BStringCollection bStringCollection;

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void hashtableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hashtableCheckBox.Checked)
            {
                sortedListCheckBox.Checked = false;
            }
        }

        private void sortedListCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sortedListCheckBox.Checked)
            {
                hashtableCheckBox.Checked = false;
            }
        }

        private void createCollectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(collectionSizeTextBox.Text))
                    throw new ArgumentException("Enter the size of collection.");

                int size = 0;

                if (Convert.ToInt32(collectionSizeTextBox.Text) > 0)
                {
                    size = Convert.ToInt32(collectionSizeTextBox.Text);
                }
                else
                {
                    throw new Exception("Size must be a positive integer.");
                }

                if (hashtableCheckBox.Checked)
                {
                    bStringCollection = new BStringCollectionHashtable(size);
                }
                else if (sortedListCheckBox.Checked)
                {
                    bStringCollection = new BStringCollectionSortedList(size);
                }
                else
                {
                    throw new ArgumentException("Please select a collection type.");
                }
                UpdateDataGridView(bStringCollection.GetCollection());
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addElementButton_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox2.Text;

                if (string.IsNullOrEmpty(input))
                    throw new ArgumentException("Please enter a valid bit string.");

                BitString bitString = new BitString(input);

                if (bStringCollection != null)
                {
                    bStringCollection.Add(bitString);
                    UpdateDataGridView(bStringCollection.GetCollection());
                }
                else
                {
                    MessageBox.Show("Please create a collection first.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void removeElementButton_Click(object sender, EventArgs e)
        {
            try
            {
                string input = textBox2.Text;

                if (string.IsNullOrEmpty(input))
                    throw new ArgumentException("Please enter a valid bit string.");

                BitString bitString = new BitString(input);

                if (bStringCollection != null)
                {
                    bStringCollection.Remove(bitString);
                    UpdateDataGridView(bStringCollection.GetCollection());
                }
                else
                {
                    MessageBox.Show("Please create a collection first.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("BitString", "Bit String");
            dataGridView1.Columns.Add("DecimalValue", "Decimal Value");
        }

        private void UpdateDataGridView(IEnumerable<BitString> collection)
        {
            dataGridView1.Rows.Clear();
            foreach (BitString bitString in collection)
            {
                dataGridView1.Rows.Add(bitString.ToString(), bitString.ToDecimal());
            }
        }
    }
}
