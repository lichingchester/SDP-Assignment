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
    
    public partial class staff
    {
        public staff()
        {
            this.order = new HashSet<order>();
        }
    
        public string StaffID { get; set; }
        public string StaffName { get; set; }
        public string Gender { get; set; }
        public string Center { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public string Ctype { get; set; }
        public int Late { get; set; }
        public string photo { get; set; }
    
        public virtual driver_roster driver_roster { get; set; }
        public virtual ICollection<order> order { get; set; }
    }
}