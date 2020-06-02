using System;
using System.Collections.Generic;
using System.Text;

namespace Ekko.Library.Responselmpl
{
    public class OrderApproveDetailsResponse
    {
        public string nbr { get; set; }
        public string desc_no { get; set; }
        public string ioseq { get; set; }
        public decimal seq { get; set; }
        public DateTime plan_date { get; set; }
        public string cus_nbr { get; set; }
        public string cus_alias { get; set; }
        public string sale_name { get; set; }
        public string item_nbr { get; set; }
        public string item_name { get; set; }
        public string item_alias { get; set; }
        public string item_desc { get; set; }
        public string unit { get; set; }
        public decimal c_price { get; set; }
        public decimal price { get; set; }
        public decimal c_amt { get; set; }
        public decimal amt { get; set; }
        public string un_desc { get; set; }
        public decimal qty { get; set; }
        public decimal ioqty { get; set; }
        public decimal mioqty { get; set; }
        public string remark { get; set; }
        public string status { get; set; }
        public DateTime? nbrdate { get; set; }
        public bool? sure { get; set; }
        public string rev_remark { get; set; }
        public string st_desc { get; set; }
    }

}
