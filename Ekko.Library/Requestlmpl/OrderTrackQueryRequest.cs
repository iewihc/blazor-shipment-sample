using System;
using PropertyChanged;

namespace Ekko.Library.Requestlmpl
{

    [AddINotifyPropertyChangedInterface]
    public class OrderTrackQueryRequest
    {
        public string nbr1 { get; set; }
        public string nbr2 { get; set; }
        public string cus_nbr1 { get; set; }
        public string cus_nbr2 { get; set; }
        public string item_nbr1 { get; set; }
        public string item_nbr2 { get; set; }
        public string DocStatus { get; set; }
        public DateTime date1 { get; set; }
        public DateTime date2 { get; set; }
        public int ShipmentStatusOption { get; set; }//出貨狀況 
        public int OrderDataOption { get; set; }//訂單資料 
        public int SortOption { get; set; }//排序方式
        public int ExpectShipmentDateOption { get; set; }//預計出貨日
        public string IsError { get; set; }
    }
}