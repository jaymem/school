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

namespace LocalSystemDiagnostics
{
    class ListPopulator
    {
        private static string values;

        public static void PopulateListView(string key, ref ListView list)
        {
            list.Items.Clear();

            // retrieves a collection of management objects through WMI query
            // returns a collection of management objects
            ManagementObjectSearcher managementObjects = new ManagementObjectSearcher("select * from " + key);

            try
            {
                foreach (ManagementObject mngmtObj in managementObjects.Get())
                {
                    ListViewGroup listGroup;

                    // add all the returned objects to our list view group
                    try
                    {
                        listGroup = list.Groups.Add(mngmtObj["Name"].ToString(), mngmtObj["Name"].ToString());
                    }
                    catch
                    {
                        listGroup = list.Groups.Add(mngmtObj.ToString(), mngmtObj.ToString());
                    }

                    if (mngmtObj.Properties.Count <= 0)
                    {
                        MessageBox.Show(
                            "Sorry, but there id no info available",
                            "No Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information
                        );

                        return;
                    }

                    // loop through the management object properties
                    // PropertyData represents information of WMI properties
                    foreach (PropertyData systemProperty in mngmtObj.Properties)
                    {
                        ListViewItem listItem = new ListViewItem(listGroup);
                        
                        string propertyType = systemProperty.Value.GetType().ToString();

                        if (list.Items.Count % 2 != 0)
                            listItem.BackColor = Color.White;
                        else
                            listItem.BackColor = Color.WhiteSmoke;

                        listItem.Text = systemProperty.Name;

                        if (propertyType != "")
                        {
                            switch (propertyType)
                            {
                                case "System.String[]":
                                    string[] propertyValues = (string[])systemProperty.Value;
                                    string valueString = "";

                                    foreach (string value in propertyValues)
                                        valueString += value + " ";

                                    listItem.SubItems.Add(valueString);
                                    break;
                                case "System.UInt16[]":
                                    ushort[] shortValues = (ushort[])systemProperty.Value;
                                    valueString = "";

                                    foreach (ushort value in shortValues)
                                        valueString += value.ToString() + " ";

                                    listItem.SubItems.Add(valueString);
                                    break;
                                default:
                                    listItem.SubItems.Add(systemProperty.Value.ToString());
                                    break;
                            }
                        }
                        list.Items.Add(listItem);
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(
                    "Can't populate data due to the following error: \n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
        }
    }
}
