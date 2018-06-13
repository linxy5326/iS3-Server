﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_iS3_ProjectContext : iS3Context
    {
        public DB_iS3_ProjectContext(string project)
            : base("DB_iS3_" + project, "Models.Project.DB_iS3_Project")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Base_DataSourceInfo> Base_DataSourceInfo { get; set; }
        public virtual DbSet<Base_DataSourceType> Base_DataSourceType { get; set; }
        public virtual DbSet<Monitoring_InstrumentInfo> Monitoring_InstrumentInfo { get; set; }
        public virtual DbSet<Monitoring_MonGroupInfo> Monitoring_MonGroupInfo { get; set; }
        public virtual DbSet<Monitoring_MonPointInfo> Monitoring_MonPointInfo { get; set; }
        public virtual DbSet<Monitoring_MonProjectInfo> Monitoring_MonProjectInfo { get; set; }
        public virtual DbSet<Project_ObjectsDefinition> Project_ObjectsDefinition { get; set; }
        public virtual DbSet<Project_ProjectInfo> Project_ProjectInfo { get; set; }
        public virtual DbSet<Geology_Boreholes> Geology_Boreholes { get; set; }
        public virtual DbSet<Geology_BoreholeStrataInfo> Geology_BoreholeStrataInfo { get; set; }
        public virtual DbSet<Geology_ConfinedWater> Geology_ConfinedWater { get; set; }
        public virtual DbSet<Geology_PhreaticWater> Geology_PhreaticWater { get; set; }
        public virtual DbSet<Geology_RiverWater> Geology_RiverWater { get; set; }
        public virtual DbSet<Geology_SoilProperties> Geology_SoilProperties { get; set; }
        public virtual DbSet<Geology_Strata> Geology_Strata { get; set; }
        public virtual DbSet<Geology_StrataSection> Geology_StrataSection { get; set; }
        public virtual DbSet<Geology_WaterProperties> Geology_WaterProperties { get; set; }
        public virtual DbSet<Structure_SegmentLinings> Structure_SegmentLinings { get; set; }
        public virtual DbSet<Structure_Segments> Structure_Segments { get; set; }
        public virtual DbSet<Structure_SLBaseType> Structure_SLBaseType { get; set; }
        public virtual DbSet<Structure_SLConstructionRecords> Structure_SLConstructionRecords { get; set; }
        public virtual DbSet<Structure_SLConvergence> Structure_SLConvergence { get; set; }
        public virtual DbSet<Structure_SLCrack> Structure_SLCrack { get; set; }
        public virtual DbSet<Structure_SLPostureRecords> Structure_SLPostureRecords { get; set; }
        public virtual DbSet<Structure_SLQualityRecords> Structure_SLQualityRecords { get; set; }
        public virtual DbSet<Structure_SLSettlement> Structure_SLSettlement { get; set; }
        public virtual DbSet<Structure_SLSpall> Structure_SLSpall { get; set; }
        public virtual DbSet<Structure_SLType> Structure_SLType { get; set; }
        public virtual DbSet<Structure_TunnelAxes> Structure_TunnelAxes { get; set; }
        public virtual DbSet<Structure_TunnelAxesPoints> Structure_TunnelAxesPoints { get; set; }
        public virtual DbSet<Structure_Tunnels> Structure_Tunnels { get; set; }
    }
}
