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
    
    public partial class THICHVACHAN
    {
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public bool TrangThai { get; set; }
    
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual NHANVIENGIUPVIEC NHANVIENGIUPVIEC { get; set; }
    }
}