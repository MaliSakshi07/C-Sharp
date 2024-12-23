using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_Use_Cheak_Box_Cheak_ListBox : Form
    {
        public frm_Use_Cheak_Box_Cheak_ListBox()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool Flag = true, LFlag = true;

            if(tb_Emp_name.Text != "")
            {
                Result += tb_Emp_name.Text + " is From Department";
                lbl_Name_Error.Visible = false;
            }
            else
            {
                lbl_Name_Error.Text = "Enter Employee Name";
                lbl_Name_Error.Visible = true;
            }

            if(cmb_Dept.Text != "")
            {
                Result += cmb_Dept.Text;
                lbl_Dept_Error.Visible = false;
            }
            else 
            {
                lbl_Dept_Error.Text = "Select Department";
                lbl_Dept_Error.Visible = false;
                Flag = false;
            }
            if(rb_Male.Checked == true)
            {
                Result += ", is" + rb_Male.Text + " And He Knows";
                lbl_Gender_Error.Visible = true;
                Flag = false;
            }
            else if(rb_Female.Checked == true)
            {
                Result += ", is " + rb_Female.Text + " And she Knows ";
                lbl_Gender_Error.Visible = false;
            }
            else
            {
                lbl_Gender_Error.Text = "Select Gender";
                lbl_Gender_Error.Visible = true;
                Flag = false;
            }
            if(cb_Marathi.Checked == true)
            {
                Result += cb_Marathi.Text + ", ";
                lbl_Lang_Error.Visible = false;
                LFlag = false;
            }
            if(cb_Hindi.Checked == true)
            {
                Result += cb_Hindi.Text + ", ";
                lbl_Lang_Error.Visible = false;
                LFlag = false;
            }
            if(cb_English.Checked == true)
            {
                Result += cb_English.Text + ", ";
                lbl_Lang_Error.Visible = false;
                LFlag = false;
            }
            if (cb_French.Checked == true)
            {
                Result += cb_French.Text + ", ";
                lbl_Lang_Error.Visible = false;
                LFlag = false;
            }
            if(LFlag == true)
            {
                lbl_Lang_Error.Text = "Select Known Lang";
                lbl_Lang_Error.Visible = true;
                Flag = false;
            }
            int cnt = clb_Hobbies.CheckedItems.Count;

            if(cnt > 0)
            {
                lbl_Hobby_Error.Visible = false;
                Result += " And Has Hobbies as";

                for(int i=0; i < clb_Hobbies.Items.Count; i++)
                {
                    if(clb_Hobbies.GetItemChecked(i))
                    {
                        if(cnt > 1)
                        {
                            Result += clb_Hobbies.Items[i] + " ,";
                        }
                        else
                        {
                            Result += clb_Hobbies.Items[i] + ".";
                            break;
                        }
                        cnt--;
                    }
                }
            }
            else
            {
                lbl_Hobby_Error.Text = "Select atleast 1 Hobby";
                lbl_Hobby_Error.Visible = true;
                Flag = false;
            }
            if(Flag == false)
            {
                lbl_Result_Text.Visible = false;
            }
            else
            {
                lbl_Result_Text.Text = Result;
                lbl_Result_Text.Visible = true;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Emp_name.Clear();
            cmb_Dept.SelectedIndex = -1;

            rb_Male.Checked = false;
            rb_Female.Checked = false;

            cb_Marathi.Checked = false;
            cb_Hindi.Checked = false;
            cb_French.Checked = false;
            cb_English.Checked = false;

            for(int i=0; i<clb_Hobbies.Items.Count; i++)
            {
                clb_Hobbies.SetItemChecked(i, false);
            }
            lbl_Result_Text.Visible = false;
        }
    }
}
