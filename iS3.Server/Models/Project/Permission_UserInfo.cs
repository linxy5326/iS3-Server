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
    
    public partial class Permission_UserInfo
    {
        public Permission_UserInfo()
        {
            this.Permission_Role_User = new HashSet<Permission_Role_User>();
        }
    
        public int ID { get; set; }
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public string RealName { get; set; }
        public string MobilePhone { get; set; }
        public string Remark { get; set; }
    
        public virtual ICollection<Permission_Role_User> Permission_Role_User { get; set; }
    }
}
