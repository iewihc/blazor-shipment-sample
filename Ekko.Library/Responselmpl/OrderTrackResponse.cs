using System;
using PropertyChanged;

namespace Ekko.Library.Responselmpl
{
    [AddINotifyPropertyChangedInterface]
    public class OrderTrackResponse
    {
        public string nbr { get; set; }
        public string cus_ord { get; set; }
        public string ioseq { get; set; }
        public DateTime? plan_date { get; set; }
        public string cus_nbr { get; set; }
        public string cus_alias { get; set; }
        public string item_nbr { get; set; }
        public string item_name { get; set; }
        public string item_alias { get; set; }
        public string sale_name { get; set; }
        public string unit { get; set; }
        public string un_desc { get; set; }
        public decimal qty { get; set; }
        public decimal qty1 { get; set; }
        public decimal d_qty { get; set; }
        public decimal d_qty1 { get; set; }
        public decimal ioqty { get; set; }
        public string item_desc { get; set; }
        public decimal mioqty { get; set; }
        public string no { get; set; }
        public string remark { get; set; }
        public string status { get; set; }
        public string st_desc { get; set; }

        public string rev_remark { get; set; }
    }
}