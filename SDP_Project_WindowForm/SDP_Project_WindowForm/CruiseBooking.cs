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
    public partial class CruiseBooking : Form
    {
        private Data data;
        public decimal normalP, select;
        public CruiseBooking()
        {
            InitializeComponent();
        }

        public CruiseBooking(string id, Data data)
        {
            this.data = data;

            InitializeComponent();

            lbl_CruiseID.Text = id;


            using (var entity = new sdp_datebaseEntities())
            {
                var Cur = (from list in entity.cruise
                           where list.CruiseID == id
                           select list).FirstOrDefault();

                lbl_cruiseName.Text = Cur.CruiseName;
                lbl_Price_.Text = "Price : " + Cur.RefPrice.ToString();
                normalP = Cur.RefPrice;
            }
            using (var entity = new sdp_datebaseEntities())
            {
                var order = (from list in entity.cruise_order
                             select list).FirstOrDefault();
                var order_lastRow = (from list in entity.cruise_order
                                     orderby list.CruiseOrderID descending
                                     select list).FirstOrDefault();

                if (order == null)
                {
                    lbl_CruiseOrderID.Text = "CT000";
                }
                else
                {
                    string s = order_lastRow.CruiseOrderID;
                    int i = Int32.Parse(s.Substring(2, 3));
                    i++;
                    lbl_CruiseOrderID.Text = "CT" + i.ToString("000");
                }
            }

        }

        private void num_ValueChanged(object sender, EventArgs e)
        {
            select = num.Value;
            select *= normalP;
            lbl_Price_.Text = "Price : " + select; 
        }

        private void insertOrder()
        {
            using (var entity = new sdp_datebaseEntities())
            {
                var cb = entity.Set<cruise_order>();
                cb.Add(new cruise_order
                {
                    CruiseOrderID = lbl_CruiseOrderID.Text,
                    CruiseID = lbl_CruiseID.Text,
                    Price = normalP * num.Value,
                    CustNum = (int)num.Value
                });

                entity.SaveChanges();
            }

            data.cruiseID = lbl_CruiseOrderID.Text;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            insertOrder();
            orderInsert or = new orderInsert("cruise", data);
            MessageBox.Show("Insert successful");
            this.Close();
        }
    }
}
