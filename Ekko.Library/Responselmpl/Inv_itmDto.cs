using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ekko.Library.Responselmpl
{
    public class Inv_itmDto
    {

        [DisplayName("產品代號")]
        public string item_nbr { get; set; }
        [DisplayName("產品名稱")]
        public string item_name { get; set; }
        [DisplayName("產品名稱")]
        public string item_desc { get; set; }
        [DisplayName("規格說明")]
        public string itemdesc { get; set; }
        [DisplayName("業務性質")]
        public string shp_desc { get; set; }
        [DisplayName("英文名稱")]
        public string eng_name { get; set; }


        public bool IsCheck { get; set; }

        [Display(Order = -1)]
        public string cus_nbr { get; set; }
        [Display(Order = -1)]
        public string big_key { get; set; }
        [Display(Order = -1)]
        public string q_code { get; set; }
        [Display(Order = -1)]
        public decimal itm_type { get; set; }


        [Display(Order = -1)]
        public string item_alias { get; set; }

        [Display(Order = -1)]
        public string rec_un { get; set; }

        //[Display(Order = -1)]
        //public string item_un { get; set; }
        //public string sales_un { get; set; }
        //public string ud_oh_ctl { get; set; }
        //public decimal safety_qty { get; set; }
        //public string ware_nbr { get; set; }
        //public string item_type { get; set; }
        //public string m_type { get; set; }
        //public string i_type { get; set; }
        //public decimal a_in_qty { get; set; }
        //public string ven_nbr { get; set; }
        //public string item_nbr1 { get; set; }
        //public string pro_nbr { get; set; }
        //public decimal mat_qty { get; set; }
        //public string mat_un { get; set; }
        //public decimal unit_price { get; set; }
        //public decimal bot_price { get; set; }
        //public string pri_type { get; set; }
        //public decimal price_1 { get; set; }
        //public decimal price_2 { get; set; }
        //public decimal price_3 { get; set; }
        //public decimal price_4 { get; set; }
        //public decimal price_5 { get; set; }
        //public decimal unit_cost { get; set; }
        //public decimal matl_cost { get; set; }
        //public decimal matl2_cost { get; set; }
        //public decimal hard_cost { get; set; }
        //public decimal labor_cost { get; set; }
        //public decimal other_cost { get; set; }
        //public decimal comm_cost { get; set; }
        //public decimal in_box { get; set; }
        //public decimal qty_pbox { get; set; }
        //public decimal qty_box { get; set; }
        //public decimal qty_xz { get; set; }
        //public decimal cj_per { get; set; }
        //public decimal cuft { get; set; }
        //public decimal n_wight { get; set; }
        //public decimal g_wight { get; set; }
        //public string remark { get; set; }
        //public string remark1 { get; set; }
        //public decimal oh_qty { get; set; }
        //public decimal pur_qty { get; set; }
        //public decimal ord_qty { get; set; }
        //public decimal sub_qty { get; set; }
        //public DateTime? newdate { get; set; }
        //public DateTime? l_shpdate { get; set; }
        //public DateTime? l_update { get; set; }
        //public string image { get; set; }
        //public string image1 { get; set; }
        //public decimal status { get; set; }

        //public bool isedit { get; set; }
        //public string p_weight { get; set; }
        //public decimal cyc_time { get; set; }
        //public string item_ctl { get; set; }
        //public string cadfile { get; set; }
        //public DateTime? l_edtdate { get; set; }
        //public DateTime? l_crtdate { get; set; }
        //public string sys_type { get; set; }
        //public string stock_desc { get; set; }
        //public string bar_code { get; set; }
        //public string bar_code2 { get; set; }
        //public DateTime? l_recdate { get; set; }
        //public decimal last_price { get; set; }
        //public decimal l_shppri { get; set; }
        //public string last_ven { get; set; }
        //public DateTime? crt_date { get; set; }
        //public string crt_user { get; set; }
        //public string bmp_var { get; set; }
        //public string zyc_nbr { get; set; }
        //public decimal bas_l { get; set; }
        //public decimal bas_w { get; set; }
        //public decimal bas_h { get; set; }
        //public decimal bas_bz { get; set; }
        //public decimal bas_cqs { get; set; }
        //public decimal bas_cqz { get; set; }
        //public decimal bas_kf { get; set; }
        //public decimal bas_dz { get; set; }
        //public decimal bas_ldz { get; set; }
        //public decimal bas_bb { get; set; }
        //public string t_unit { get; set; }
        //public decimal mak_qty { get; set; }
        //public decimal bom_qty { get; set; }
        //public string sku { get; set; }
        //public string bas_oly { get; set; }
        //public string ebas_oly { get; set; }
        //public string zz_remark { get; set; }
        //public decimal ll_per { get; set; }
        //public decimal wy_price { get; set; }
        //public string qc_excel { get; set; }
        //public DateTime? l_arjdate { get; set; }
        //public string arj_type { get; set; }
        //public DateTime? edit_date { get; set; }
        //public string edit_user { get; set; }
        //public string tranok { get; set; }
        //public string tranop { get; set; }
        //public decimal trancnt { get; set; }
    }
}