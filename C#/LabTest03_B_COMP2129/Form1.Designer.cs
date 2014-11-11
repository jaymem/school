namespace Jordan_Morenstein_LabTest03_B_COMP2129
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fnbox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.lnbox = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.Label();
            this.province = new System.Windows.Forms.Label();
            this.postal = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.progAn = new System.Windows.Forms.RadioButton();
            this.compProg = new System.Windows.Forms.RadioButton();
            this.courses = new System.Windows.Forms.ComboBox();
            this.txtDisplay = new System.Windows.Forms.RichTextBox();
            this.display = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.test = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fnbox
            // 
            this.fnbox.Location = new System.Drawing.Point(87, 50);
            this.fnbox.Name = "fnbox";
            this.fnbox.Size = new System.Drawing.Size(142, 20);
            this.fnbox.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 237);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(87, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 20);
            this.textBox3.TabIndex = 2;
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(87, 167);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(142, 20);
            this.cityBox.TabIndex = 3;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(87, 130);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(142, 20);
            this.addressBox.TabIndex = 4;
            // 
            // lnbox
            // 
            this.lnbox.Location = new System.Drawing.Point(87, 91);
            this.lnbox.Name = "lnbox";
            this.lnbox.Size = new System.Drawing.Size(142, 20);
            this.lnbox.TabIndex = 5;
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(23, 56);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(57, 13);
            this.fname.TabIndex = 6;
            this.fname.Text = "First Name";
            // 
            // province
            // 
            this.province.AutoSize = true;
            this.province.Location = new System.Drawing.Point(23, 244);
            this.province.Name = "province";
            this.province.Size = new System.Drawing.Size(49, 13);
            this.province.TabIndex = 7;
            this.province.Text = "Province";
            // 
            // postal
            // 
            this.postal.AutoSize = true;
            this.postal.Location = new System.Drawing.Point(23, 205);
            this.postal.Name = "postal";
            this.postal.Size = new System.Drawing.Size(64, 13);
            this.postal.TabIndex = 8;
            this.postal.Text = "Postal Code";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(23, 174);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(24, 13);
            this.city.TabIndex = 9;
            this.city.Text = "City";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(23, 137);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(45, 13);
            this.address.TabIndex = 10;
            this.address.Text = "Address";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(23, 94);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(56, 13);
            this.lname.TabIndex = 11;
            this.lname.Text = "Last name";
            // 
            // progAn
            // 
            this.progAn.AutoSize = true;
            this.progAn.Location = new System.Drawing.Point(245, 50);
            this.progAn.Name = "progAn";
            this.progAn.Size = new System.Drawing.Size(149, 17);
            this.progAn.TabIndex = 12;
            this.progAn.TabStop = true;
            this.progAn.Text = "Computer Program Analyst";
            this.progAn.UseVisualStyleBackColor = true;
            this.progAn.CheckedChanged += new System.EventHandler(this.progAn_CheckedChanged);
            // 
            // compProg
            // 
            this.compProg.AutoSize = true;
            this.compProg.Location = new System.Drawing.Point(399, 50);
            this.compProg.Name = "compProg";
            this.compProg.Size = new System.Drawing.Size(129, 17);
            this.compProg.TabIndex = 13;
            this.compProg.TabStop = true;
            this.compProg.Text = "Computer Programmer";
            this.compProg.UseVisualStyleBackColor = true;
            this.compProg.CheckedChanged += new System.EventHandler(this.compProg_CheckedChanged);
            // 
            // courses
            // 
            this.courses.FormattingEnabled = true;
            this.courses.Location = new System.Drawing.Point(245, 91);
            this.courses.Name = "courses";
            this.courses.Size = new System.Drawing.Size(143, 21);
            this.courses.TabIndex = 14;
            this.courses.SelectedIndexChanged += new System.EventHandler(this.courses_SelectedIndexChanged);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 332);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(536, 104);
            this.txtDisplay.TabIndex = 16;
            this.txtDisplay.Text = "";
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(26, 287);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(75, 23);
            this.display.TabIndex = 17;
            this.display.Text = "Display";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(245, 130);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(200, 121);
            this.listBox.TabIndex = 18;
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(145, 287);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(0, 13);
            this.test.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 448);
            this.Controls.Add(this.test);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.display);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.courses);
            this.Controls.Add(this.compProg);
            this.Controls.Add(this.progAn);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.address);
            this.Controls.Add(this.city);
            this.Controls.Add(this.postal);
            this.Controls.Add(this.province);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.lnbox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.fnbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fnbox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox lnbox;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label province;
        private System.Windows.Forms.Label postal;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.RadioButton progAn;
        private System.Windows.Forms.RadioButton compProg;
        private System.Windows.Forms.ComboBox courses;
        private System.Windows.Forms.RichTextBox txtDisplay;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label test;
    }
}

