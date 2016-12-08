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
    public partial class MainForm : Form
    {
        Data data = new Data();

        ////attraction checking////
        Boolean attrChecking = false;

        //air ticket page searching ---- [from] comboBox
        List<string> fromSearchList_airticket = new List<string>();
        List<string> toSearchList_airticket = new List<string>();

        /// <summary>
        /// ///////////////////////////////////////////Attraction Search Page////////////////////////////////////////////////////////////////////////
        /// </summary>
        attr attr_cls = new attr();

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public MainForm()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);


        }

        public MainForm(staff stf) 
        {
            InitializeComponent();    
            try
            {
                
                tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
                data.stfID = stf.StaffID;

            }
            catch (Exception e) {
                MessageBox.Show(e.ToString());
            }

            ////////load order information///////////
        }

        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.Silver, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void reloaddata(){
            ////customer saved
            dataGridView2.Rows.Clear();
        
            using (var entity = new sdp_datebaseEntities()) {
                var row = from list in entity.order
                            where list.isTemp == data.savedID
                            select list;

                foreach (var list in row.ToList()) {
                    dataGridView2.Rows.Add(list.OrderID, list.CustID, list.StaffID, list.OrderDate.ToShortDateString(), list.FlightOrderID, list.HotelOrderID, list.AttractionOrderID,
                        list.CruiseOrderID, list.TransportOrderID, list.isTemp);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            ////customer saved

            reloaddata();

            ////for customer
            using (var entity = new sdp_datebaseEntities())
            {
                var row = (from list in entity.order
                           where list.isTemp != null
                           select list).FirstOrDefault();
                var rowLast = (from list in entity.order
                               orderby list.isTemp descending
                               select list).FirstOrDefault();

                string id;
                int i = 0;
                if (row == null)
                {
                    id = "TP000";
                }
                else
                {
                    id = rowLast.isTemp;
                    i = Int32.Parse(id.Substring(2, 3));
                    i++;
                    id = "TP" + i.ToString("000");
                }
                data.savedID = id;
            }

            lbl_savedCode_forCust.Text = data.savedID;
            lbl_savedCode_forCust2.Text = data.savedID;



            //set air Ticket search page ---- [from & to] comboBox
            using (var entity = new sdp_datebaseEntities()) {
                var loc = (from list in entity.flightschedule
                          select list.Origin).Distinct();

                foreach (var list in loc.ToList()) {
                    cbBox_fromSearch_airMF.Items.Add(list);
                }

                var dest = (from list in entity.flightschedule
                            select list.Dest).Distinct();

                foreach (var list in dest.ToList()) {
                    cbBox_toSearch_airMF.Items.Add(list);
                }
            }

            //control setting
            cbBox_classSearch_airSearchFM.SelectedIndex = 0;
            cbBox_adultSearch_airMF.SelectedIndex = 0;
            cbBox_childSearch_airMF.SelectedIndex = 0;
            cbBox_infantSearch_airMF.SelectedIndex = 0;
            rbtn_return_airSearchMF.Checked = true;
            cbBox_sequence_airSearchMF.SelectedIndex = 0;
            cbBox_sortby_airSearchMF.SelectedIndex = 0;
            gBox_oneway_airSearchMF.Height = 0;
            gBox_oneway_airSearchMF.Width = 0;
            gBox_return_airSearchMF.Height = 0;
            gBox_return_airSearchMF.Width = 0;
            ucStatuesBar1.sg_lblCustomerSelection = "Customer Selection: not selected";


            //////////////////////////////////////////////////////Transport Page//////////////////////////////////////////////////
            //VehicleType Choose
            using (var entity = new sdp_datebaseEntities())
            {
                var type = (from list in entity.vehicle
                            select list.VehicleType).Distinct();

                foreach (var list in type.ToList())
                {
                    vehicletyperange.Items.Add(list);
                }


                //Capacity choose

                var type2 = (from list in entity.vehicle
                             select list.Capacity).Distinct();

                foreach (var list in type2.ToList())
                {
                    capacityrange.Items.Add(list);
                }


                //Gear Choose
                var type3 = (from list in entity.vehicle
                             select list.Gear).Distinct();
                foreach (var list in type3.ToList())
                {
                    geartype.Items.Add(list);
                }
            }
            vehicletyperange.SelectedIndex = 0;
            geartype.SelectedIndex = 0;
            //////////////////////////////////////////////////////Transport Page//////////////////////////////////////////////////

            //////////////////////////////////////////////////////Attrachtion Page////////////////////////////////////////////////
            using (var entity = new sdp_datebaseEntities())
            {
                var attName = (from list in entity.attraction
                               select list.City).Distinct();

                foreach (var list in attName)
                {
                    cbBox_search_AttractionForm.Items.Add(list);

                }

            }
            //////////////////////////////////////////////////////Attrachtion Page////////////////////////////////////////////////

            //////////////////////////////////////////////////////Hotel Page//////////////////////////////////////////////////////
            using (var entity = new sdp_datebaseEntities())
            {
                var dest = (from list in entity.hotel
                            select list.dest).Distinct();

                foreach (var list in dest.ToList())
                {
                    cbBox_destination.Items.Add(list);
                }
                //   var hotel = (from list in entity.hotel
                //              select list.Hotel_chi_name).Distinct();

                // foreach (var list in hotel.ToList())
                //  {
                //      cbBox_Hotel.Items.Add(list);
                //  }
            }
            //////////////////////////////////////////////////////Hotal Page//////////////////////////////////////////////////////
        }

        

        private void txtBox_customerSearch_mainform_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgv_customerSearch_mainform_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) {
                return;
            }

            

        }

        private void btn_resetCustomerID_mainform_Click(object sender, EventArgs e)
        {
        }

        private void rbtn_return_airSearchMF_CheckedChanged(object sender, EventArgs e)
        {
            dtp_returnDate_airSearchMF.Enabled = true;
        }

        private void abtn_oneway_airSearchMF_CheckedChanged(object sender, EventArgs e)
        {
            dtp_returnDate_airSearchMF.Enabled = false;
        }

        private void cbBox_infantSearch_airMF_SelectedIndexChanged(object sender, EventArgs e)
        {
            int adult = cbBox_adultSearch_airMF.SelectedIndex + 1;
            int infant = cbBox_infantSearch_airMF.SelectedIndex;

            if (infant > adult) {
                MessageBox.Show("Sorry! Airlines require that there is at least one adult per infant.");
                cbBox_infantSearch_airMF.SelectedIndex = 0;
                return;
            }
        }

        

        //show the smart result of airTicket searching
        private void showAirSearchResult_cqlist(int mode) {
            if (rbtn_oneway_airSearchMF.Checked)
            {
                gBox_return_airSearchMF.Width = 0;
                gBox_return_airSearchMF.Height = 0;
                gBox_oneway_airSearchMF.Width = 916;
                gBox_oneway_airSearchMF.Height = 152;
                if (mode == 0)
                {
                    pBox_carrierPhoto_airSearchMF.Image = Image.FromFile(
                        AppDomain.CurrentDomain.BaseDirectory + @"..\..\carrierPhotos\" + data.smartResult_clist.carrier1.CarrLogo);
                    lbl_carrierName_airSearchMF.Text = data.smartResult_clist.carrier1.CarrierName;
                    lbl_departTime_airSearchMF.Text = data.smartResult_clist.ETD;
                    lbl_arrivalTime_airSearchMF.Text = data.smartResult_clist.ETA;
                    lbl_departLocation_airSearchMF.Text = data.smartResult_clist.Origin;
                    lbl_arrivalLocation_airSearchMF.Text = data.smartResult_clist.Dest;
                    lbl_travelTime_airSearchMF.Text = data.smartResult_clist.TravelTime;
                    lbl_flightNum_airSearchMF.Text = data.smartResult_clist.FlightNo;
                    lbl_aircraft_airSearchMF.Text = data.smartResult_clist.Aircraft;
                    lbl_type_airSearchMF.Text = data.smartResult_clist.FlightType;
                    string classTemp;
                    if (data.class_tempSG == "Econ")
                    {
                        classTemp = "Economy";
                    }
                    else
                    {
                        classTemp = "Business Class";
                    }
                    lbl_class_airSearchMF.Text = classTemp;
                    lbl_pp_airSearchMF.Text = "One Way";
                    using (var entity = new sdp_datebaseEntities())
                    {
                        var price = entity.flightclass.FirstOrDefault(i => (i.FlightNo == data.smartResult_clist.FlightNo && i.Class == data.class_tempSG));
                        lbl_flightPrice_airSearchMF.Text = "$" + price.Price_Adult;
                        data.smartResult_clist_price = price;
                    }
                }
                else
                {
                    pBox_carrierPhoto_airSearchMF.Image = Image.FromFile(
                        AppDomain.CurrentDomain.BaseDirectory + @"..\..\carrierPhotos\" + data.smartResult_qlist.carrier1.CarrLogo);
                    lbl_carrierName_airSearchMF.Text = data.smartResult_qlist.carrier1.CarrierName;
                    lbl_departTime_airSearchMF.Text = data.smartResult_qlist.ETD;
                    lbl_arrivalTime_airSearchMF.Text = data.smartResult_qlist.ETA;
                    lbl_departLocation_airSearchMF.Text = data.smartResult_qlist.Origin;
                    lbl_arrivalLocation_airSearchMF.Text = data.smartResult_qlist.Dest;
                    lbl_travelTime_airSearchMF.Text = data.smartResult_qlist.TravelTime;
                    lbl_flightNum_airSearchMF.Text = data.smartResult_qlist.FlightNo;
                    lbl_aircraft_airSearchMF.Text = data.smartResult_qlist.Aircraft;
                    lbl_type_airSearchMF.Text = data.smartResult_qlist.FlightType;
                    string classTemp;
                    if (data.class_tempSG == "Econ")
                    {
                        classTemp = "Economy";
                    }
                    else
                    {
                        classTemp = "Business Class";
                    }
                    lbl_class_airSearchMF.Text = classTemp; lbl_pp_airSearchMF.Text = "Return";
                    using (var entity = new sdp_datebaseEntities())
                    {
                        var price = entity.flightclass.FirstOrDefault(i => (i.FlightNo == data.smartResult_qlist.FlightNo && i.Class == data.class_tempSG));
                        lbl_flightPrice_airSearchMF.Text = "$" + price.Price_Adult;
                        data.smartResult_qlist_price = price;
                    }
                }
            }
            if(rbtn_return_airSearchMF.Checked)
            {
                gBox_oneway_airSearchMF.Width = 0;
                gBox_oneway_airSearchMF.Height = 0;
                gBox_return_airSearchMF.Width = 916;
                gBox_return_airSearchMF.Height = 152;
                if (mode == 0)
                {
                    //if (smartResult_clist_return == null) {
                    //    gBox_return_airSearchMF.Visible = false;
                    //}
                    pBox_carrierPhoto_airSearchMF_2.Image = Image.FromFile(
                        AppDomain.CurrentDomain.BaseDirectory + @"..\..\carrierPhotos\" + data.smartResult_clist.carrier1.CarrLogo);
                    lbl_carrierName_airSearchMF_2.Text = data.smartResult_clist.carrier1.CarrierName;
                    lbl_departTime_airSearchMF_2.Text = data.smartResult_clist.ETD;
                    lbl_arrivalTime_airSearchMF_2.Text = data.smartResult_clist.ETA;
                    lbl_departLocation_airSearchMF_2.Text = data.smartResult_clist.Origin;
                    lbl_arrivalLocation_airSearchMF_2.Text = data.smartResult_clist.Dest;
                    lbl_travelTime_airSearchMF_2.Text = data.smartResult_clist.TravelTime;
                    lbl_flightNum_airSearchMF_2.Text = data.smartResult_clist.FlightNo;
                    lbl_aircraft_airSearchMF_2.Text = data.smartResult_clist.Aircraft;
                    lbl_type_airSearchMF_2.Text = data.smartResult_clist.FlightType;
                    string classTemp;
                    if (data.class_tempSG == "Econ")
                    {
                        classTemp = "Economy";
                    }
                    else
                    {
                        classTemp = "Business Class";
                    }
                    lbl_class_airSearchMF_2.Text = classTemp;
                    lbl_pp_airSearchMF_2.Text = "One Way";
                    using (var entity = new sdp_datebaseEntities())
                    {
                        var price = entity.flightclass.FirstOrDefault(i => (i.FlightNo == data.smartResult_clist.FlightNo && i.Class == data.class_tempSG));
                        lbl_flightPrice_airSearchMF_2.Text = "$" + price.Price_Adult;
                        data.smartResult_clist_price = price;
                    }

                    //return part
                    pBox_carrierPhoto_airSearchMF_22.Image = Image.FromFile(
                        AppDomain.CurrentDomain.BaseDirectory + @"..\..\carrierPhotos\" + data.smartResult_clist_return.carrier1.CarrLogo);
                    lbl_carrierName_airSearchMF_22.Text = data.smartResult_clist_return.carrier1.CarrierName;
                    lbl_departTime_airSearchMF_22.Text = data.smartResult_clist_return.ETD;
                    lbl_arrivalTime_airSearchMF_22.Text = data.smartResult_clist_return.ETA;
                    lbl_departLocation_airSearchMF_22.Text = data.smartResult_clist_return.Origin;
                    lbl_arrivalLocation_airSearchMF_22.Text = data.smartResult_clist_return.Dest;
                    lbl_travelTime_airSearchMF_22.Text = data.smartResult_clist_return.TravelTime;
                    lbl_flightNum_airSearchMF_22.Text = data.smartResult_clist_return.FlightNo;
                    lbl_aircraft_airSearchMF_22.Text = data.smartResult_clist_return.Aircraft;
                    lbl_type_airSearchMF_22.Text = data.smartResult_clist_return.FlightType;
                    string classTemp2;
                    if (data.class_tempSG == "Econ")
                    {
                        classTemp2 = "Economy";
                    }
                    else
                    {
                        classTemp2 = "Business Class";
                    }
                    lbl_class_airSearchMF_22.Text = classTemp2;
                    lbl_pp_airSearchMF_22.Text = "One Way";
                    using (var entity = new sdp_datebaseEntities())
                    {
                        var price = entity.flightclass.FirstOrDefault(i => (i.FlightNo == data.smartResult_clist_return.FlightNo && i.Class == data.class_tempSG));
                        lbl_flightPrice_airSearchMF_22.Text = "$" + price.Price_Adult;
                        data.smartResult_clist_return_price = price;
                    }
                }
                else
                {
                    //if (smartResult_qlist_return == null)
                    //{
                    //    gBox_return_airSearchMF.Visible = false;
                    //}
                    pBox_carrierPhoto_airSearchMF_2.Image = Image.FromFile(
                        AppDomain.CurrentDomain.BaseDirectory + @"..\..\carrierPhotos\" + data.smartResult_qlist.carrier1.CarrLogo);
                    lbl_carrierName_airSearchMF_2.Text = data.smartResult_qlist.carrier1.CarrierName;
                    lbl_departTime_airSearchMF_2.Text = data.smartResult_qlist.ETD;
                    lbl_arrivalTime_airSearchMF_2.Text = data.smartResult_qlist.ETA;
                    lbl_departLocation_airSearchMF_2.Text = data.smartResult_qlist.Origin;
                    lbl_arrivalLocation_airSearchMF_2.Text = data.smartResult_qlist.Dest;
                    lbl_travelTime_airSearchMF_2.Text = data.smartResult_qlist.TravelTime;
                    lbl_flightNum_airSearchMF_2.Text = data.smartResult_qlist.FlightNo;
                    lbl_aircraft_airSearchMF_2.Text = data.smartResult_qlist.Aircraft;
                    lbl_type_airSearchMF_2.Text = data.smartResult_qlist.FlightType;
                    string classTemp;
                    if (data.class_tempSG == "Econ")
                    {
                        classTemp = "Economy";
                    }
                    else
                    {
                        classTemp = "Business Class";
                    }
                    lbl_class_airSearchMF_2.Text = classTemp; lbl_pp_airSearchMF.Text = "Return";
                    using (var entity = new sdp_datebaseEntities())
                    {
                        var price = entity.flightclass.FirstOrDefault(i => (i.FlightNo == data.smartResult_qlist.FlightNo && i.Class == data.class_tempSG));
                        lbl_flightPrice_airSearchMF_2.Text = "$" + price.Price_Adult;
                        data.smartResult_qlist_price = price;
                    }

                    //return part
                    pBox_carrierPhoto_airSearchMF_22.Image = Image.FromFile(
                        AppDomain.CurrentDomain.BaseDirectory + @"..\..\carrierPhotos\" + data.smartResult_qlist_return.carrier1.CarrLogo);
                    lbl_carrierName_airSearchMF_22.Text = data.smartResult_qlist_return.carrier1.CarrierName;
                    lbl_departTime_airSearchMF_22.Text = data.smartResult_qlist_return.ETD;
                    lbl_arrivalTime_airSearchMF_22.Text = data.smartResult_qlist_return.ETA;
                    lbl_departLocation_airSearchMF_22.Text = data.smartResult_qlist_return.Origin;
                    lbl_arrivalLocation_airSearchMF_22.Text = data.smartResult_qlist_return.Dest;
                    lbl_travelTime_airSearchMF_22.Text = data.smartResult_qlist_return.TravelTime;
                    lbl_flightNum_airSearchMF_22.Text = data.smartResult_qlist_return.FlightNo;
                    lbl_aircraft_airSearchMF_22.Text = data.smartResult_qlist_return.Aircraft;
                    lbl_type_airSearchMF_22.Text = data.smartResult_qlist_return.FlightType;
                    string classTemp2;
                    if (data.class_tempSG == "Econ")
                    {
                        classTemp2 = "Economy";
                    }
                    else
                    {
                        classTemp2 = "Business Class";
                    }
                    lbl_class_airSearchMF_22.Text = classTemp2;
                    lbl_pp_airSearchMF_22.Text = "One Way";
                    using (var entity = new sdp_datebaseEntities())
                    {
                        var price = entity.flightclass.FirstOrDefault(i => (i.FlightNo == data.smartResult_qlist_return.FlightNo && i.Class == data.class_tempSG));
                        lbl_flightPrice_airSearchMF_22.Text = "$" + price.Price_Adult;
                        data.smartResult_qlist_return_price = price;
                    }
                }
            }
        }

        private void btn_search_airFM_Click(object sender, EventArgs e)
        {
            btn_editSearch_airSearchMF.Enabled = true;
            gBox_searchGroup_airSearchMF.Enabled = false;
            flowLayoutPanel1.Controls.Clear();
            //get the data of search keywords
            string to_search = null;
            string from_search = null;
            DateTime departDate_search;
            DateTime returnDate_search;
            int adult_search;
            int child_search;
            int infant_search;
            string class_search = null; //Economy Business Class
            Boolean directOnly_search = false;
            string directonly_search_string = "Indirect";
            string directonly_search_string2 = "Direct";
            Boolean oneway = false;
            Boolean checkSearch = true;

            //set data of num of ACI
            data.adultNum = Int32.Parse(cbBox_adultSearch_airMF.SelectedItem.ToString());
            data.childNum = Int32.Parse(cbBox_childSearch_airMF.SelectedItem.ToString());
            data.infantNum = Int32.Parse(cbBox_infantSearch_airMF.SelectedItem.ToString());

            if(chBox_direct_airSearchMF.Checked) {
                directOnly_search = true;
                directonly_search_string = "Direct";
            }
            if (rbtn_oneway_airSearchMF.Checked)
            {
                oneway = true;
            }
            if (cbBox_fromSearch_airMF.SelectedItem == null)
            {
                checkSearch = false;
            }
            else 
            {
                from_search = cbBox_fromSearch_airMF.SelectedItem.ToString();
            }
            if (cbBox_toSearch_airMF.SelectedItem == null)
            {
                checkSearch = false;
            }
            else 
            {
                to_search = cbBox_toSearch_airMF.SelectedItem.ToString();
            }
            departDate_search = dtp_departDate_airSearchMF.Value.Date;
            //if (!oneway) {
            returnDate_search = dtp_returnDate_airSearchMF.Value.Date;
            //}
            adult_search = Int32.Parse(cbBox_adultSearch_airMF.SelectedItem.ToString());
            child_search = Int32.Parse(cbBox_childSearch_airMF.SelectedItem.ToString());
            infant_search = Int32.Parse(cbBox_infantSearch_airMF.SelectedItem.ToString());
            class_search = cbBox_classSearch_airSearchFM.SelectedItem.ToString();
            

            //MessageBox.Show("from "+from_search+" to "+to_search+" Ddate "+depart_search.ToString()+" Rdate "+return_search.ToString()+" adult "
            //    +adult_search+" child "+child_search+" class "+class_search);
            
            if (checkSearch)
            {
                
                    
                    using (var entity = new sdp_datebaseEntities())
                    {
                        string class_temp;
                        if (class_search == "Economy")
                        {
                            class_temp = "Econ";
                        }
                        else
                        {
                            class_temp = "Business";
                        }

                        //set cheapest and quickest labels
                        var clist = (from list in entity.flightschedule
                                     join list2 in entity.flightclass on list.FlightNo equals list2.FlightNo
                                     where list.Dest == to_search
                                     && (list.FlightType == directonly_search_string
                                     || list.FlightType == directonly_search_string2)
                                     && list.EDD == departDate_search
                                     && list2.Class == class_temp
                                     orderby list2.Price_Adult
                                     select list).FirstOrDefault();
                        var clist_return = entity.flightschedule.FirstOrDefault(i => (i.Origin == to_search && i.EDD == returnDate_search));

                        var qlist = (from list in entity.flightschedule
                                    where list.Dest == to_search
                                    && (list.FlightType == directonly_search_string
                                    || list.FlightType == directonly_search_string2)
                                    && list.EDD == departDate_search
                                    orderby list.TravelTime
                                    select list).FirstOrDefault();
                        var qlist_return = entity.flightschedule.FirstOrDefault(i => (i.Origin == to_search && i.EDD == returnDate_search));

                        //show the smart result
                        data.smartResult_clist = clist;
                        data.smartResult_qlist = qlist;
                        data.smartResult_clist_return = clist_return;
                        data.smartResult_qlist_return = qlist_return;
                        data.class_tempSG = class_temp;
                        showAirSearchResult_cqlist(0);

                        //check date -- oneway or return (default setting)
                        var fs = from list in entity.flightschedule
                                 join list2 in entity.flightclass on list.FlightNo equals list2.FlightNo
                                 where list.Dest == to_search
                                 && (list.FlightType == directonly_search_string
                                 || list.FlightType == directonly_search_string2)
                                 && list.EDD == departDate_search
                                 && list2.Class == class_temp
                                 orderby list.FlightNo  
                                 select list;
                        //setting of sorting
                        switch (cbBox_sortby_airSearchMF.SelectedIndex) { 
                            case 0: //default (FlightNo)
                                if (cbBox_sequence_airSearchMF.SelectedIndex == 1) {
                                    fs = from list in entity.flightschedule
                                         join list2 in entity.flightclass on list.FlightNo equals list2.FlightNo
                                         where list.Dest == to_search
                                         && (list.FlightType == directonly_search_string
                                         || list.FlightType == directonly_search_string2)
                                         && list.EDD == departDate_search
                                         && list2.Class == class_temp
                                         orderby list.FlightNo descending
                                         select list;
                                }
                                break;
                            case 1: //sorted by Price_Adult
                                if (cbBox_sequence_airSearchMF.SelectedIndex == 0)
                                {
                                    fs = from list in entity.flightschedule
                                         join list2 in entity.flightclass on list.FlightNo equals list2.FlightNo
                                         where list.Dest == to_search
                                         && (list.FlightType == directonly_search_string
                                         || list.FlightType == directonly_search_string2)
                                         && list.EDD == departDate_search
                                         && list2.Class == class_temp
                                         orderby list2.Price_Adult
                                         select list;
                                }
                                else {
                                    fs = from list in entity.flightschedule
                                         join list2 in entity.flightclass on list.FlightNo equals list2.FlightNo
                                         where list.Dest == to_search
                                         && (list.FlightType == directonly_search_string
                                         || list.FlightType == directonly_search_string2)
                                         && list.EDD == departDate_search
                                         && list2.Class == class_temp
                                         orderby list2.Price_Adult descending
                                         select list;
                                }
                                break;
                            case 2: //sorted by TravelTime
                                if (cbBox_sequence_airSearchMF.SelectedIndex == 0)
                                {
                                    fs = from list in entity.flightschedule
                                         join list2 in entity.flightclass on list.FlightNo equals list2.FlightNo
                                         where list.Dest == to_search
                                         && (list.FlightType == directonly_search_string
                                         || list.FlightType == directonly_search_string2)
                                         && list.EDD == departDate_search
                                         && list2.Class == class_temp
                                         orderby list.TravelTime
                                         select list;
                                }
                                else {
                                    fs = from list in entity.flightschedule
                                         join list2 in entity.flightclass on list.FlightNo equals list2.FlightNo
                                         where list.Dest == to_search
                                         && (list.FlightType == directonly_search_string
                                         || list.FlightType == directonly_search_string2)
                                         && list.EDD == departDate_search
                                         && list2.Class == class_temp
                                         orderby list.TravelTime descending
                                         select list;
                                }
                                break;
                            case 3: //sorted by departTime
                                if (cbBox_sequence_airSearchMF.SelectedIndex == 0)
                                {
                                    fs = from list in entity.flightschedule
                                         join list2 in entity.flightclass on list.FlightNo equals list2.FlightNo
                                         where list.Dest == to_search
                                         && (list.FlightType == directonly_search_string
                                         || list.FlightType == directonly_search_string2)
                                         && list.EDD == departDate_search
                                         && list2.Class == class_temp
                                         orderby list.ETD
                                         select list;
                                }
                                else {
                                    fs = from list in entity.flightschedule
                                         join list2 in entity.flightclass on list.FlightNo equals list2.FlightNo
                                         where list.Dest == to_search
                                         && (list.FlightType == directonly_search_string
                                         || list.FlightType == directonly_search_string2)
                                         && list.EDD == departDate_search
                                         && list2.Class == class_temp
                                         orderby list.ETD descending
                                         select list;
                                }
                                break;
                            case 4:
                                if (cbBox_sequence_airSearchMF.SelectedIndex == 0)
                                {
                                    fs = from list in entity.flightschedule
                                         join list2 in entity.flightclass on list.FlightNo equals list2.FlightNo
                                         where list.Dest == to_search
                                         && (list.FlightType == directonly_search_string
                                         || list.FlightType == directonly_search_string2)
                                         && list.EDD == departDate_search
                                         && list2.Class == class_temp
                                         orderby list.ETA
                                         select list;
                                }
                                else {
                                    fs = from list in entity.flightschedule
                                         join list2 in entity.flightclass on list.FlightNo equals list2.FlightNo
                                         where list.Dest == to_search
                                         && (list.FlightType == directonly_search_string
                                         || list.FlightType == directonly_search_string2)
                                         && list.EDD == departDate_search
                                         && list2.Class == class_temp
                                         orderby list.ETA descending
                                         select list;
                                }
                                break;
                        }
                        int sum = 0;
                        if(oneway){
                            foreach (var list in fs.ToList())
                            {
                                var row = entity.flightclass.FirstOrDefault(i => (i.Class == class_temp && i.FlightNo == list.FlightNo));
                                if (row != null)
                                {
                                    ucAirTicketSearch_MF_2 uc = new ucAirTicketSearch_MF_2(list, class_search, row, data);
                                    flowLayoutPanel1.Controls.Add(uc);
                                    sum++;
                                }
                            }
                        }else{
                            foreach (var list in fs.ToList())
                            {
                                var row = entity.flightclass.FirstOrDefault(i => (i.Class == class_temp && i.FlightNo == list.FlightNo));
                                var row_return = entity.flightschedule.FirstOrDefault(i => (i.Origin == to_search && i.EDD == returnDate_search));
                                var row_return_pricce = entity.flightclass.FirstOrDefault(
                                        i => (i.Class == class_temp && i.FlightNo == row_return.FlightNo)
                                    );
                                
                                if (row != null && row_return != null && row_return_pricce != null)
                                {
                                    ucAirTicketSearch_MF_1 uc = new ucAirTicketSearch_MF_1(list, class_search, row, row_return, row_return_pricce, data);
                                    flowLayoutPanel1.Controls.Add(uc);
                                    sum++;
                                }
                            }
                        }
                        ucStatuesBar1.sg_lblCurrentStatus = "The number of result is " + sum;
                    }
                
            }
            else {
                MessageBox.Show("The 'From' & 'To' must be inputted.");
                gBox_searchGroup_airSearchMF.Enabled = true;
                return;
            }
        }

        private void dtp_returnDate_airSearchMF_ValueChanged(object sender, EventArgs e)
        {
            DateTime depart_search = dtp_departDate_airSearchMF.Value.Date;
            DateTime return_search = dtp_returnDate_airSearchMF.Value.Date;

            if (depart_search > return_search) {
                dtp_returnDate_airSearchMF.Value = dtp_departDate_airSearchMF.Value.Date;
                return;
            }
        }

        private void dtp_departDate_airSearchMF_ValueChanged(object sender, EventArgs e)
        {
            dtp_returnDate_airSearchMF_ValueChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showAirSearchResult_cqlist(0);//clist
            data.smartResultMode = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showAirSearchResult_cqlist(1);//qlist
            data.smartResultMode = 1;
        }

        private void btn_select_airSearchMF_2_Click(object sender, EventArgs e)
        {
            


            if (data.smartResultMode == 0)
            {
                data.airTicket = data.smartResult_clist;
                data.airTicket_price = data.smartResult_clist_price;
                data.airTicket_return = data.smartResult_clist_return;
                data.airTicket_return_price = data.smartResult_clist_return_price;
                data.adultNum = Int32.Parse(cbBox_adultSearch_airMF.SelectedItem.ToString());
                data.childNum = Int32.Parse(cbBox_childSearch_airMF.SelectedItem.ToString());
                data.infantNum = Int32.Parse(cbBox_infantSearch_airMF.SelectedItem.ToString());
            }
            else
            {
                data.airTicket = data.smartResult_qlist;
                data.airTicket_price = data.smartResult_qlist_price;
                data.airTicket_return = data.smartResult_qlist_return;
                data.airTicket_return_price = data.smartResult_qlist_return_price;
                data.adultNum = Int32.Parse(cbBox_adultSearch_airMF.SelectedItem.ToString());
                data.childNum = Int32.Parse(cbBox_childSearch_airMF.SelectedItem.ToString());
                data.infantNum = Int32.Parse(cbBox_infantSearch_airMF.SelectedItem.ToString());
            }
            new airTicketBooking(0, data).ShowDialog();
        }

        private void btn_select_airSearchMF_Click(object sender, EventArgs e)
        {
           

            if (data.smartResultMode == 0)
            {
                data.airTicket = data.smartResult_clist;
                data.airTicket_price = data.smartResult_clist_price;
                data.adultNum = Int32.Parse(cbBox_adultSearch_airMF.SelectedItem.ToString());
                data.childNum = Int32.Parse(cbBox_childSearch_airMF.SelectedItem.ToString());
                data.infantNum = Int32.Parse(cbBox_infantSearch_airMF.SelectedItem.ToString());
            }
            else
            {
                data.airTicket = data.smartResult_qlist;
                data.airTicket_price = data.smartResult_qlist_price;
                data.adultNum = Int32.Parse(cbBox_adultSearch_airMF.SelectedItem.ToString());
                data.childNum = Int32.Parse(cbBox_childSearch_airMF.SelectedItem.ToString());
                data.infantNum = Int32.Parse(cbBox_infantSearch_airMF.SelectedItem.ToString());
            }
            new airTicketBooking(data).ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox_testing_airSearchMF.Checked)
            {
                cbBox_fromSearch_airMF.SelectedIndex = 0;
                cbBox_toSearch_airMF.SelectedIndex = 0;
                dtp_departDate_airSearchMF.Value = new DateTime(2015, 06, 20);
                dtp_returnDate_airSearchMF.Value = new DateTime(2015, 06, 25);
            }
            else {
                cbBox_fromSearch_airMF.SelectedIndex = -1;
                cbBox_toSearch_airMF.SelectedIndex = -1;
                dtp_departDate_airSearchMF.Value = DateTime.Today;
                dtp_returnDate_airSearchMF.Value = DateTime.Today;

            }
        }

        private void btn_editSearch_airSearchMF_Click(object sender, EventArgs e)
        {
            gBox_searchGroup_airSearchMF.Enabled = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex) { 
                case 1:
                    ucStatuesBar1.sg_lblCurrentStatus = "  Air Ticket Search ready";
                    break;
                case 2:
                    ucStatuesBar1.sg_lblCurrentStatus = "  Hotel Search ready";
                    break;
                case 3:
                    ucStatuesBar1.sg_lblCurrentStatus = "  Cruise Search ready";
                    break;
                case 4:
                    ucStatuesBar1.sg_lblCurrentStatus = "  Attraction Search ready";
                    break;
                case 5:
                    ucStatuesBar1.sg_lblCurrentStatus = "  Transport Searh ready";
                    break;
                case 6:
                    ucStatuesBar1.sg_lblCurrentStatus = "  Customer Saved Search ready";
                    reloaddata();
                    break;
                case 7:
                    ucStatuesBar1.sg_lblCurrentStatus = "  Order Information ready";
                    break;
                case 8:
                    ucStatuesBar1.sg_lblCurrentStatus = "  Data Report ready";
                    break;

            }
        }

        private void btn_search_transportSearchMF_Click(object sender, EventArgs e)
        {
            int capacitychoose;
            string vehicletypechoose;
            string geartypechoose;
            decimal pricechoose;

            panel1.Controls.Clear();


            vehicletypechoose = vehicletyperange.SelectedItem.ToString();


            if (capacityrange.SelectedItem == null)
            {
                capacitychoose = 100;
            }
            else
            {
                capacitychoose = Int32.Parse(capacityrange.SelectedItem.ToString());
            }


            geartypechoose = geartype.SelectedItem.ToString();


            if (pricerange.Text == "")
            {
                pricechoose = (decimal)1500;
            }
            else
            {
                pricechoose = Convert.ToDecimal(pricerange.Text.ToString());
            }

            using (var data1 = new sdp_datebaseEntities())
            {
                var data2 = from list in data1.vehicle
                            where list.VehicleType == vehicletypechoose
                            && list.Capacity <= capacitychoose
                            && list.Price <= pricechoose
                            && list.Gear == geartypechoose
                            select list;

                foreach (var list in data2.ToList())
                {
                    TransportBooking uc = new TransportBooking(list, data);
                    panel1.Controls.Add(uc);
                }


            }
        }

        private void vehicletyperange_SelectedIndexChanged(object sender, EventArgs e)
        {
            capacityrange.Items.Clear();
            using (var entity = new sdp_datebaseEntities())
            {
                var type = (from list in entity.vehicle
                            where list.VehicleType == vehicletyperange.SelectedItem
                            select list.Capacity).Distinct();

                foreach (var list in type.ToList())
                {
                    capacityrange.Items.Add(list);
                }
            }
        }

        private void btm_search_AttractionForm_Click(object sender, EventArgs e)
        {
            attrChecking = true;
            flowLayoutPanel2.Controls.Clear();
            attr_cls.clear();
            String keyword = cbBox_search_AttractionForm.Text;

            using (var entity = new sdp_datebaseEntities())
            {

                var att = (from list in entity.attraction
                           //            join list2 in entity.attract_price on list.AttractName equals list2.AttractName
                           where list.City.Contains(keyword)
                           select list);
                foreach (var list in att.ToList())
                {
                    ucAForm ucA = new ucAForm(list, attr_cls);
                    flowLayoutPanel2.Controls.Add(ucA);

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean checking_attr = false;
            for (int i = 0; i < 20; i++)
            {
                if (attr_cls.attrID_value[i] != null)
                {
                    checking_attr = true;
                }
            }

            //if (data.custID == null)
            //{
            //    MessageBox.Show("You have to select a customer!");
            //    return;
            //}
            if (!attrChecking || flowLayoutPanel2.Controls == null)
            {
                MessageBox.Show("You have to search first!");
                return;
            }
            if (checking_attr)
            {
                new AttractionBooking(attr_cls, data).ShowDialog();
            }
            else {
                MessageBox.Show("You have to select at least one attractions!");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            flowLayoutPanel3.Controls.Clear();
            DateTime theDate = selectDate.Value.Date;

            String keyword = txt_search_CForm.Text;
            using (var entity = new sdp_datebaseEntities())
            {
                var day1 = (from list in entity.cruise
                            where list.StartDate >= theDate
                            orderby list.TourDay
                            select list);

                if (keyword != "")
                {
                    day1 = (from list in entity.cruise
                            where (list.StartDate >= theDate
                            && list.OrganID == keyword)
                            || (list.StartDate >= theDate
                            && list.CruiseName.Contains(keyword))
                            || (list.StartDate >= theDate
                            && list.CruiseID == keyword)
                            orderby list.TourDay
                            select list);
                    ;
                }

                foreach (var list in day1.ToList())
                {
                    ucCForm uc = new ucCForm(list, data);
                    flowLayoutPanel3.Controls.Add(uc);
                }


            }
        }

        /////////////////////////////////////////////////////////////////Hotal Search Page///////////////////////////////////////////////////////////////////////
        
        private void cbBox_destination_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cbBox_Hotel.Items.Clear();
            using (var entity = new sdp_datebaseEntities())
            {
                var Hotel = (from list in entity.hotel
                             where list.dest == cbBox_destination.SelectedItem
                             select list.Hotel_chi_name).Distinct();

                //  foreach (var list in Hotel.ToList())
                //  {
                //     cbBox_Hotel.Items.Add(list);
                // }
            }
        }

        private void dateTimePicker_CheckOut_ValueChanged(object sender, EventArgs e)
        {
            DateTime depart_search = dateTimePicker_CheckIn.Value.Date;
            DateTime return_search = dateTimePicker_CheckOut.Value.Date;

            if (depart_search > return_search)
            {
                dateTimePicker_CheckIn.Value = dateTimePicker_CheckIn.Value.Date;
                return;
            }
        }

        private void dateTimePicker_CheckIn_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_CheckOut_ValueChanged(sender, e);
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string destination;
            if (cbBox_destination.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select a destination");
                return;
            }
            else
            {
                destination = cbBox_destination.SelectedItem.ToString();
            }
            DateTime checkinDate = dateTimePicker_CheckIn.Value.Date;
            DateTime checkoutDate = dateTimePicker_CheckOut.Value.Date;
            // string hotels = cbBox_Hotel.SelectedItem.ToString();

            flowLayoutPanel4.Controls.Clear();
            data.ChekIn = checkinDate;
            data.ChekOut = checkoutDate;
            data.Day = (int)((checkoutDate - checkinDate).TotalDays);

            using (var entity = new sdp_datebaseEntities())
            {
                var ht = (from list in entity.hotel
                          //join list2 in entity.hotel_room on list.HotelID equals list2.HotelID
                          where list.dest == destination
                          select list);

                foreach (var list in ht.ToList())
                {
                    // var price = entity.hotel_room.FirstOrDefault(i => (i.Hotel_chi_name == list.Hotel_chi_name));
                    UCHotel uc = new UCHotel(list, data, this);
                    flowLayoutPanel4.Controls.Add(uc);
                }
            }
        }
        
        public void hotelChecking()
        {
            flowLayoutPanel5.Controls.Clear();
            using (var entity = new sdp_datebaseEntities())
            {
                var row = from list in entity.hotel_room
                          where list.Hotel_chi_name == data.hotelname
                          select list;

                foreach (var list in row.ToList())
                {
                    UCHotelSelect uc = new UCHotelSelect(list, data);
                    flowLayoutPanel5.Controls.Add(uc);
                }
            }
        }

        private void btn_createUser_mainform_Click(object sender, EventArgs e)
        {
        }

        private void btn_logout_mainform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_updateUser_mainform_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_deleteUser_mainform_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_logout_mainform_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reloaddata();
        }
        
       
        /////////////////////////////////////////////////////////////////Hotal Search Page///////////////////////////////////////////////////////////////////////
       
    }
}
