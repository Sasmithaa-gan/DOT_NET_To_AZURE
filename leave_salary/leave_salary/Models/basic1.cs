//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace leave_salary.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class basic1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public basic1()
        {
            this.leaves = new HashSet<leave>();
            this.leaveapps = new HashSet<leaveapp>();
        }
    
        public int id { get; set; }
        public string emp_name { get; set; }
        public int emp_id { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<leave> leaves { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<leaveapp> leaveapps { get; set; }
    }
}
