//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASPNetPostgresEF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class alertstation
    {
        public int id { get; set; }
        public Nullable<int> alertsystemid { get; set; }
        public Nullable<int> stationid { get; set; }
    }
}