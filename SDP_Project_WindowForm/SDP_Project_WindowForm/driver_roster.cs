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
    
    public partial class driver_roster
    {
        public string StaffID { get; set; }
        public int weekdayTS { get; set; }
        public int weekendTS { get; set; }
    
        public virtual staff staff { get; set; }
    }
}
