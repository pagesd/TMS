using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model.Settlement
{
    /// <summary>
    /// 付款
    /// </summary>
    public class PaymentModel
    {
        public int id           { get; set; }
        public string name         { get; set; }
        public float money        { get; set; }
        public int way          { get; set; }
        public string pay_name     { get; set; }
        public string opening_bank { get; set; }
        public string card_number  { get; set; }
        public DateTime payment_time { get; set; }
        public string describe   { get; set; }
        public string comment      { get; set; }
        public string image        { get; set; }
        public string proposer     { get; set; }
        public DateTime create_time  { get; set; }
        public int state { get; set; }
    }
}
