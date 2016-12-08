using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Project_WindowForm
{
    public class Data
    {
        //smart result of airTicket searching
        private int smartResultMode_value;
        private flightschedule clist;
        private flightclass clist_price;
        private flightschedule qlist;
        private flightclass qlist_price;
        private flightschedule clist_return;
        private flightclass clist_return_price;
        private flightschedule qlist_return;
        private flightclass qlist_return_price;
        private string class_temp;

        public int smartResultMode {
            get { return smartResultMode_value; }
            set { smartResultMode_value = value; }
        }

        public string class_tempSG
        {
            set { class_temp = value; }
            get { return class_temp; }
        }

        public flightschedule smartResult_clist
        {
            get { return clist; }
            set { clist = value; }
        }

        public flightschedule smartResult_qlist
        {
            get { return qlist; }
            set { qlist = value; }
        }

        public flightschedule smartResult_clist_return
        {
            get { return clist_return; }
            set { clist_return = value; }
        }

        public flightschedule smartResult_qlist_return
        {
            get { return qlist_return; }
            set { qlist_return = value; }
        }

        public flightclass smartResult_clist_price
        {
            get { return clist_price; }
            set { clist_price = value; }
        }

        public flightclass smartResult_qlist_price
        {
            get { return qlist_price; }
            set { clist_price = value; }
        }

        public flightclass smartResult_clist_return_price
        {
            get { return clist_return_price; }
            set { clist_return_price = value; }
        }

        public flightclass smartResult_qlist_return_price
        {
            get { return qlist_return_price; }
            set { qlist_return_price = value; }
        }

        //booking data ---- customer & staff
        private string customerID;
        private string staffID;

        public string custID {
            get { return customerID; }
            set { customerID = value; }
        }

        public string stfID {
            get { return staffID; }
            set { staffID = value; }
        }

        //airTicket booking data
        private flightschedule airTicket_value;
        private flightschedule airTicket_return_value;
        private flightclass airTicket_price_value;
        private flightclass airTicket_return_price_value;
        private string flightOrderID_value;
        private string flightOrderID_return_value;
        private int adult;
        private int child;
        private int infant;

        public string flightOrderID {
            get { return flightOrderID_value; }
            set { flightOrderID_value = value; }
        }

        public string flightOrderID_return {
            get { return flightOrderID_return_value; }
            set { flightOrderID_return_value = value; }
        }

        public int adultNum {
            get { return adult; }
            set { adult = value; }
        }

        public int childNum {
            get { return child; }
            set { child = value; }
        }

        public int infantNum {
            get { return infant; }
            set { infant = value; }
        }

        public flightschedule airTicket {
            get { return airTicket_value; }
            set { airTicket_value = value; }
        }

        public flightschedule airTicket_return {
            get { return airTicket_return_value; }
            set { airTicket_return_value = value; }
        }

        public flightclass airTicket_price {
            get { return airTicket_price_value; }
            set { airTicket_price_value = value; }
        }

        public flightclass airTicket_return_price {
            get { return airTicket_return_price_value; }
            set { airTicket_return_price_value = value; }
        }

        ////////////////////////////////////////////////Hotel Data//////////////////////////////////////////////////////////////
        private string hotelID_value;
        private string hotelname_value;
        private hotel hotel;
        private hotel_room hotel_room;
        private DateTime checkin;
        private DateTime checkout;
        private int day;

        public string hotelID {
            get { return hotelID_value; }
            set { hotelID_value = value; }
        }

        public string hotelname
        {
            get { return hotelname_value; }
            set { hotelname_value = value; }
        }
        public hotel Hotel
        {
            get { return hotel; }
            set { hotel = value; }
        }
        public hotel_room Hotel_room
        {
            get { return hotel_room; }
            set { hotel_room = value; }
        }
        public DateTime ChekIn
        {
            get { return checkin; }
            set { checkin = value; }
        }
        public DateTime ChekOut
        {
            get { return checkout; }
            set { checkout = value; }
        }
        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        ////////////////////////////////////////////////Hotel Data//////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////Cruise Data/////////////////////////////////////////////////////////////

        private string cruise_value;

        public string cruiseID {
            get { return cruise_value; }
            set { cruise_value = value; }
        }

        ////////////////////////////////////////////////Cruise Data/////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////Attraction Data/////////////////////////////////////////////////////////////

        private string[] attrID_valur = new string[20];

        public string[] attrID {
            get { return attrID_valur; }
            set { attrID_valur = value; }
        }

        ////////////////////////////////////////////////Attraction Data/////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////Transport Data/////////////////////////////////////////////////////////////

        private string transportID_value;

        public string transportID {
            get { return transportID_value; }
            set { transportID_value = value; }
        }

        ////////////////////////////////////////////////Transport Data/////////////////////////////////////////////////////////////

    }
}
