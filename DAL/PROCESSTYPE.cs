//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROCESSTYPE
    {
        public PROCESSTYPE()
        {
            this.LOGTABLEs = new HashSet<LOGTABLE>();
        }
    
        public int ID { get; set; }
        public string ProcessName { get; set; }
    
        public virtual ICollection<LOGTABLE> LOGTABLEs { get; set; }
    }
}
