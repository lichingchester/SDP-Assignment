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
    
    public partial class attraction
    {
        public attraction()
        {
            this.attract_price = new HashSet<attract_price>();
            this.attraction_order = new HashSet<attraction_order>();
        }
    
        public string AttractName { get; set; }
        public string Duration { get; set; }
        public string Cancellation { get; set; }
        public string AttractPhoto { get; set; }
        public string City { get; set; }
    
        public virtual ICollection<attract_price> attract_price { get; set; }
        public virtual ICollection<attraction_order> attraction_order { get; set; }
    }
}
