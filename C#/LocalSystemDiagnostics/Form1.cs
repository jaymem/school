using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Management;

namespace LocalSystemDiagnostics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void storageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListPopulator.PopulateListView(systemBox.SelectedItem.ToString(), ref systemListView);
        }

        private void networkBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListPopulator.PopulateListView(networkBox.SelectedItem.ToString(), ref networkListView);
        }
    }
}
