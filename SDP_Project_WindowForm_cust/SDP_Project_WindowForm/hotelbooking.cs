//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDP_Project_WindowForm
{
    using System;
    using System.Collections.Generic;
    
    public partial class hotelbooking
    {
        public hotelbooking()
        {
            this.order = new HashSet<order>();
        }
    
        public string HotelOrderID { get; set; }
        public int NumNight { get; set; }
        public string HotelRoomID { get; set; }
        public decimal Price { get; set; }
        public System.DateTime Checkin { get; set; }
        public System.DateTime Checkout { get; set; }
        public string OrderID { get; set; }
    
        public virtual hotel_room hotel_room { get; set; }
        public virtual ICollection<order> order { get; set; }
    }
}
