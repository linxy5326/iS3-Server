//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iS3.Server.Models.Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Geology_RiverWater
    {
        public int ID { get; set; }
        public string ObservationLocation { get; set; }
        public Nullable<double> HighestTidalLevel { get; set; }
        public Nullable<System.DateTime> HighestTidalLevelDate { get; set; }
        public Nullable<double> LowestTidalLevel { get; set; }
        public Nullable<System.DateTime> LowestTidalLevelDate { get; set; }
        public Nullable<double> AvHighTidalLevel { get; set; }
        public Nullable<double> AvLowTidalLevel { get; set; }
        public Nullable<double> AvTidalRange { get; set; }
        public string DurationOfRise { get; set; }
        public string DurationOfFall { get; set; }
    }
}