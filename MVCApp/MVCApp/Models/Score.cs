//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Score
    {
        public int ScoreID { get; set; }
        public string Judge { get; set; }
        public int Dive { get; set; }
        public Nullable<double> Score1 { get; set; }
    
        public virtual Dive Dive1 { get; set; }
    }
}
