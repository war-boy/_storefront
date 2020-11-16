//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreFrontLAB.DATA.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Employees1 = new HashSet<Employee>();
        }
    
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        public System.DateTime DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public Nullable<int> DirectReportID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees1 { get; set; }
        public virtual Employee Employee1 { get; set; }
    }
}
