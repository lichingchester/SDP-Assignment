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
    public partial class ucAirTicketSearch_MF_2 : UserControl
    {
        private Data data;
        private flightschedule fs;
        private flightclass fc;

        public ucAirTicketSearch_MF_2()
        {
            InitializeComponent();
        }

        public ucAirTicketSearch_MF_2(flightschedule fs, string class_search, flightclass fc, Data data) {
            InitializeComponent();

            this.data = data;
            this.fs = fs;
            this.fc = fc;

            lbl_pp_airSearchMF.Text = "One way";
            lbl_flightNum_airSearchMF.Text = fs.FlightNo;
            lbl_aircraft_airSearchMF.Text = fs.Aircraft;
            pBox_carrierPhoto_airSearchMF.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"..\..\carrierPhotos\" + fs.carrier1.CarrLogo);
            lbl_carrierName_airSearchMF.Text = fs.carrier1.CarrierName;
            lbl_departTime_airSearchMF.Text = fs.ETD;
            lbl_arrivalTime_airSearchMF.Text = fs.ETA;
            lbl_departLocation_airSearchMF.Text = fs.Origin;
            lbl_arrivalLocation_airSearchMF.Text = fs.Dest;
            lbl_travelTime_airSearchMF.Text = fs.TravelTime;
            lbl_class_airSearchMF.Text = class_search;
            lbl_type_airSearchMF.Text = fs.FlightType;
            lbl_flightPrice_airSearchMF.Text = "$" + fc.Price_Adult.ToString();

        }

        private void btn_select_airSearchMF_Click(object sender, EventArgs e)
        {
            if (data.custID == null)
            {
                MessageBox.Show("You have to select a customer!");
                return;
            }
            data.airTicket = fs;
            data.airTicket_price = fc;
            new airTicketBooking(data).ShowDialog();
        }
    }
}
