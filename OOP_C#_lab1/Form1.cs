namespace OOP_C__lab1
{
    public partial class Form1 : Form
    {
        private Room currentRoom;

        public Form1()
        {
            InitializeComponent();
        }

        private void createRoomButton_Click(object sender, EventArgs e)
        {
            try
            {
                double width = Convert.ToDouble(widthTextBox.Text);
                double length = Convert.ToDouble(lengthTextBox.Text);
                double ceilingHeight = Convert.ToDouble(ceilingHeightTextBox.Text);
                int numberOfWindows = Convert.ToInt32(numberOfWindowsTextBox.Text);

                currentRoom = new Room(width, length, ceilingHeight, numberOfWindows);
                MessageBox.Show("ʳ����� ������ ��������!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� ��� �������� ������: {ex.Message}");
            }
        }

        private void calculateVolumButton_Click(object sender, EventArgs e)
        {
            if (currentRoom != null)
            {
                double volume = currentRoom.CalculateVolume();
                MessageBox.Show($"��'�� ������: {volume} ���.�");
            }
            else
            {
                MessageBox.Show("�������� ������� ������.");
            }
        }

        private void calculateAreaButton_Click(object sender, EventArgs e)
        {
            if (currentRoom != null)
            {
                double area = currentRoom.CalculateArea();
                MessageBox.Show($"����� ������: {area} ��.�");
            }
            else
            {
                MessageBox.Show("�������� ������� ������.");
            }
        }
    }
}