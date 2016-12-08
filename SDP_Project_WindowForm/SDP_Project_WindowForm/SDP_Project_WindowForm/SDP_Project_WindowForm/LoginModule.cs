using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_Project_WindowForm
{
    public partial class LoginModule : Form
    {

        public LoginModule()
        {
            InitializeComponent();
            txtBox_password_loginform.PasswordChar = '*';
        }

        private void LoginModule_Load(object sender, EventArgs e)
        {
            lbl_name_loginform.Text = "";
            lbl_titleName_loginform.Text = "";
        }

        private void ucStatuesBar1_Load(object sender, EventArgs e)
        {
            ucStatuesBar1.sg_lblCurrentStatus = "Login ready";
        }

        private void txtBox_loginName_loginform_TextChanged(object sender, EventArgs e)
        {
            string loginID = txtBox_loginName_loginform.Text;

            using (var entity = new sdp_datebaseEntities()) {
                var stf = (from list in entity.staff
                           where list.StaffID == loginID
                           select list).FirstOrDefault();

                if (stf != null) {
                    if (stf.Gender.Equals("M"))
                    {
                        lbl_titleName_loginform.Text = "Mr. ";
                    }
                    else {
                        lbl_titleName_loginform.Text = "Ms. ";
                    }
                    lbl_name_loginform.Text = stf.StaffName;
                }
            }
        }

        private void btn_login_loginform_Click(object sender, EventArgs e)
        {
            string loginID = txtBox_loginName_loginform.Text;
            string pwd = txtBox_password_loginform.Text;

            staff loginOK = null;

            using (var entity = new sdp_datebaseEntities()) {
                var stf = entity.staff.Where(i => (i.StaffID == loginID && i.Pass == pwd)).FirstOrDefault();
                if (stf == null)
                {
                    MessageBox.Show("Invalid login detail");
                    return;
                }
                else {
                    loginOK = stf;
                }
            }
            new MainForm(loginOK).ShowDialog();
        }

        private void LoginModule_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                btn_login_loginform_Click(sender, e);
            }
        }

        
    }
}
