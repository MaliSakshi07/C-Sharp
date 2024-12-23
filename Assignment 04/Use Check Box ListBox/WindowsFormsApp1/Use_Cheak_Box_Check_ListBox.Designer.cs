
namespace WindowsFormsApp1
{
    partial class frm_Use_Cheak_Box_Cheak_ListBox
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
            this.lbl_Employee_Details = new System.Windows.Forms.Label();
            this.lbl_Emp_Name = new System.Windows.Forms.Label();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Languages = new System.Windows.Forms.Label();
            this.lbl_Hobbies = new System.Windows.Forms.Label();
            this.tb_Emp_name = new System.Windows.Forms.TextBox();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.cmb_Dept = new System.Windows.Forms.ComboBox();
            this.clb_Hobbies = new System.Windows.Forms.CheckedListBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.lbl_Name_Error = new System.Windows.Forms.Label();
            this.lbl_Dept_Error = new System.Windows.Forms.Label();
            this.lbl_Gender_Error = new System.Windows.Forms.Label();
            this.lbl_Lang_Error = new System.Windows.Forms.Label();
            this.lbl_Hobby_Error = new System.Windows.Forms.Label();
            this.cb_Marathi = new System.Windows.Forms.CheckBox();
            this.cb_Hindi = new System.Windows.Forms.CheckBox();
            this.cb_English = new System.Windows.Forms.CheckBox();
            this.cb_French = new System.Windows.Forms.CheckBox();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.gb_Known_Languages = new System.Windows.Forms.GroupBox();
            this.lbl_Result_Text = new System.Windows.Forms.Label();
            this.gb_Gender.SuspendLayout();
            this.gb_Known_Languages.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Employee_Details
            // 
            this.lbl_Employee_Details.AutoSize = true;
            this.lbl_Employee_Details.BackColor = System.Drawing.Color.Snow;
            this.lbl_Employee_Details.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Details.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Employee_Details.Location = new System.Drawing.Point(254, 44);
            this.lbl_Employee_Details.Name = "lbl_Employee_Details";
            this.lbl_Employee_Details.Size = new System.Drawing.Size(881, 90);
            this.lbl_Employee_Details.TabIndex = 0;
            this.lbl_Employee_Details.Text = "Employee General Details";
            // 
            // lbl_Emp_Name
            // 
            this.lbl_Emp_Name.AutoSize = true;
            this.lbl_Emp_Name.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.lbl_Emp_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Emp_Name.Location = new System.Drawing.Point(12, 186);
            this.lbl_Emp_Name.Name = "lbl_Emp_Name";
            this.lbl_Emp_Name.Size = new System.Drawing.Size(196, 33);
            this.lbl_Emp_Name.TabIndex = 1;
            this.lbl_Emp_Name.Text = "Employee Name";
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.lbl_Department.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Department.Location = new System.Drawing.Point(12, 300);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(261, 33);
            this.lbl_Department.TabIndex = 2;
            this.lbl_Department.Text = "Employee Department";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.lbl_Gender.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Gender.Location = new System.Drawing.Point(12, 416);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(95, 33);
            this.lbl_Gender.TabIndex = 3;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Languages
            // 
            this.lbl_Languages.AutoSize = true;
            this.lbl_Languages.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.lbl_Languages.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Languages.Location = new System.Drawing.Point(776, 202);
            this.lbl_Languages.Name = "lbl_Languages";
            this.lbl_Languages.Size = new System.Drawing.Size(219, 33);
            this.lbl_Languages.TabIndex = 4;
            this.lbl_Languages.Text = "Known Languages";
            // 
            // lbl_Hobbies
            // 
            this.lbl_Hobbies.AutoSize = true;
            this.lbl_Hobbies.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.lbl_Hobbies.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Hobbies.Location = new System.Drawing.Point(816, 383);
            this.lbl_Hobbies.Name = "lbl_Hobbies";
            this.lbl_Hobbies.Size = new System.Drawing.Size(107, 33);
            this.lbl_Hobbies.TabIndex = 5;
            this.lbl_Hobbies.Text = "Hobbies";
            // 
            // tb_Emp_name
            // 
            this.tb_Emp_name.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Emp_name.Location = new System.Drawing.Point(323, 187);
            this.tb_Emp_name.Name = "tb_Emp_name";
            this.tb_Emp_name.Size = new System.Drawing.Size(350, 34);
            this.tb_Emp_name.TabIndex = 6;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.rb_Male.Location = new System.Drawing.Point(46, 23);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(72, 26);
            this.rb_Male.TabIndex = 8;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // cmb_Dept
            // 
            this.cmb_Dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Dept.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmb_Dept.FormattingEnabled = true;
            this.cmb_Dept.Items.AddRange(new object[] {
            "Maneger",
            "Assicetant",
            "clark"});
            this.cmb_Dept.Location = new System.Drawing.Point(323, 301);
            this.cmb_Dept.Name = "cmb_Dept";
            this.cmb_Dept.Size = new System.Drawing.Size(350, 34);
            this.cmb_Dept.TabIndex = 9;
            // 
            // clb_Hobbies
            // 
            this.clb_Hobbies.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.clb_Hobbies.FormattingEnabled = true;
            this.clb_Hobbies.Items.AddRange(new object[] {
            "Cycling",
            "Driving",
            "Tracking",
            "Gaming",
            "Cooking",
            "Reading"});
            this.clb_Hobbies.Location = new System.Drawing.Point(1002, 369);
            this.clb_Hobbies.Name = "clb_Hobbies";
            this.clb_Hobbies.Size = new System.Drawing.Size(239, 178);
            this.clb_Hobbies.TabIndex = 10;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.rb_Female.Location = new System.Drawing.Point(222, 23);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(89, 26);
            this.rb_Female.TabIndex = 11;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Reset.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Reset.ForeColor = System.Drawing.Color.Navy;
            this.btn_Reset.Location = new System.Drawing.Point(288, 575);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(182, 46);
            this.btn_Reset.TabIndex = 12;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_Submit.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Submit.ForeColor = System.Drawing.Color.Navy;
            this.btn_Submit.Location = new System.Drawing.Point(808, 574);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(187, 47);
            this.btn_Submit.TabIndex = 13;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.lbl_Output.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Output.Location = new System.Drawing.Point(28, 656);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(93, 33);
            this.lbl_Output.TabIndex = 14;
            this.lbl_Output.Text = "Output";
            // 
            // tb_Output
            // 
            this.tb_Output.Font = new System.Drawing.Font("Times New Roman", 16.2F);
            this.tb_Output.Location = new System.Drawing.Point(198, 664);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(1099, 39);
            this.tb_Output.TabIndex = 15;
            // 
            // lbl_Name_Error
            // 
            this.lbl_Name_Error.AutoSize = true;
            this.lbl_Name_Error.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lbl_Name_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Name_Error.Location = new System.Drawing.Point(583, 224);
            this.lbl_Name_Error.Name = "lbl_Name_Error";
            this.lbl_Name_Error.Size = new System.Drawing.Size(90, 19);
            this.lbl_Name_Error.TabIndex = 16;
            this.lbl_Name_Error.Text = "Name Error";
            // 
            // lbl_Dept_Error
            // 
            this.lbl_Dept_Error.AutoSize = true;
            this.lbl_Dept_Error.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lbl_Dept_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Dept_Error.Location = new System.Drawing.Point(574, 350);
            this.lbl_Dept_Error.Name = "lbl_Dept_Error";
            this.lbl_Dept_Error.Size = new System.Drawing.Size(83, 19);
            this.lbl_Dept_Error.TabIndex = 17;
            this.lbl_Dept_Error.Text = "Dept Error";
            // 
            // lbl_Gender_Error
            // 
            this.lbl_Gender_Error.AutoSize = true;
            this.lbl_Gender_Error.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lbl_Gender_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Gender_Error.Location = new System.Drawing.Point(572, 458);
            this.lbl_Gender_Error.Name = "lbl_Gender_Error";
            this.lbl_Gender_Error.Size = new System.Drawing.Size(100, 19);
            this.lbl_Gender_Error.TabIndex = 18;
            this.lbl_Gender_Error.Text = "Gender Error";
            // 
            // lbl_Lang_Error
            // 
            this.lbl_Lang_Error.AutoSize = true;
            this.lbl_Lang_Error.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lbl_Lang_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Lang_Error.Location = new System.Drawing.Point(1176, 314);
            this.lbl_Lang_Error.Name = "lbl_Lang_Error";
            this.lbl_Lang_Error.Size = new System.Drawing.Size(83, 19);
            this.lbl_Lang_Error.TabIndex = 19;
            this.lbl_Lang_Error.Text = "Lang Error";
            // 
            // lbl_Hobby_Error
            // 
            this.lbl_Hobby_Error.AutoSize = true;
            this.lbl_Hobby_Error.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lbl_Hobby_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Hobby_Error.Location = new System.Drawing.Point(1146, 550);
            this.lbl_Hobby_Error.Name = "lbl_Hobby_Error";
            this.lbl_Hobby_Error.Size = new System.Drawing.Size(95, 19);
            this.lbl_Hobby_Error.TabIndex = 20;
            this.lbl_Hobby_Error.Text = "Hobby Error";
            // 
            // cb_Marathi
            // 
            this.cb_Marathi.AutoSize = true;
            this.cb_Marathi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Marathi.Location = new System.Drawing.Point(29, 33);
            this.cb_Marathi.Name = "cb_Marathi";
            this.cb_Marathi.Size = new System.Drawing.Size(84, 23);
            this.cb_Marathi.TabIndex = 22;
            this.cb_Marathi.Text = "Marathi";
            this.cb_Marathi.UseVisualStyleBackColor = true;
            // 
            // cb_Hindi
            // 
            this.cb_Hindi.AutoSize = true;
            this.cb_Hindi.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cb_Hindi.Location = new System.Drawing.Point(179, 33);
            this.cb_Hindi.Name = "cb_Hindi";
            this.cb_Hindi.Size = new System.Drawing.Size(69, 23);
            this.cb_Hindi.TabIndex = 23;
            this.cb_Hindi.Text = "Hindi";
            this.cb_Hindi.UseVisualStyleBackColor = true;
            // 
            // cb_English
            // 
            this.cb_English.AutoSize = true;
            this.cb_English.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cb_English.Location = new System.Drawing.Point(31, 80);
            this.cb_English.Name = "cb_English";
            this.cb_English.Size = new System.Drawing.Size(82, 23);
            this.cb_English.TabIndex = 24;
            this.cb_English.Text = "English";
            this.cb_English.UseVisualStyleBackColor = true;
            // 
            // cb_French
            // 
            this.cb_French.AutoSize = true;
            this.cb_French.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cb_French.Location = new System.Drawing.Point(179, 80);
            this.cb_French.Name = "cb_French";
            this.cb_French.Size = new System.Drawing.Size(78, 23);
            this.cb_French.TabIndex = 25;
            this.cb_French.Text = "French";
            this.cb_French.UseVisualStyleBackColor = true;
            // 
            // gb_Gender
            // 
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.gb_Gender.Location = new System.Drawing.Point(323, 400);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(350, 55);
            this.gb_Gender.TabIndex = 26;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // gb_Known_Languages
            // 
            this.gb_Known_Languages.Controls.Add(this.cb_Marathi);
            this.gb_Known_Languages.Controls.Add(this.cb_English);
            this.gb_Known_Languages.Controls.Add(this.cb_French);
            this.gb_Known_Languages.Controls.Add(this.cb_Hindi);
            this.gb_Known_Languages.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.gb_Known_Languages.Location = new System.Drawing.Point(1002, 187);
            this.gb_Known_Languages.Name = "gb_Known_Languages";
            this.gb_Known_Languages.Size = new System.Drawing.Size(295, 119);
            this.gb_Known_Languages.TabIndex = 27;
            this.gb_Known_Languages.TabStop = false;
            this.gb_Known_Languages.Text = "Known Languages";
            // 
            // lbl_Result_Text
            // 
            this.lbl_Result_Text.AutoSize = true;
            this.lbl_Result_Text.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbl_Result_Text.ForeColor = System.Drawing.Color.Red;
            this.lbl_Result_Text.Location = new System.Drawing.Point(205, 671);
            this.lbl_Result_Text.Name = "lbl_Result_Text";
            this.lbl_Result_Text.Size = new System.Drawing.Size(393, 27);
            this.lbl_Result_Text.TabIndex = 28;
            this.lbl_Result_Text.Text = "Output Of Submit Button Appears Here";
            // 
            // frm_Use_Cheak_Box_Cheak_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1353, 742);
            this.Controls.Add(this.lbl_Result_Text);
            this.Controls.Add(this.gb_Known_Languages);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.lbl_Hobby_Error);
            this.Controls.Add(this.lbl_Lang_Error);
            this.Controls.Add(this.lbl_Gender_Error);
            this.Controls.Add(this.lbl_Dept_Error);
            this.Controls.Add(this.lbl_Name_Error);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.clb_Hobbies);
            this.Controls.Add(this.cmb_Dept);
            this.Controls.Add(this.tb_Emp_name);
            this.Controls.Add(this.lbl_Hobbies);
            this.Controls.Add(this.lbl_Languages);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Department);
            this.Controls.Add(this.lbl_Emp_Name);
            this.Controls.Add(this.lbl_Employee_Details);
            this.Name = "frm_Use_Cheak_Box_Cheak_ListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Use Cheak Box Check List Box";
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.gb_Known_Languages.ResumeLayout(false);
            this.gb_Known_Languages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_Details;
        private System.Windows.Forms.Label lbl_Emp_Name;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Languages;
        private System.Windows.Forms.Label lbl_Hobbies;
        private System.Windows.Forms.TextBox tb_Emp_name;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.ComboBox cmb_Dept;
        private System.Windows.Forms.CheckedListBox clb_Hobbies;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.Label lbl_Name_Error;
        private System.Windows.Forms.Label lbl_Dept_Error;
        private System.Windows.Forms.Label lbl_Gender_Error;
        private System.Windows.Forms.Label lbl_Lang_Error;
        private System.Windows.Forms.Label lbl_Hobby_Error;
        private System.Windows.Forms.CheckBox cb_Marathi;
        private System.Windows.Forms.CheckBox cb_Hindi;
        private System.Windows.Forms.CheckBox cb_English;
        private System.Windows.Forms.CheckBox cb_French;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.GroupBox gb_Known_Languages;
        private System.Windows.Forms.Label lbl_Result_Text;
    }
}

