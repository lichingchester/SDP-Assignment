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
    public partial class UCHotelSelect : UserControl
    {
        private Data data;

        public UCHotelSelect()
        {
            InitializeComponent();
        }

        public UCHotelSelect(int i)
        {

            //ht_room_name.Text = "test";
        }


        public UCHotelSelect(hotel_room list, Data data)
        {
            InitializeComponent();
            this.data = data;
            ht_room_name.Text = list.Hotel_room_name.ToString();
            ht_room_type.Text = list.Hotel_room_description.ToString();
            ht_room_size.Text = list.Hotel__room_size.ToString();
            ht_audults.Text = "Max audults:" + list.max_audults.ToString();
            ht_child.Text = "Max child:" + list.max_child.ToString();
            ht_price.Text = list.Fare.ToString();

        }

        private void ht_book_Click(object sender, EventArgs e)
        {
            

            using (var entity = new sdp_datebaseEntities())
            {
                var hotel = (from list in entity.hotel_room
                             where list.Hotel_room_name == ht_room_name.Text
                             select list).FirstOrDefault();

                data.Hotel_room = hotel;
            }
            new HotelBook(data).ShowDialog();
            
        }
    }
}
