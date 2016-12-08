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
    public partial class ucAForm : UserControl
    {
        private attr attr_cls;
        public string attcName;

        public ucAForm()
        {
            InitializeComponent();
        }

        private string obj_attr_value;
        private string obj_attr
        {
            get { return obj_attr_value; }
            set { obj_attr_value = value; }
        }

        private string attrID;
        private string attrID_value
        {
            get { return attrID; }
            set { attrID = value; }
        }

        public ucAForm(attraction list, attr attr_cls)
        {
            this.attr_cls = attr_cls;
            InitializeComponent();
            using (var entity = new sdp_datebaseEntities())
            {
                var attP = (from list2 in entity.attract_price
                            where list2.AttractName == list.AttractName
                            select list2).FirstOrDefault();

                pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory
                    + @"..\..\AttractionPhotos\" + list.AttractPhoto + ".png");
                lbl_AttactionName_ucAForm.Text = list.AttractName;
                lbl_Cancellation_ucAForm.Text = "Cancellation : " + list.Cancellation;
                lbl_Durationl_ucAForm.Text = "Duration : " + list.Duration;
                lbl_Price_ucAForm.Text = "Price : " + attP.Price.ToString();
                lbl_Visitor_ucAForm.Text = "Visitor : " + attP.Visitor;

                obj_attr = list.AttractName;

                var order = (from list3 in entity.attraction_order
                             select list3).FirstOrDefault();
                var order_lastRow = (from list3 in entity.attraction_order
                                     orderby list3.AttractionOrderID descending
                                     select list3).FirstOrDefault();

                if (order == null)
                {
                    attrID_value = "AB000";
                }
                else
                {
                    string s = order_lastRow.AttractionOrderID;
                    int i = Int32.Parse(s.Substring(2, 3));
                    i += 2;
                    attrID_value = "AB" + i.ToString("000");
                }
            }

            using (var entity2 = new sdp_datebaseEntities())
            {
                var attP2 = (from list2 in entity2.attract_price
                             where list2.AttractName == list.AttractName
                             && list2.Visitor == "Child"
                             select list2).FirstOrDefault();
                lbl_Visitor2_ucAForm.Text = "Visitor : " + attP2.Visitor;
                lbl_Price2_ucAForm.Text = "Price : " + attP2.Price.ToString();


            }
        }

        private void chBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox.Checked)
            {
                for (int i = 0; i < attr_cls.sttrBook_value.Length; i++)
                {
                    if (attr_cls.sttrBook_value[i] == null)
                    {
                        attr_cls.sttrBook_value[i] = obj_attr;
                        attr_cls.attrID_value[i] = attrID_value;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < attr_cls.sttrBook_value.Length; i++)
                {
                    if (attr_cls.sttrBook_value[i] == lbl_AttactionName_ucAForm.Text)
                    {
                        attr_cls.sttrBook_value[i] = null;
                        attr_cls.attrID_value[i] = null;
                        break;
                    }
                }
            }
        }
    }
}
