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
    public partial class CreateUser : Form
    {
        private string custID;

        public CreateUser()
        {
            InitializeComponent();

            using (var entity = new sdp_datebaseEntities())
            {
                var row = (from list in entity.customer
                           select list).FirstOrDefault();
                var rowLast = (from list in entity.customer
                               orderby list.CustID descending
                               select list).FirstOrDefault();

                string id;
                int i = 0;
                if (row == null)
                {
                    id = "C000";
                }
                else
                {
                    id = rowLast.CustID;
                    i = Int32.Parse(id.Substring(1, 3));
                    i++;
                    id = "C" + i.ToString("000");
                }
                custID = id;
            }
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            cbBox_gender.SelectedIndex = 0;
            txtBox_custID.Text = custID;
        }

        private void dtp_dob_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_dob.Value.Date >= DateTime.Today) {
                MessageBox.Show("Invalid Date Of Birth");
                dtp_dob.Value = DateTime.Today.AddDays(-1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var entity = new sdp_datebaseEntities())
            {
                var or = entity.Set<customer>();
                or.Add(new customer
                {
                    CustID = txtBox_custID.Text,
                    Surname = txtBox_surname.Text,
                    GivenName = txtBox_givenName.Text,
                    DateOfBirth = dtp_dob.Value,
                    Gender = cbBox_gender.SelectedItem.ToString(),
                    Passport = txtBox_passport.Text,
                    Contact = txtBox_contact.Text,
                    Nationality = txtBox_nationality.Text
                });

                entity.SaveChanges();
            }
            MessageBox.Show("Create customer successful");
            this.Close();
        }
    }
}
