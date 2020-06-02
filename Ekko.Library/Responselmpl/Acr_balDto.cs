using System;
using System.Collections.Generic;
using System.Text;

namespace Ekko.Library.Responselmpl
{
    public class Acr_balDto
    {
        public string cus_nbr { get; set; }
        public string acr_mon { get; set; }
        public decimal bal_amt { get; set; }
        public decimal shp_amt { get; set; }
        public decimal tax_amt { get; set; }
        public decimal rshp_amt { get; set; }
        public decimal rtax_amt { get; set; }
        public decimal cah_amt { get; set; }
        public decimal nms_amt { get; set; }
        public decimal cut_amt { get; set; }
        public decimal pre_amt { get; set; }
        public decimal rec_amt { get; set; }
        public string iop { get; set; }
        public string tranok { get; set; }
        public string tranop { get; set; }
        public decimal trancnt { get; set; }
    }
}
