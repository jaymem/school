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
        private static string valueString;
        private static ListView test;
        private static string tester;

        public static void PopulateListView(string key, ref ListView list, bool noNull)
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

                        if (list.Items.Count % 2 != 0)
                            listItem.BackColor = Color.White;
                        else
                            listItem.BackColor = Color.WhiteSmoke;

                        listItem.Text = systemProperty.Name;

                        if (systemProperty.Value != null && systemProperty.Value.ToString() != "")
                        {
                            switch (systemProperty.Value.GetType().ToString())
                            {
                                case "System.String[]":
                                    string[] propertyValues = (string[])systemProperty.Value;

                                    foreach (string value in propertyValues)
                                        valueString += value + " ";
                                    
                                    listItem.SubItems.Add(valueString);
                                    break;
                                case "System.UInt16[]":
                                    ushort[] shortValues = (ushort[])systemProperty.Value;

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
                        test = list;
                    }
                }
            }
            catch (WMIException ex)
            {
                MessageBox.Show(
                    "Can't populate data due to the following error: \n" + ex.StackTrace,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
        }

        public static string GetWin32Class(string stringIn)
        {
            StringBuilder StringBuilder1 = new StringBuilder(string.Empty);
            ManagementClass ManagementClass1 = new ManagementClass(stringIn);
            //Create a ManagementObjectCollection to loop through
            ManagementObjectCollection ManagemenobjCol = ManagementClass1.GetInstances();
            //Get the properties in the class
            PropertyDataCollection properties = ManagementClass1.Properties;
            foreach (ManagementObject obj in ManagemenobjCol)
            {
                foreach (PropertyData property in properties)
                {
                    try
                    {
                        StringBuilder1.AppendLine(property.Name + ":  " +
                          obj.Properties[property.Name].Value.ToString());
                    }
                    catch
                    {
                        //Add codes to manage more informations
                    }
                }
                StringBuilder1.AppendLine();
            }
            return StringBuilder1.ToString();
        }
    }
}