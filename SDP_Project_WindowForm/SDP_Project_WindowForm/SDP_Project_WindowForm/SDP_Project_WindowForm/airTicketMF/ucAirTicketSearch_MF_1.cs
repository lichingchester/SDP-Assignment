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
    public partial class ucAirTicketSearch_MF_1 : UserControl
    {
        private Data data;
        private flightschedule fs;
        private flightclass fc;
        private flightschedule fs_return;
        private flightclass fc_return;

        public ucAirTicketSearch_MF_1()
        {
            InitializeComponent();
        }

        public ucAirTicketSearch_MF_1(flightschedule fs, string class_search, flightclass fc, flightschedule fs_return, flightclass fc_return, Data data)
        {
            InitializeComponent();

            this.data = data;

            lbl_pp_airSearchMF.Text = "Return";
            lbl_pp_airSearchMF_2.Text = "Return";

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

            lbl_flightNum_airSearchMF_2.Text = fs_return.FlightNo;
            lbl_aircraft_airSearchMF_2.Text = fs_return.Aircraft;
            pBox_carrierPhoto_airSearchMF_2.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"..\..\carrierPhotos\" + fs_return.carrier1.CarrLogo);
            lbl_carrierName_airSearchMF_2.Text = fs_return.carrier1.CarrierName;
            lbl_departTime_airSearchMF_2.Text = fs_return.ETD;
            lbl_arrivalTime_airSearchMF_2.Text = fs_return.ETA;
            lbl_departLocation_airSearchMF_2.Text = fs_return.Origin;
            lbl_arrivalLocation_airSearchMF_2.Text = fs_return.Dest;
            lbl_travelTime_airSearchMF_2.Text = fs_return.TravelTime;
            lbl_class_airSearchMF_2.Text = class_search;
            lbl_type_airSearchMF_2.Text = fs_return.FlightType;
            lbl_flightPrice_airSearchMF_2.Text = "$" + fc_return.Price_Adult.ToString();

            this.fs = fs;
            this.fc = fc;
            this.fs_return = fs_return;
            this.fc_return = fc_return;
        }

        private void btn_select_airSearchMF_Click(object sender, EventArgs e)
        {
            if (data.custID == null) {
                MessageBox.Show("You have to select a customer!");
                return;
            }

            data.airTicket = fs;
            data.airTicket_price = fc;
            data.airTicket_return = fs_return;
            data.airTicket_return_price = fc_return;
            new airTicketBooking(0, data).ShowDialog();
        }
    }
}
