using System;
using System.ComponentModel;
using PropertyChanged;

namespace Ekko.Library.Responselmpl
{
    public class Shp_bah_SearchDto
    {
        [DisplayName("出貨單號")]
        public string nbr { get; set; }
        
        [DisplayName("客戶簡稱")]
        public string cus_alias { get; set; }
        
        [DisplayName("出貨日期")]
        public DateTime? plan_date { get; set; }
        
        [DisplayName("單據類別")]
        public string io_p { get; set; }
        
        [DisplayName("業務人員")]
        public string sale_name { get; set; }
        
        [DisplayName("狀態")]
        public string status { get; set; }
        
        [DisplayName("備註")]
        public string remark { get; set; }
    }
}