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
    
    public partial class KD_MUC_TIEU_DOANH_SO
    {
        public int ID { get; set; }
        public int THANG { get; set; }
        public int NAM { get; set; }
        public string NHAN_VIEN { get; set; }
        public decimal MUC_TIEU_DOANH_SO_THANG { get; set; }
        public decimal MUC_TIEU_DOANH_SO_NAM { get; set; }
        public string GHI_CHU { get; set; }
        public string TRUC_THUOC { get; set; }
    
        public virtual CCTC_CONG_TY CCTC_CONG_TY { get; set; }
        public virtual HT_NGUOI_DUNG HT_NGUOI_DUNG { get; set; }
    }
}