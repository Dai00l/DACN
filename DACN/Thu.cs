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
    
    public partial class Thu
    {
        public int MaThu { get; set; }
        public Nullable<decimal> SoTien { get; set; }
        public string NoiDung { get; set; }
        public string idNhanVien { get; set; }
        public string idKhachHang { get; set; }
    
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual Nhanvien Nhanvien { get; set; }
    }
}
