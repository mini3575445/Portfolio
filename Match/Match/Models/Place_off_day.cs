//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Match.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(MetaPlace_off_day))]

    public partial class Place_off_day
    {
        public int place_off_day_number { get; set; }
        public string place_id { get; set; }
        public string place_off_day1 { get; set; }
    
        public virtual Place Place { get; set; }
    }
}
