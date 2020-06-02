using System;

namespace Ekko.Library.Requestlmpl
{
    public class OrderApproveRequest
    {
        public string nbr1 { get; set; }
        public string nbr2{ get; set; }
        public string cus_nbr1 { get; set; }
        public string cus_nbr2 { get; set; }
        public DateTime date1 { get; set; }
        public DateTime date2 { get; set; }
        public bool? ApproveOrReply { get; set; }
    }
}