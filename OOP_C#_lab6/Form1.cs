using System.Data;
using System.Windows.Forms;

namespace OOP_C__lab6
{
    public partial class Form1 : Form
    {
        private DogCollectionWrapper dogCollection;

        public enum SerializationFormat
        {
            Binary,
            Xml,
            Json
        }

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();

            dogCollection = new DogCollectionWrapper();
            GenderComboBox.Items.AddRange(new object[] { "Male", "Female" });
        }

        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();

            foreach (var dog in dogCollection)
            {
                dataGridView1.Rows.Add(dog.Alias, dog.Breed, dog.Gender, dog.Cost, dog.Age);
            }
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("Alias", "Alias");
            dataGridView1.Columns.Add("BreedColumn", "Breed");
            dataGridView1.Columns.Add("GenderColumn", "Gender");
            dataGridView1.Columns.Add("CostColumn", "Cost");
            dataGridView1.Columns.Add("AgeColumn", "Age");
        }

        private void SaveCollection(string folderPath, string fileName, SerializationFormat format)
        {
            try
            {
                switch (format)
                {
                    case SerializationFormat.Binary:
                        dogCollection.SaveToBinaryFile(Path.Combine(folderPath, fileName));
                        break;
                    case SerializationFormat.Xml:
                        dogCollection.SaveToXmlFile(Path.Combine(folderPath, fileName));
                        break;
                    case SerializationFormat.Json:
                        dogCollection.SaveToJsonFile(Path.Combine(folderPath, fileName));
                        break;
                }
                MessageBox.Show("Collection saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving collection: {ex.Message}");
            }
        }

        private void AddElementButton_Click(object sender, EventArgs e)
        {
            try
            {
                Gender gender;
                double cost;
                int age;

                if (GenderComboBox.SelectedItem != null)
                {
                    string selectedGender = GenderComboBox.SelectedItem.ToString();
                    gender = selectedGender == "Male" ? Gender.Male : Gender.Female;
                }
                else
                {
                    MessageBox.Show("Please select gender.");
                    return;
                }

                if (!double.TryParse(CostTextBox.Text, out cost))
                {
                    MessageBox.Show("Invalid cost value. Please enter a valid number.");
                    return;
                }

                if (!int.TryParse(AgeTextBox.Text, out age))
                {
                    MessageBox.Show("Invalid age value. Please enter a valid number.");
                    return;
                }

                Dog newDog = new Dog(AliasTextBox.Text, BreedTextBox.Text, gender, cost, age);

                dogCollection.Add(newDog);
                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteElementButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                dogCollection.RomoveByIndex(rowIndex);

                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void SavaCollectionButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog1.SelectedPath;

                saveFileDialog1.Filter = "Binary files (*.bin)|*.bin|XML files (*.xml)|*.xml|JSON files (*.json)|*.json|All files (*.*)|*.*";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog1.FileName;

                    SerializationFormat format;

                    string fileExtension = Path.GetExtension(saveFileDialog1.FileName);

                    if (fileExtension.Equals(".bin", StringComparison.OrdinalIgnoreCase))
                        format = SerializationFormat.Binary;
                    else if (fileExtension.Equals(".xml", StringComparison.OrdinalIgnoreCase))
                        format = SerializationFormat.Xml;
                    else
                        format = SerializationFormat.Json;

                    SaveCollection(folderPath, fileName, format);
                }
            }
        }

        private void LoadFromFileButton_Click(object sender, EventArgs e)
        {
            dogCollection.Clear();

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Binary files (*.bin)|*.bin|XML files (*.xml)|*.xml|JSON files (*.json)|*.json|All files (*.*)|*.*";

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;

                string fileExtension = Path.GetExtension(selectedFileName);

                if (fileExtension.Equals(".bin", StringComparison.OrdinalIgnoreCase))
                {
                    dogCollection.LoadFromBinaryFile(selectedFileName);
                }
                else if (fileExtension.Equals(".xml", StringComparison.OrdinalIgnoreCase))
                {
                    dogCollection.LoadFromXmlFile(selectedFileName);
                }
                else if (fileExtension.Equals(".json", StringComparison.OrdinalIgnoreCase))
                {
                    dogCollection.LoadFromJsonFile(selectedFileName);
                }
                else
                {
                    MessageBox.Show("Unsupported file format.");
                }
            }

            UpdateDataGridView();
        }
    }
}
