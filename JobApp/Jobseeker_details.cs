//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jobseeker_details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Jobseeker_details()
        {
            this.Job_Applications_details = new HashSet<Job_Applications_details>();
        }
    
        public int id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public Nullable<int> Resume_id { get; set; }
        public Nullable<int> Jobseeker_age { get; set; }
        public string Password { get; set; }
        public string User_Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job_Applications_details> Job_Applications_details { get; set; }
        public virtual Resume_details Resume_details { get; set; }
    }
}
