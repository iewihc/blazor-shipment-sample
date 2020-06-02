using System;
using System.Collections.Generic;
using Ekko.Library.Responselmpl;

namespace Ekko.Library.Requestlmpl
{
    public class Map44Uow:Shp_bah_mvDto
    {
        public Shp_bat_mvDto[] shp_bat_mvs { get; set; }
        public Shp_bat1[] shp_bat1s { get; set; }
        
        
        /// <summary>
        /// WEB版
        /// </summary>
        public List<Shp_bat_mvDto> toBeInsert { get; set; }
        public List<Shp_bat_mvDto> toBeUpdate { get; set; }
        public List<Shp_bat_mvDto> toBeDelete { get; set; }
    }
    
    public partial class Shp_bat1
    {
        public string nbr { get; set; }
        public string seq { get; set; }
        public string ioseq { get; set; }
        public string item_nbr { get; set; }
        public string pro_nbr { get; set; }
        public string ware_nbr { get; set; }
        public string unit { get; set; }
        public decimal qty { get; set; }
        public string kcnbr1 { get; set; }
        public string kcnbr2 { get; set; }
        public decimal jqty { get; set; }
        public DateTime? nbrdate { get; set; }
        public string io_p { get; set; }
        public string tranok { get; set; }
        public string tranop { get; set; }
        public decimal trancnt { get; set; }
    }
}