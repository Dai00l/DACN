//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DACN
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThuePhong
    {
        public int id { get; set; }
        public Nullable<int> idPhong { get; set; }
        public string idKhachhang { get; set; }
    
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual Phong Phong { get; set; }
    }
}
