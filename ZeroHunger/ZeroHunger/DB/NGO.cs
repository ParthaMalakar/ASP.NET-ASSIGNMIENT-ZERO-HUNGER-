//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZeroHunger.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class NGO
    {
        public NGO()
        {
            this.Emoplyees = new HashSet<Emoplyee>();
            this.Restrurants = new HashSet<Restrurant>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Pno { get; set; }
    
        public virtual ICollection<Emoplyee> Emoplyees { get; set; }
        public virtual ICollection<Restrurant> Restrurants { get; set; }
    }
}
