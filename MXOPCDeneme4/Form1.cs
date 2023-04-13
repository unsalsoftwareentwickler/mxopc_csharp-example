using ActUtlTypeLib;
using System.Diagnostics.Eventing.Reader;

namespace MXOPCDeneme4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public ActUtlType plc = new ActUtlType();
        public short data;
        public string selectedTag = string.Empty;
        public short selectedValue = -1;

        public string cpuName = string.Empty;
        public int cpuCode;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbxTags.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxValue.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxValue.Enabled = false;

            cmbxTags.Items.Add("SistemStart");

            /*
            cmbxTags.Items.Add("MainConveyor");
            cmbxTags.Items.Add("BlueConveyor");
            cmbxTags.Items.Add("BridgeConveyor");
            cmbxTags.Items.Add("GreenConveyor");
            cmbxTags.Items.Add("LastConveyor");
            cmbxTags.Items.Add("BlueSensor");
            cmbxTags.Items.Add("GreenSensor");
            cmbxTags.Items.Add("WarningLight");
            cmbxTags.Items.Add("Alarm1");
            cmbxTags.Items.Add("Alarm2");
            cmbxTags.Items.Add("Bilgi1");
            */

            cmbxValue.Items.Add("0");
            cmbxValue.Items.Add("1");

        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
            if(selectedValue == -1)
            {
                MessageBox.Show("Bir deðer seçin");
            }
            else
            {
                try
                {
                    plc.ActLogicalStationNumber = 1;
                    plc.Open();
                    plc.SetDevice2(selectedTag, selectedValue);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    plc.Close();
                }
            }
            
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                plc.ActLogicalStationNumber = 1;
                plc.Open();

                plc.GetDevice2(txtTagAddress.Text, out data);
                txtTagReadedValue.Text = data.ToString();

                plc.GetCpuType(out cpuName, out cpuCode);
                labelCpuType.Text = cpuName;
                labelConnectionStatus.Text = "Connected";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                plc.Close();
            }
        }
        private void cmbxTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTagAddress.Text = string.Empty;
            txtTagReadedValue.Text = string.Empty;

            if (cmbxTags.SelectedItem == "SistemStart") { selectedTag = "X4"; txtTagAddress.Text = selectedTag; cmbxValue.Enabled = true; btnWrite.Enabled = true; }
            /*
            else if (cmbxTags.SelectedItem == "MainConveyor") { selectedTag = "Y0"; txtTagAddress.Text = selectedTag; cmbxValue.Enabled = true; btnWrite.Enabled = false; }
            else if (cmbxTags.SelectedItem == "BlueConveyor") { selectedTag = "Y1"; txtTagAddress.Text = selectedTag; cmbxValue.Enabled = true; btnWrite.Enabled = false; }
            else if (cmbxTags.SelectedItem == "BridgeConveyor") { selectedTag = "Y2"; txtTagAddress.Text = selectedTag; cmbxValue.Enabled = true; btnWrite.Enabled = false; }
            else if (cmbxTags.SelectedItem == "GreenConveyor") { selectedTag = "Y3"; txtTagAddress.Text = selectedTag; cmbxValue.Enabled = true; btnWrite.Enabled = false; }
            else if (cmbxTags.SelectedItem == "LastConveyor") { selectedTag = "Y4"; txtTagAddress.Text = selectedTag; cmbxValue.Enabled = true; btnWrite.Enabled = false; }
            else if (cmbxTags.SelectedItem == "BlueSensor") { selectedTag = "X1"; txtTagAddress.Text = selectedTag; cmbxValue.Enabled = true; btnWrite.Enabled = true; }
            else if (cmbxTags.SelectedItem == "GreenSensor") { selectedTag = "X2"; txtTagAddress.Text = selectedTag; cmbxValue.Enabled = true; btnWrite.Enabled = true; }
            else if (cmbxTags.SelectedItem == "WarningLight") { selectedTag = "Y5"; txtTagAddress.Text = selectedTag; cmbxValue.Enabled = true; btnWrite.Enabled = false; }
            else if (cmbxTags.SelectedItem == "Alarm1") { selectedTag = "D0"; txtTagAddress.Text = selectedTag; cmbxValue.Enabled = false; selectedValue = -1; btnWrite.Enabled = true; }
            else if (cmbxTags.SelectedItem == "Alarm2") { selectedTag = "D1"; txtTagAddress.Text = selectedTag; cmbxValue.Enabled = false; selectedValue = -1; btnWrite.Enabled = true; }
            else if (cmbxTags.SelectedItem == "Bilgi1") { selectedTag = "D2"; txtTagAddress.Text = selectedTag; cmbxValue.Enabled = false; selectedValue = -1; btnWrite.Enabled = true; }
            */
            else { selectedTag = string.Empty; }
        }
        private void cmbxValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxValue.SelectedItem == "0")
            { selectedValue = 0; }
            else if (cmbxValue.SelectedItem == "1")
            { selectedValue = 1; }
            else { selectedValue = -1; }
        }
    }
}