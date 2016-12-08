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
    public partial class updateUser : Form
    {
        public updateUser(string custID)
        {
            InitializeComponent();

            loaddata(custID);
        }

        private void loaddata(string custID) {
            using (var entity = new sdp_datebaseEntities()) {
                var row = entity.customer.FirstOrDefault(i => i.CustID == custID);

                txtBox_custID.Text = row.CustID;
                txtBox_surname.Text = row.Surname;
                txtBox_givenName.Text = row.GivenName;
                dtp_dob.Value = row.DateOfBirth;
                if (row.Gender == "M")
                {
                    cbBox_gender.SelectedIndex = 0;
                }
                else {
                    cbBox_gender.SelectedIndex = 1;
                }
                txtBox_passport.Text = row.Passport;
                txtBox_contact.Text = row.Contact;
                txtBox_nationality.Text = row.Nationality;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var entity = new sdp_datebaseEntities()) {
                var row = entity.customer.FirstOrDefault(i => i.CustID == txtBox_custID.Text);

                row.Surname = txtBox_surname.Text;
                row.GivenName = txtBox_givenName.Text;
                row.DateOfBirth = dtp_dob.Value.Date;
                row.Gender = cbBox_gender.SelectedItem.ToString();
                row.Passport = txtBox_passport.Text;
                row.Contact = txtBox_contact.Text;
                row.Nationality = txtBox_nationality.Text;

                entity.SaveChanges();
            }
            MessageBox.Show("Update customer successful");
            this.Close();
        }
    }
}
