using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Model.Settlement
{
    /// <summary>
    /// 结算  进项
    /// </summary>
    public class CourseModel
    {
        public int id           { get; set; }
        public string invoiceId    { get; set; }
        public string unit         { get; set; }
        public int state        { get; set; }
        public float money        { get; set; }
        public float tax_rate     { get; set; }
        public float tax          { get; set; }
        public DateTime invoice_time { get; set; }
        public string comment      { get; set; }
        public string single       { get; set; }
        public DateTime create_time  { get; set; }
    }
}
