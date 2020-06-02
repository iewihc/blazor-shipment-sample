using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ekko.Library.Responselmpl
{
    public class Read_ordDto
    {


        [DisplayName("訂單號碼")]
        public string nbr { get; set; }
        [DisplayName("序號")]
        public decimal seq { get; set; }
        [DisplayName("客戶訂單號碼")]
        public string desc_no1 { get; set; }
        [DisplayName("產品編號")]
        public string item_nbr { get; set; }
        //少產品名稱.
        [DisplayName("預計交貨日")]
        public DateTime? plan_date { get; set; }
        [DisplayName("應交數量")]
        public decimal readqty { get; set; }
        [DisplayName("本次出貨量")]
        public decimal read_qty { get; set; }
        
        [DisplayName("備註")]

        public string remark { get; set; }

        public bool IsEdit { get; set; }
        [Display(Order = -1)]
        public DateTime? days;
        [Display(Order = -1)]

        public DateTime? ord_date;
        [Display(Order = -1)]

        public string cus_item;
        [Display(Order = -1)]

        public int oh_qty;
    }
}