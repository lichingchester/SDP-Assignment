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
    
    public partial class flightschedule
    {
        public flightschedule()
        {
            this.flight_booking = new HashSet<flight_booking>();
        }
    
        public string FlightID { get; set; }
        public string FlightNo { get; set; }
        public string Carrier { get; set; }
        public System.DateTime EDD { get; set; }
        public System.DateTime EDA { get; set; }
        public string ETD { get; set; }
        public string ETA { get; set; }
        public string Origin { get; set; }
        public string Dest { get; set; }
        public string Aircraft { get; set; }
        public string TravelTime { get; set; }
        public string FlightType { get; set; }
    
        public virtual carrier carrier1 { get; set; }
        public virtual ICollection<flight_booking> flight_booking { get; set; }
    }
}
