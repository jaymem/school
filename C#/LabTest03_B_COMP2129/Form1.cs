using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jordan_Morenstein_LabTest03_B_COMP2129
{
    public partial class Form1 : Form
    {
        private string[] progAnList = { 
                            "Advance Programming", 
                            "Computer Fundamentals", 
                            "Software Engineering"
                        };

        private string[] compProgList = {
                                           "CSharp", 
                                           "Java",
                                           "Web Programming"
                                       };

        private string listDisplay = String.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void listCourses(string[] course)
        {
            // Loop to populate combo box
            foreach (string value in course)
            {
                courses.Items.Add(value);
            }
        }

        private string listBoxDisplay()
        {
            // Loop to display list box
            foreach (string value in listBox.Items)
            {
                listDisplay += value + "\t";
            }

            return listDisplay;
        }

        private void progAn_CheckedChanged(object sender, EventArgs e)
        {
            this.listCourses(this.progAnList);   
        }

        private void compProg_CheckedChanged(object sender, EventArgs e)
        {
            this.listCourses(this.compProgList); 
        }

        private void courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox.Items.Add(courses.SelectedItem.ToString());
        }

        private void displayCourse()
        {
            if (fnbox.Text == String.Empty
               || lnbox.Text == String.Empty
               || addressBox.Text == String.Empty)
            {
                DisplayException ex = new DisplayException(
                       "You cannot leave any empty text Fields!",
                       "Please make sure there any no empty text fields",
                       DateTime.Now
                    );
                throw ex;
            }
            else
            {
                txtDisplay.Text = fnbox.Text + "\t"
                + lnbox.Text + "\t"
                + addressBox.Text;

                txtDisplay.Text += Environment.NewLine;

                txtDisplay.Text += listBoxDisplay();
            }
        }

        private void display_Click(object sender, EventArgs e)
        {
            txtDisplay.Multiline = true;
            txtDisplay.WordWrap = true;

            try
            {
                displayCourse();
            }
            catch (DisplayException ex)
            {
                test.Text = ex.Message + "\n";
                test.Text += ex.CauseOfError + "\n";
                test.Text += "Error found on " + ex.ErrorTimeStamp;
            }
        }
    }
}
