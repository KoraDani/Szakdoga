//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SM3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tobbeszkoz
    {
        public int eszkozID { get; set; }
        public int szobaID { get; set; }
        public sbyte bekiE { get; set; }
    
        public virtual eszkozok eszkozok { get; set; }
        public virtual szoba szoba { get; set; }
    }
}