using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGM_Student_Addmission_App
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
           if(tb_Username.Text == "Admin" && tb_Password.Text == "a123")
            {
                MessageBox.Show("Login Successfully", "Welcome");

                frm_Add_Student_Information ANS = new frm_Add_Student_Information();
                ANS.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Login failed,Enter correct Username / Password.", "Failure");
            }
            tb_Username.Clear();
            tb_Password.Clear();

            tb_Username.Focus();
        }
    }
}
