//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace crmmedipol.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class CRM_OGRENCI
    {
        public int ID { get; set; }
        public string AD_SOYAD { get; set; }
        public string MAIL { get; set; }
        public string TELEFON { get; set; }
        public Nullable<byte> SEHIR { get; set; }
        public string ACIKLAMA_1 { get; set; }
        public string ACIKLAMA_2 { get; set; }
        public Nullable<byte> OGR_SINAV { get; set; }
        public Nullable<byte> OGR_OKUL { get; set; }
    
        public virtual CRM_SEHIR CRM_SEHIR { get; set; }
        public virtual CRM_SINAVSONUC CRM_SINAVSONUC { get; set; }
        public virtual CRM_OKUL CRM_OKUL { get; set; }
    }
}
