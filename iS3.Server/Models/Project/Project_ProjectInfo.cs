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
    
    public partial class Project_ProjectInfo
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectAddress { get; set; }
        public string ConstructionUnit { get; set; }
        public string GeologicalSurveyUnit { get; set; }
        public string DesignUnit { get; set; }
        public string SupervisionUnits { get; set; }
        public string GeneralContractUnit { get; set; }
        public Nullable<decimal> ContractAmount { get; set; }
        public Nullable<int> ContractPeriod { get; set; }
        public string Remark { get; set; }
    }
}
