//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DynThings.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DynSetting
    {
        public long ID { get; set; }
        public string DBVersion { get; set; }
        public string DevelopmentMode { get; set; }
        public string DefaultRecordsPerPage { get; set; }
        public string PlatformKey { get; set; }
        public string PublicAccess { get; set; }
        public string PublicSignUP { get; set; }
        public string EnableSystemLogger { get; set; }
    }
}