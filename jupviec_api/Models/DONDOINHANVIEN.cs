//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jupviec_api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DONDOINHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONDOINHANVIEN()
        {
            this.CT_DONDOI_NHANGIUPVIEC = new HashSet<CT_DONDOI_NHANGIUPVIEC>();
        }
    
        public string MaDonDoi { get; set; }
        public string MaDonBiDoi { get; set; }
        public int TrangThaiDon { get; set; }
        public System.DateTime NgayDD { get; set; }
        public System.TimeSpan GioDoi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DONDOI_NHANGIUPVIEC> CT_DONDOI_NHANGIUPVIEC { get; set; }
        public virtual DONDATDICHVU DONDATDICHVU { get; set; }
    }
}