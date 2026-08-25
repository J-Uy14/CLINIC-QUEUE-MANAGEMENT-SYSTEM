namespace WinFormsApp1
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

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
            lblTitle = new Label();
            lblName = new Label();
            textBox1 = new TextBox();
            lblAge = new Label();
            textBox2 = new TextBox();
            lblReason = new Label();
            textBox3 = new TextBox();
            lblType = new Label();
            cmbPatientType = new ComboBox();
            btnAddToQueue = new Button();
            btnClear = new Button();
            grpOutput = new GroupBox();
            lblQNLabel = new Label();
            lblQueueNumberOutput = new Label();
            lblPTLabel = new Label();
            lblPatientTypeOutput = new Label();
            lblPrLabel = new Label();
            lblPriorityOutput = new Label();
            grpOutput.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(420, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Barangay Apokon Clinic - Queue Management";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.Location = new Point(12, 57);
            lblName.Name = "lblName";
            lblName.Size = new Size(120, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Patient Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 54);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Patient Name";
            textBox1.Size = new Size(280, 23);
            textBox1.TabIndex = 2;
            // 
            // lblAge
            // 
            lblAge.Location = new Point(12, 92);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(120, 23);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 89);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Age";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // lblReason
            // 
            lblReason.Location = new Point(12, 127);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(120, 23);
            lblReason.TabIndex = 5;
            lblReason.Text = "Reason for Visit:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(150, 124);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Reason for Visit";
            textBox3.Size = new Size(280, 23);
            textBox3.TabIndex = 6;
            // 
            // lblType
            // 
            lblType.Location = new Point(12, 162);
            lblType.Name = "lblType";
            lblType.Size = new Size(120, 23);
            lblType.TabIndex = 7;
            lblType.Text = "Patient Type:";
            // 
            // cmbPatientType
            // 
            cmbPatientType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatientType.Items.AddRange(new object[] { "Regular", "Senior", "Pregnant", "Emergency" });
            cmbPatientType.Location = new Point(150, 159);
            cmbPatientType.Name = "cmbPatientType";
            cmbPatientType.Size = new Size(200, 23);
            cmbPatientType.TabIndex = 8;
            // 
            // btnAddToQueue
            // 
            btnAddToQueue.Location = new Point(150, 200);
            btnAddToQueue.Name = "btnAddToQueue";
            btnAddToQueue.Size = new Size(140, 35);
            btnAddToQueue.TabIndex = 9;
            btnAddToQueue.Text = "ADD TO QUEUE";
            btnAddToQueue.Click += btnAddToQueue_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(300, 200);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 35);
            btnClear.TabIndex = 10;
            btnClear.Text = "CLEAR";
            btnClear.Click += btnClear_Click;
            // 
            // grpOutput
            // 
            grpOutput.Controls.Add(lblQNLabel);
            grpOutput.Controls.Add(lblQueueNumberOutput);
            grpOutput.Controls.Add(lblPTLabel);
            grpOutput.Controls.Add(lblPatientTypeOutput);
            grpOutput.Controls.Add(lblPrLabel);
            grpOutput.Controls.Add(lblPriorityOutput);
            grpOutput.Location = new Point(12, 255);
            grpOutput.Name = "grpOutput";
            grpOutput.Size = new Size(420, 150);
            grpOutput.TabIndex = 11;
            grpOutput.TabStop = false;
            grpOutput.Text = "Queue Result";
            // 
            // lblQNLabel
            // 
            lblQNLabel.Location = new Point(15, 30);
            lblQNLabel.Name = "lblQNLabel";
            lblQNLabel.Size = new Size(130, 23);
            lblQNLabel.TabIndex = 0;
            lblQNLabel.Text = "Queue Number:";
            // 
            // lblQueueNumberOutput
            // 
            lblQueueNumberOutput.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblQueueNumberOutput.Location = new Point(160, 30);
            lblQueueNumberOutput.Name = "lblQueueNumberOutput";
            lblQueueNumberOutput.Size = new Size(200, 25);
            lblQueueNumberOutput.TabIndex = 1;
            // 
            // lblPTLabel
            // 
            lblPTLabel.Location = new Point(15, 65);
            lblPTLabel.Name = "lblPTLabel";
            lblPTLabel.Size = new Size(130, 23);
            lblPTLabel.TabIndex = 2;
            lblPTLabel.Text = "Patient Type:";
            // 
            // lblPatientTypeOutput
            // 
            lblPatientTypeOutput.Location = new Point(160, 65);
            lblPatientTypeOutput.Name = "lblPatientTypeOutput";
            lblPatientTypeOutput.Size = new Size(200, 23);
            lblPatientTypeOutput.TabIndex = 3;
            // 
            // lblPrLabel
            // 
            lblPrLabel.Location = new Point(15, 100);
            lblPrLabel.Name = "lblPrLabel";
            lblPrLabel.Size = new Size(130, 23);
            lblPrLabel.TabIndex = 4;
            lblPrLabel.Text = "Priority:";
            // 
            // lblPriorityOutput
            // 
            lblPriorityOutput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPriorityOutput.Location = new Point(160, 100);
            lblPriorityOutput.Name = "lblPriorityOutput";
            lblPriorityOutput.Size = new Size(240, 23);
            lblPriorityOutput.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 420);
            Controls.Add(lblTitle);
            Controls.Add(lblName);
            Controls.Add(textBox1);
            Controls.Add(lblAge);
            Controls.Add(textBox2);
            Controls.Add(lblReason);
            Controls.Add(textBox3);
            Controls.Add(lblType);
            Controls.Add(cmbPatientType);
            Controls.Add(btnAddToQueue);
            Controls.Add(btnClear);
            Controls.Add(grpOutput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinic Queue Management System";
            grpOutput.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private TextBox textBox1;
        private Label lblAge;
        private TextBox textBox2;
        private Label lblReason;
        private TextBox textBox3;
        private Label lblType;
        private ComboBox cmbPatientType;
        private Button btnAddToQueue;
        private Button btnClear;
        private GroupBox grpOutput;
        private Label lblQNLabel;
        private Label lblQueueNumberOutput;
        private Label lblPTLabel;
        private Label lblPatientTypeOutput;
        private Label lblPrLabel;
        private Label lblPriorityOutput;
    }
}
