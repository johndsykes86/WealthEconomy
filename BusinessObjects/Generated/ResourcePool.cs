//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(BusinessObjects.Metadata.ResourcePoolMetadata))]
    public partial class ResourcePool : IEntity<int>
    {
        public ResourcePool()
        {
            this.ResourcePoolOrganizationSet = new HashSet<ResourcePoolOrganization>();
            this.UserResourcePoolSet = new HashSet<UserResourcePool>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
    
        public virtual ICollection<ResourcePoolOrganization> ResourcePoolOrganizationSet { get; set; }
        public virtual ICollection<UserResourcePool> UserResourcePoolSet { get; set; }
    }
}