//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sales
    {
        public int id { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<decimal> unit { get; set; }
        public Nullable<int> customer_id { get; set; }
        public Nullable<int> product_id { get; set; }
    
        public virtual Customers Customers { get; set; }
        public virtual Products Products { get; set; }
    }
}
