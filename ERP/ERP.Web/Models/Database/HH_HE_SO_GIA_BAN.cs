//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Web.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class HH_HE_SO_GIA_BAN
    {
        public int ID { get; set; }
        public int TUAN { get; set; }
        public int NAM { get; set; }
        public string MA_NHOM_HANG { get; set; }
        public Nullable<System.DateTime> NGAY_DIEU_CHINH { get; set; }
        public string DONG_SERI { get; set; }
        public string LOAI_KHACH_LE { get; set; }
        public string LOAI_KHACH_MUA_NHIEU { get; set; }
        public string KHACH_DAI_LY { get; set; }
        public string KHACH_KHONG_LAY_VAT { get; set; }
        public string SL_MUA_HON_30 { get; set; }
        public string SL_MUA_HON_100 { get; set; }
        public string SL_MUA_HON_200 { get; set; }
        public string GHI_CHU { get; set; }
    
        public virtual HH_NHOM_VTHH HH_NHOM_VTHH { get; set; }
    }
}
