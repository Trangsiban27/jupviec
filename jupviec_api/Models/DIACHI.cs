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
    
    public partial class DIACHI
    {
        public string MaKH { get; set; }
        public string MaDiaChi { get; set; }
        public string TenDiaChi { get; set; }
        public string DiaChi1 { get; set; }
    
        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}