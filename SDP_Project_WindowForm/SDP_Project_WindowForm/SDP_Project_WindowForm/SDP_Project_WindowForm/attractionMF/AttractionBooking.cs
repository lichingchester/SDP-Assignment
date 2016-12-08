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
    public partial class AttractionBooking : Form
    {
        private Data data;

        private string attrID;
        private attr ucabooking = new attr();
        private attr attr_cls;
        public AttractionBooking()
        {
            InitializeComponent();
        }

        public AttractionBooking(attr attr_cls, Data data)
        {
            this.data = data;

            InitializeComponent();

            flowLayoutPanel1.Controls.Clear();

            using (var entity = new sdp_datebaseEntities())
            {
                var lastrow = (from list in entity.attraction_order
                               orderby list.AttractionOrderID descending
                               select list).FirstOrDefault();
                if (lastrow == null)
                {
                    attrID = "AB000";
                }
                else
                {
                    //string s = lastrow.AttractionOrderID;
                    //int i = Int32.Parse(s.Substring(2, 3));
                    //i += 2;
                    //attrID = "AB" + i.ToString("000");
                    attrID = lastrow.AttractionOrderID;
                    int j = Int32.Parse(attrID.Substring(2, 3));
                    j++;
                    attrID = "AB" + j.ToString("000");
                }
            }

            this.attr_cls = attr_cls;
            int l;
            for (int i = 0; i < 20; i++)
            {
                if (attr_cls.sttrBook_value[i] != null)
                {
                    string s = attrID;
                    l = Int32.Parse(s.Substring(2, 3));
                    string id = "AB" + (l + i).ToString("000");

                    ucABooking ucAB = new ucABooking(attr_cls, i, id);
                    ucabooking.getUCA[i] = ucAB;

                    flowLayoutPanel1.Controls.Add(ucAB);


                }
            }
        }

        private void btn_confirm_AttractionBooking_Click(object sender, EventArgs e)
        {
            using (var entity = new sdp_datebaseEntities())
            {
                var ab = entity.Set<attraction_order>();

                for (int i = 0; i < 20; i++)
                {
                    if (ucabooking.getUCA[i] != null)
                    {
                        ab.Add(new attraction_order
                        {
                            AttractionOrderID = ucabooking.getUCA[i].getId(),
                            AttractionName = ucabooking.getUCA[i].getName(),
                            AdultNum = ucabooking.getUCA[i].getAdultNum(),
                            ChildNum = ucabooking.getUCA[i].getChildNum(),
                            AdultPrice = ucabooking.getUCA[i].getAdultPrice(),
                            ChildPrice = ucabooking.getUCA[i].getChildPrice(),
                        });
                        data.attrID[i] = ucabooking.getUCA[i].getId(); 
                    }
                }

                entity.SaveChanges();
                MessageBox.Show("Insert successful");
                this.Close();
            }

            orderInsert or = new orderInsert("attraction", data);
        }
    }
}
