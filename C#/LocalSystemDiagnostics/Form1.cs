using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;

namespace LocalSystemDiagnostics
{
    public partial class Form1 : Form
    {
        private string saveSettings = String.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void storageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListPopulator.PopulateListView(systemBox.SelectedItem.ToString(), ref systemListView, systemChk.Checked);
        }

        private void networkBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListPopulator.PopulateListView(networkBox.SelectedItem.ToString(), ref networkListView, networkChk.Checked);
        }

        private void accountsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListPopulator.PopulateListView(accountsBox.SelectedItem.ToString(), ref accountsListView, accountsChk.Checked);
        }

        private void storageBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListPopulator.PopulateListView(storageBox.SelectedItem.ToString(), ref storageListView, storageChk.Checked);
        }

        private void hardwareBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListPopulator.PopulateListView(hardwareBox.SelectedItem.ToString(), ref hardwareListView, hardwareChk.Checked);
        }

        private void hardwareChk_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void systemChk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void systemSave_CheckedChanged(object sender, EventArgs e)
        {
            saveSettings += "------- System Settings -------\n\n";
            saveSettings += ListPopulator.GetWin32Class("Win32_ComputerSystem");
            saveSettings += "\n \n";
        }

        private void hardwareSave_CheckedChanged(object sender, EventArgs e)
        {
            saveSettings += "------- Hardware Configurations -------\n\n";
            saveSettings += ListPopulator.GetWin32Class("Win32_PhysicalMemory");
            saveSettings += "\n \n";
        }

        private void storageSave_CheckedChanged(object sender, EventArgs e)
        {
            saveSettings += "------- Storage Space -------\n\n";
            saveSettings += ListPopulator.GetWin32Class("Win32_LogicalDisk");
            saveSettings += "\n \n";
        }

        private void networkSave_CheckedChanged(object sender, EventArgs e)
        {
            saveSettings += "------- Network Connections -------\n\n";
            saveSettings += ListPopulator.GetWin32Class("Win32_NetworkProtocol");
            saveSettings += "\n \n";
        }

        private void accountSave_CheckedChanged(object sender, EventArgs e)
        {
            saveSettings += "------- Network Connections -------\n\n";
            saveSettings += ListPopulator.GetWin32Class("Win32_UserAccount");
            saveSettings += "\n \n";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                    using (StreamWriter StreamWriter1 = new StreamWriter(saveFileDialog1.FileName))
                    {
                        StreamWriter1.WriteLine(saveSettings);
                    }
                }
            }
        }
    }
}
