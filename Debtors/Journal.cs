//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Debtors
{
    using System;
    using System.Collections.Generic;
    
    public partial class Journal
    {
        public int Id { get; set; }
        public int DebtorId { get; set; }
        public System.DateTime Date { get; set; }
        public string Text { get; set; }
    
        public virtual Debtor Debtor { get; set; }
    }
}
