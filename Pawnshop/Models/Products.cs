//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pawnshop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.MonthlyPayments = new HashSet<MonthlyPayments>();
            this.ProductsSells = new HashSet<ProductsSells>();
        }
    
        public int ProductID { get; set; }
        public string Title { get; set; }
        public int ProductTypeID { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public double AssessedCost { get; set; }
        public int EmployeeID { get; set; }
        public double DepositAmount { get; set; }
        public double RansomAmount { get; set; }
        public int ClientID { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Employess Employess { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonthlyPayments> MonthlyPayments { get; set; }
        public virtual ProductsTypes ProductsTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductsSells> ProductsSells { get; set; }
    }
}
