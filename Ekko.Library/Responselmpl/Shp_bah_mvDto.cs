using System;
using PropertyChanged;

namespace Ekko.Library.Responselmpl
{
    [AddINotifyPropertyChangedInterface]
    public class Shp_bah_mvDto
    {
        public string nbr { get; set; }
        public string acc_nbr { get; set; }
        public string acr_mon { get; set; }
        public string sale_nbr { get; set; }
        public string pay_term { get; set; }
        public string io_p { get; set; }
        public DateTime? nbrdate { get; set; }
        public string cus_nbr { get; set; }
        public string cen_cus { get; set; }
        public string ware_nbr { get; set; }
        public decimal tot_amt { get; set; }
        public string tax_type { get; set; }
        public decimal tax_amt { get; set; }
        [AlsoNotifyFor("TotalShipment")]
        public decimal ctot_amt { get; set; }
        [AlsoNotifyFor("TotalShipment")]

        public decimal ctax_amt { get; set; }
        public decimal coin_per { get; set; }
        public string ivc_nbr { get; set; }
        public string status { get; set; }
        public string remark { get; set; }
        public decimal pack_qty { get; set; }
        public decimal cost_amt { get; set; }
        public decimal rec_amt { get; set; }
        public decimal crec_amt { get; set; }
        public string logtype { get; set; }
        public string logtxt { get; set; }
        public string mess { get; set; }
        public string fmiltle { get; set; }
        public string dmiltle { get; set; }
        public string mnote { get; set; }
        public string no { get; set; }
        public string invoice { get; set; }
        public string messrs1 { get; set; }
        public string messrs2 { get; set; }
        public string shipper { get; set; }
        public string per { get; set; }
        public string sailing { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string lcno { get; set; }
        public string contract { get; set; }
        public string coin_nbr { get; set; }
        public string remark1 { get; set; }
        public string remark2 { get; set; }
        public string form_nbr { get; set; }
        public string last_user { get; set; }
        public string lc_no { get; set; }
        public DateTime? dated { get; set; }
        public string pack { get; set; }
        public string attn { get; set; }
        public string shipped { get; set; }
        public string pack_from { get; set; }
        public string pay { get; set; }
        public decimal cut { get; set; }
        public string mttd { get; set; }
        public bool is_sure { get; set; }
        public bool is_prn { get; set; }
        public bool is_bom { get; set; }
        public string billto { get; set; }
        public string shipto { get; set; }
        public string shipw { get; set; }
        public string cdate { get; set; }
        public string comdi { get; set; }
        public string cattname { get; set; }
        public string senaddr { get; set; }
        public DateTime? crt_date { get; set; }
        public string crt_user { get; set; }
        public DateTime? edit_date { get; set; }
        public string edit_user { get; set; }
        public string tranok { get; set; }
        public string tranop { get; set; }
        public decimal trancnt { get; set; }
        public string Expr2 { get; set; }
        public string sale_name { get; set; }
        public string ware_desc { get; set; }
        public string tax_desc { get; set; }
        public string coin_desc { get; set; }
        public string cus_alias { get; set; }
        

        public decimal TotalShipment => ctot_amt + ctax_amt;
    }
}