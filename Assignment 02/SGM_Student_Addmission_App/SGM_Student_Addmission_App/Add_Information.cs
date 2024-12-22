using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SGM_Student_Addmission_App
{
    public partial class frm_Add_Student_Information : Form
    {
        public frm_Add_Student_Information()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-N9JDFEK1;Initial Catalog=SGM_Student_Addmission_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if( Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Close();
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        void Clear_Controls()
        {
            tb_RNo.Text = "";
            tb_Name.Clear();
            tb_Mob_No.Clear();
            cmb_Course.SelectedIndex = -1;
            dtp_DOB.Text = "01/06/2004";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if( tb_RNo.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;
                cmd.CommandText = "Insert Into Student_Details (Roll_No, Name, Mobile_No, DOB, Course) values (@Roll_no, @Name, @Mobile_No, @DOB, @Course)";

                cmd.Parameters.Add("Roll_No", SqlDbType.Int).Value = tb_RNo.Text;
                cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("Mobile_No", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved");

                Clear_Controls();
            }
            else 
            {
                MessageBox.Show("Fill All Filds");
            }
            Con_Close();
        }

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List obj1 = new frm_Student_List();
            obj1.Show();
            this.Hide();
        }

       
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            frm_Search_Student_By_Roll_No obj = new frm_Search_Student_By_Roll_No();
            obj.Show();
            this.Hide();
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

    }
}
