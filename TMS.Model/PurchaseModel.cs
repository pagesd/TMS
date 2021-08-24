using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model
{
    /// <summary>
    /// 物资采购
    /// </summary>
    public class PurchaseModel
    {
        public int id          { get; set; }
        public string name        { get; set; }
        public string type        { get; set; }
        public string texture     { get; set; }
        public string scale       { get; set; }
        public string origin      { get; set; }
        public int number      { get; set; }
        public DateTime expectation { get; set; }
        public string useis       { get; set; }
        public string comment     { get; set; }
        public string proposer    { get; set; }
        public DateTime create_time { get; set; }
        public int state       { get; set; }
        public string approver    { get; set; }
        public int way_money { get; set; }
        public int price { get; set; }
        public int buying { get; set; }
    }
}
