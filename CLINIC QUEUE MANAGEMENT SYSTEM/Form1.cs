using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLINIC_QUEUE_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        int queueNumber = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            queueNumber++;

            string qNum = "Q00" + queueNumber;

            string name = txtPatientName.Text;
            string type = cmbPatientType.Text;
            string priority = "";

            if (type == "Emergency")
            {
                priority = "EMERGENCY";
            }
            else if (type == "Senior")
            {
                priority = "SENIOR PRIORITY";
            }
            else if (type == "Pregnant")
            {
                priority = "PRIORITY";
            }
            else
            {
                priority = "REGULAR";
            }

            lblQueueOutput.Text = qNum;
            lblTypeOutput.Text = type;
            lblPriorityOutput.Text = priority;
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtPatientName.Clear();
            txtAge.Clear();
            txtReason.Clear();
            cmbPatientType.Text = "";

            lblQueueOutput.Text = "---";
            lblTypeOutput.Text = "---";
            lblPriorityOutput.Text = "---";
        }
    }
}
