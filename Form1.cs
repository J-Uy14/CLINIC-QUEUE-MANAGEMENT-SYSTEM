namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private int queueCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddToQueue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbPatientType.SelectedItem == null)
            {
                MessageBox.Show("Please select a patient type.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isValidAge = int.TryParse(textBox2.Text, out int age);
            if (!isValidAge || age <= 0)
            {
                MessageBox.Show("Please enter a valid age.", "Invalid Age",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            queueCounter++;
            string queueNumber = "Q" + queueCounter.ToString("D3");
            string patientType = cmbPatientType.SelectedItem.ToString()!;
            string priority = patientType switch
            {
                "Emergency" => "EMERGENCY",
                "Senior" => "SENIOR PRIORITY",
                "Pregnant" => "PRIORITY",
                _ => "REGULAR",
            };

            lblQueueNumberOutput.Text = queueNumber;
            lblPatientTypeOutput.Text = patientType;
            lblPriorityOutput.Text = priority;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            cmbPatientType.SelectedIndex = -1;

            lblQueueNumberOutput.Text = "";
            lblPatientTypeOutput.Text = "";
            lblPriorityOutput.Text = "";

            textBox1.Focus();
        }
    }
}
