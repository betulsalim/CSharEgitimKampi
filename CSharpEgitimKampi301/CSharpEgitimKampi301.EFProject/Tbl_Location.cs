//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharpEgitimKampi301.EFProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Location
    {
        public int location_id { get; set; }
        public string location_city { get; set; }
        public string location_country { get; set; }
        public Nullable<byte> location_capacity { get; set; }
        public Nullable<decimal> location_price { get; set; }
        public string DayNight { get; set; }
        public Nullable<int> guide_id { get; set; }
    
        public virtual Tbl_Guide Tbl_Guide { get; set; }
    }
}