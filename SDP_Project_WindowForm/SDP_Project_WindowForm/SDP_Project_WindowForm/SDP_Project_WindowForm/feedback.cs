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
    
    public partial class feedback
    {
        public string FeedBackID { get; set; }
        public string CustomerID { get; set; }
        public System.DateTime Date { get; set; }
        public int Mark { get; set; }
        public string Content { get; set; }
    
        public virtual customer customer { get; set; }
    }
}