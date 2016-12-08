using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_Project_WindowForm
{
    public partial class ucABooking : UserControl
    {
        decimal selectAP, selectCP, normalAP, normalCP;
        string aId, aName;
        private attr attr_cls;
        public ucABooking()
        {
            InitializeComponent();

        }

        public ucABooking(attr attr_cls, int i, string id)
        {
            InitializeComponent();

            lbl_AttractionOrderID_ucABooking.Text = id;
            this.attr_cls = attr_cls;
            lbl_AttractionName_ucABooking.Text = attr_cls.sttrBook_value[i];
            string arrName = attr_cls.sttrBook_value[i];
            using (var entity = new sdp_datebaseEntities())
            {
                var att = (from list in entity.attract_price
                           where list.AttractName == arrName
                           && list.Visitor == "Adult"
                           select list).FirstOrDefault();

                lbl_AdultPrice_ucABooking.Text = att.Price.ToString();
                normalAP = att.Price;
                aId = id;
                aName = attr_cls.sttrBook_value[i];
            }
            using (var entity = new sdp_datebaseEntities())
            {
                var att2 = (from list in entity.attract_price
                            where list.AttractName == arrName
                            && list.Visitor == "Child"
                            select list).FirstOrDefault();
                lbl_ChildPrice_ucABooking.Text = att2.Price.ToString();
                normalCP = att2.Price;
            }

        }

        private void num_AdultNum_ucABooking_ValueChanged(object sender, EventArgs e)
        {
            checkNum();
            selectAP = num_AdultNum_ucABooking.Value;
            lbl_AdultPrice_ucABooking.Text = (selectAP * normalAP).ToString();
            
        }

        private void num_ChildNum_ucABooking_ValueChanged(object sender, EventArgs e)
        {
            checkNum();
            selectCP = num_ChildNum_ucABooking.Value;
            lbl_ChildPrice_ucABooking.Text = (selectCP * normalCP).ToString();
            
        }

        public string getId()
        {
            return aId;
        }

        public string getName()
        {
            return aName;
        }

        public int getAdultNum()
        {
            return (int)num_AdultNum_ucABooking.Value;
        }

        public int getChildNum()
        {
            return (int)num_ChildNum_ucABooking.Value;
        }

        public decimal getAdultPrice()
        {
            return (num_AdultNum_ucABooking.Value * normalAP);
        }

        public decimal getChildPrice()
        {
            return (num_AdultNum_ucABooking.Value * normalCP);
        }

        private void checkNum()
        {
            if (num_AdultNum_ucABooking.Value == 0 && num_ChildNum_ucABooking.Value == 0)
            {
                MessageBox.Show("return");

                num_AdultNum_ucABooking.Value = 1;
                num_ChildNum_ucABooking.Value = 1;
                return;
            }

        }
    }
}
