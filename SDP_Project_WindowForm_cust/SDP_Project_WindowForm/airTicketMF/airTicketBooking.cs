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
    public partial class airTicketBooking : Form
    {
        private Data data;
        private decimal adult_price;
        private decimal child_price;
        private decimal infant_price;
        private Boolean returnMode = false; 

        public airTicketBooking(Data data)
        {
            this.data = data;

            InitializeComponent();
            showRepartResult(0);
            gBox_showReturn_airBooking.Visible = false;
            this.Height = 505;
        }

        public airTicketBooking(int i, Data data) 
        {
            this.data = data;

            InitializeComponent();
            showRepartResult(1);
            showReturnResult();
            gBox_showReturn_airBooking.Visible = true;
            returnMode = true;

        }

        private void showRepartResult(int DRmode) {

            lbl_custID_airBooking.Text = data.custID;
            ucStatuesBar1.sg_lblCurrentStatus = "  Air Ticket Booking Confirm";

            using (var entity = new sdp_datebaseEntities())
            {
                var order = (from list in entity.flight_booking
                            select list).FirstOrDefault();
                var order_lastRow = (from list in entity.flight_booking
                                     orderby list.FlightOrderID descending
                                     select list).FirstOrDefault();

                if (order == null)
                {
                    lbl_orderID_airBooking.Text = "AT000";
                }
                else {
                    string s = order_lastRow.FlightOrderID;
                    int i = Int32.Parse(s.Substring(2, 3));
                    i++;
                    lbl_orderID_airBooking.Text = "AT" + i.ToString("000");
                }
            }
                
            lbl_flightNum_airBooking.Text = data.airTicket.FlightNo;
            lbl_aircraft_airBooking.Text = data.airTicket.Aircraft;
            lbl_type_airBooking.Text = data.airTicket.FlightType;
            if (DRmode == 0)
            {
                lbl_pp_airBooking.Text = "One Way";
            }
            else {
                lbl_pp_airBooking.Text = "Return";
            }
            string classTemp;
            if (data.class_tempSG == "Econ")
            {
                classTemp = "Economy";
            }
            else
            {
                classTemp = "Business Class";
            }
            lbl_class_airBooking.Text = classTemp;
            lbl_travelTime_airBooking.Text = data.airTicket.TravelTime;
            lbl_departTime_airBooking.Text = data.airTicket.ETD;
            lbl_arrivalTime_airBooking.Text = data.airTicket.ETA;
            lbl_departLocation_airBooking.Text = data.airTicket.Origin;
            lbl_arrivalLocation_airBooking.Text = data.airTicket.Dest;
            lbl_departDate_airBooking.Text = data.airTicket.EDD.ToShortDateString();
            lbl_arrivalDate_airBooking.Text = data.airTicket.EDA.ToShortDateString();
            lbl_adultNum_airBooking.Text = data.adultNum.ToString();
            lbl_childNum_airBooking.Text = data.childNum.ToString();
            lbl_infantNum_airBooking.Text = data.infantNum.ToString();
            lbl_adultPrice_airBooking.Text = data.airTicket_price.Price_Adult.ToString();
            lbl_childPrice_airBooking.Text = data.airTicket_price.Price_Infant.ToString();
            lbl_infantPrice_airBooking.Text = data.airTicket_price.Price_Infant.ToString();
            lbl_carrierName_airBooking.Text = data.airTicket.carrier1.CarrierName;
            adult_price = data.airTicket_price.Price_Adult;
            child_price = data.airTicket_price.Price_Children;
            infant_price = data.airTicket_price.Price_Infant;
            lbl_totalPrice_airBooking.Text = ((decimal)data.adultNum * adult_price + (decimal)data.childNum * child_price + (decimal)data.infantNum * infant_price).ToString();
            
        }

        private void showReturnResult() {
            using (var entity = new sdp_datebaseEntities())
            {
                var order = (from list in entity.flight_booking
                             select list).FirstOrDefault();
                var order_lastRow = (from list in entity.flight_booking
                                     orderby list.FlightOrderID descending
                                     select list).FirstOrDefault();

                if (order == null)
                {
                    lbl_orderID_airBooking2.Text = "AT001";
                }
                else
                {
                    string s = order_lastRow.FlightOrderID;
                    int i = Int32.Parse(s.Substring(2, 3));
                    i += 2;
                    lbl_orderID_airBooking2.Text = "AT" + i.ToString("000");
                }
            }

            lbl_flightNum_airBooking2.Text = data.airTicket_return.FlightNo;
            lbl_aircraft_airBooking2.Text = data.airTicket_return.Aircraft;
            lbl_type_airBooking2.Text = data.airTicket_return.FlightType;
            lbl_pp_airBooking2.Text = "Return";
            string classTemp;
            if (data.class_tempSG == "Econ")
            {
                classTemp = "Economy";
            }
            else
            {
                classTemp = "Business Class";
            }
            lbl_class_airBooking2.Text = classTemp;
            lbl_travelTime_airBooking2.Text = data.airTicket_return.TravelTime;
            lbl_departTime_airBooking2.Text = data.airTicket_return.ETD;
            lbl_arrivalTime_airBooking2.Text = data.airTicket_return.ETA;
            lbl_departLocation_airBooking2.Text = data.airTicket_return.Origin;
            lbl_arrivalLocation_airBooking2.Text = data.airTicket_return.Dest;
            lbl_departDate_airBooking2.Text = data.airTicket_return.EDD.ToShortDateString();
            lbl_arrivalDate_airBooking2.Text = data.airTicket_return.EDA.ToShortDateString();
            lbl_adultNum_airBooking2.Text = data.adultNum.ToString();
            lbl_childNum_airBooking2.Text = data.childNum.ToString();
            lbl_infantNum_airBooking2.Text = data.infantNum.ToString();
            lbl_adultPrice_airBooking2.Text = data.airTicket_return_price.Price_Adult.ToString();
            lbl_childPrice_airBooking2.Text = data.airTicket_return_price.Price_Infant.ToString();
            lbl_infantPrice_airBooking2.Text = data.airTicket_return_price.Price_Infant.ToString();
            lbl_carrierName_airBooking2.Text = data.airTicket_return.carrier1.CarrierName;
            adult_price = data.airTicket_return_price.Price_Adult;
            child_price = data.airTicket_return_price.Price_Children;
            infant_price = data.airTicket_return_price.Price_Infant;
            lbl_totalPrice_airBooking2.Text = ((decimal)data.adultNum * adult_price + (decimal)data.childNum * child_price + (decimal)data.infantNum * infant_price).ToString();
            
        }

        private void btn_Confirm_airBooking_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to submit a new order?(temp)", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                insertOrder();
                if (returnMode)
                {
                    orderInsert oi = new orderInsert(1, data);
                }
                else {
                    orderInsert oi = new orderInsert(0, data);
                }
                MessageBox.Show("Create new order successfully.");
            }
            else if (dr == DialogResult.No)
            {
                this.Close();
            }
            
            this.Close();
        }

        private void insertOrder() {
            using (var entity = new sdp_datebaseEntities()) {
                var fb = entity.Set<flight_booking>();
                fb.Add(new flight_booking
                {
                    FlightOrderID = lbl_orderID_airBooking.Text,
                    FlightID = data.airTicket.FlightID,
                    FlightClassID = data.airTicket_price.flightclass_id,
                    AdultPrice = data.airTicket_price.Price_Adult * (decimal)data.adultNum,
                    ChildPrice = data.airTicket_price.Price_Children * (decimal)data.childNum,
                    InfantPrice = data.airTicket_price.Price_Infant * (decimal)data.infantNum,
                    AdultNum = data.adultNum,
                    ChildNum = data.childNum,
                    InfantNum = data.infantNum,
                    totalPrice = Convert.ToDecimal(lbl_totalPrice_airBooking.Text),
                    idReturn = "0"
                });

                if (returnMode) {
                    fb.Add(new flight_booking
                    {
                        FlightOrderID = lbl_orderID_airBooking2.Text,
                        FlightID = data.airTicket_return.FlightID,
                        FlightClassID = data.airTicket_return_price.flightclass_id,
                        AdultPrice = data.airTicket_return_price.Price_Adult * (decimal)data.adultNum,
                        ChildPrice = data.airTicket_return_price.Price_Children * (decimal)data.childNum,
                        InfantPrice = data.airTicket_return_price.Price_Infant * (decimal)data.infantNum,
                        AdultNum = data.adultNum,
                        ChildNum = data.childNum,
                        InfantNum = data.infantNum,
                        totalPrice = Convert.ToDecimal(lbl_totalPrice_airBooking2.Text),
                        idReturn = "1"
                    });
                }

                entity.SaveChanges();
            }

            data.flightOrderID = lbl_orderID_airBooking.Text;
            if (returnMode) {
                data.flightOrderID_return = lbl_orderID_airBooking2.Text;
            }
        }
    }
}
