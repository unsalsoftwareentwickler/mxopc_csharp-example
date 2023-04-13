namespace MXOPCDeneme4
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
            labelAddressCombobox = new Label();
            cmbxTags = new ComboBox();
            txtTagAddress = new TextBox();
            label2 = new Label();
            cmbxValue = new ComboBox();
            txtTagReadedValue = new TextBox();
            label3 = new Label();
            btnWrite = new Button();
            btnRead = new Button();
            labelConn = new Label();
            labelCpu = new Label();
            labelValue = new Label();
            labelConnectionStatus = new Label();
            labelCpuType = new Label();
            txtValue = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelAddressCombobox
            // 
            labelAddressCombobox.AutoSize = true;
            labelAddressCombobox.Location = new Point(26, 20);
            labelAddressCombobox.Name = "labelAddressCombobox";
            labelAddressCombobox.Size = new Size(30, 15);
            labelAddressCombobox.TabIndex = 0;
            labelAddressCombobox.Text = "Tags";
            // 
            // cmbxTags
            // 
            cmbxTags.FormattingEnabled = true;
            cmbxTags.Location = new Point(26, 38);
            cmbxTags.Name = "cmbxTags";
            cmbxTags.Size = new Size(312, 23);
            cmbxTags.TabIndex = 1;
            cmbxTags.SelectedIndexChanged += cmbxTags_SelectedIndexChanged;
            // 
            // txtTagAddress
            // 
            txtTagAddress.Enabled = false;
            txtTagAddress.Location = new Point(26, 101);
            txtTagAddress.Name = "txtTagAddress";
            txtTagAddress.Size = new Size(142, 23);
            txtTagAddress.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 83);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 3;
            label2.Text = "Tag Address";
            // 
            // cmbxValue
            // 
            cmbxValue.FormattingEnabled = true;
            cmbxValue.Location = new Point(26, 154);
            cmbxValue.Name = "cmbxValue";
            cmbxValue.Size = new Size(312, 23);
            cmbxValue.TabIndex = 4;
            cmbxValue.SelectedIndexChanged += cmbxValue_SelectedIndexChanged;
            // 
            // txtTagReadedValue
            // 
            txtTagReadedValue.Enabled = false;
            txtTagReadedValue.Location = new Point(196, 101);
            txtTagReadedValue.Name = "txtTagReadedValue";
            txtTagReadedValue.Size = new Size(142, 23);
            txtTagReadedValue.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 83);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 6;
            label3.Text = "Tag Readed Value";
            // 
            // btnWrite
            // 
            btnWrite.BackColor = Color.MediumSeaGreen;
            btnWrite.Cursor = Cursors.Hand;
            btnWrite.FlatAppearance.BorderSize = 0;
            btnWrite.FlatStyle = FlatStyle.Flat;
            btnWrite.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnWrite.ForeColor = Color.White;
            btnWrite.Location = new Point(26, 353);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(142, 69);
            btnWrite.TabIndex = 7;
            btnWrite.Text = "WRITE";
            btnWrite.UseVisualStyleBackColor = false;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.DodgerBlue;
            btnRead.Cursor = Cursors.Hand;
            btnRead.FlatAppearance.BorderSize = 0;
            btnRead.FlatStyle = FlatStyle.Flat;
            btnRead.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRead.ForeColor = Color.White;
            btnRead.Location = new Point(196, 353);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(142, 69);
            btnRead.TabIndex = 8;
            btnRead.Text = "READ";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // labelConn
            // 
            labelConn.AutoSize = true;
            labelConn.Location = new Point(64, 286);
            labelConn.Name = "labelConn";
            labelConn.Size = new Size(104, 15);
            labelConn.TabIndex = 9;
            labelConn.Text = "Connection Status";
            // 
            // labelCpu
            // 
            labelCpu.AutoSize = true;
            labelCpu.Location = new Point(111, 316);
            labelCpu.Name = "labelCpu";
            labelCpu.Size = new Size(57, 15);
            labelCpu.TabIndex = 10;
            labelCpu.Text = "CPU Type";
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(26, 136);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(35, 15);
            labelValue.TabIndex = 11;
            labelValue.Text = "Value";
            // 
            // labelConnectionStatus
            // 
            labelConnectionStatus.AutoSize = true;
            labelConnectionStatus.Location = new Point(196, 286);
            labelConnectionStatus.Name = "labelConnectionStatus";
            labelConnectionStatus.Size = new Size(12, 15);
            labelConnectionStatus.TabIndex = 12;
            labelConnectionStatus.Text = "-";
            // 
            // labelCpuType
            // 
            labelCpuType.AutoSize = true;
            labelCpuType.Location = new Point(196, 316);
            labelCpuType.Name = "labelCpuType";
            labelCpuType.Size = new Size(12, 15);
            labelCpuType.TabIndex = 13;
            labelCpuType.Text = "-";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(26, 222);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(310, 23);
            txtValue.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 204);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 15;
            label1.Text = "Value";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 447);
            Controls.Add(label1);
            Controls.Add(txtValue);
            Controls.Add(labelCpuType);
            Controls.Add(labelConnectionStatus);
            Controls.Add(labelValue);
            Controls.Add(labelCpu);
            Controls.Add(labelConn);
            Controls.Add(btnRead);
            Controls.Add(btnWrite);
            Controls.Add(label3);
            Controls.Add(txtTagReadedValue);
            Controls.Add(cmbxValue);
            Controls.Add(label2);
            Controls.Add(txtTagAddress);
            Controls.Add(cmbxTags);
            Controls.Add(labelAddressCombobox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MX OPC GX Works 3";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAddressCombobox;
        private ComboBox cmbxTags;
        private TextBox txtTagAddress;
        private Label label2;
        private ComboBox cmbxValue;
        private TextBox txtTagReadedValue;
        private Label label3;
        private Button btnWrite;
        private Button btnRead;
        private Label labelConn;
        private Label labelCpu;
        private Label labelValue;
        private Label labelConnectionStatus;
        private Label labelCpuType;
        private TextBox txtValue;
        private Label label1;
    }
}