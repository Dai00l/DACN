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
    
    public partial class Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phong()
        {
            this.CTDVs = new HashSet<CTDV>();
            this.ThuePhongs = new HashSet<ThuePhong>();
        }
    
        public int MaPhong { get; set; }
        public string TenPhong { get; set; }
        public string TrangThaiPhong { get; set; }
        public Nullable<int> idCosohatangphong { get; set; }
        public Nullable<int> idTang { get; set; }
    
        public virtual CoSoHaTangPhong CoSoHaTangPhong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDV> CTDVs { get; set; }
        public virtual Tang Tang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThuePhong> ThuePhongs { get; set; }
    }
}
