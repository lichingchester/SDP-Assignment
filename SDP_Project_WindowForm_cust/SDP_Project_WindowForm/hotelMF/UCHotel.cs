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
    public partial class UCHotel : UserControl
    {
        private Data data;
        private MainForm mf;

        public UCHotel()
        {
            InitializeComponent();
        }

        public UCHotel(hotel list, Data data, MainForm mf)
        {
            InitializeComponent();
            this.data = data;
            this.mf = mf as MainForm;

            using (var entity = new sdp_datebaseEntities())
            {
                var room = (from list2 in entity.hotel_room
                            where list2.HotelID == list.HotelID
                            orderby list2.Hotel_room_description
                            select list2).FirstOrDefault();
                HotelChiName.Text = list.Hotel_chi_name.ToString();
                HotelEngName.Text = list.Hotel_en_name.ToString();
                HotelAddress.Text = list.address.ToString();
                if (list.tel != null)
                {
                    Tel.Text = list.tel.ToString();
                }
                Rate.Text = list.Rating.ToString();
                HotelStar.Text = list.Star.ToString();
                HotelPrice.Text = "$" + room.Fare.ToString();
            }
        }

        private void Select_button_Click(object sender, EventArgs e)
        {
            string ht_chi_name = HotelChiName.Text;
            string ht_eng_name = HotelEngName.Text;
            string ht_address = HotelAddress.Text;
            string ht_star = HotelStar.Text;

            data.hotelname = HotelChiName.Text;
            using (var entity = new sdp_datebaseEntities())
            {
                var hotel = (from list in entity.hotel
                             where list.Hotel_chi_name == ht_chi_name
                             select list).FirstOrDefault();

                data.Hotel = hotel;
            }

            mf.hotelChecking();
        }
    }
}
