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
    public partial class HotelBook : Form
    {
        private Data data;

        public HotelBook(Data data)
        {
            this.data = data;

            InitializeComponent();
            showResult();
        }

        private void showResult()
        {
            using (var entity = new sdp_datebaseEntities())
            {
                var order = (from list in entity.hotelbooking
                             select list).FirstOrDefault();
                var order_lastRow = (from list in entity.hotelbooking
                                     orderby list.HotelOrderID descending
                                     select list).FirstOrDefault();

                if (order == null)
                {
                    ht_orderID.Text = "HT000";
                }
                else
                {
                    string s = order_lastRow.HotelOrderID;
                    int i = Int32.Parse(s.Substring(2, 3));
                    i++;
                    ht_orderID.Text = "HT" + i.ToString("000");
                }
            }
            ht_chi_name.Text = data.Hotel.Hotel_chi_name;
            ht_eng_name.Text = data.Hotel.Hotel_en_name;
            ht_address.Text = data.Hotel.address;
            ht_region.Text = data.Hotel.Region;
            ht_destination.Text = data.Hotel.dest;
            ht_tel.Text = data.Hotel.tel;
            ht_star.Text = data.Hotel.Star.ToString();
            ht_room_name.Text = data.Hotel_room.Hotel_room_name;
            ht_room_description.Text = data.Hotel_room.Hotel_room_description;
            ht_price.Text = data.Hotel_room.Fare.ToString();
            ht_hotelID.Text = data.Hotel_room.HotelID;
            ht_checkIn_day.Text = data.ChekIn.ToString();
            ht_checkOut_day.Text = data.ChekOut.ToString();
            ht_day.Text = (data.ChekOut - data.ChekIn).TotalDays.ToString();
            ht_roomID.Text = data.Hotel_room.HotelRoomID;
        }

        public void insertOrder()
        {
            using (var entity = new sdp_datebaseEntities())
            {
                var ht = entity.Set<hotelbooking>();
                ht.Add(new hotelbooking
                {
                    HotelOrderID = ht_orderID.Text,
                    NumNight = data.Day,
                    HotelRoomID = data.Hotel_room.HotelRoomID,
                    Price = data.Hotel_room.Fare * (decimal)data.Day,
                    Checkin = data.ChekIn,
                    Checkout = data.ChekOut,
                    OrderID = data.Hotel_room.HotelID,
                });
                entity.SaveChanges();
            }

            data.hotelID = ht_orderID.Text;
            orderInsert or = new orderInsert("hotel", data);
        }

        private void bt_confirm_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to sumbit a new order?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                insertOrder();
            }
            else if (dr == DialogResult.No)
            {
                this.Close();
            }
            MessageBox.Show("Create new order successfully!");
            this.Close();
        }
    }
}
